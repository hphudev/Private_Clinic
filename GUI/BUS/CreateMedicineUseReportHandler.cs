using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAO;
using System.Windows.Forms;
using DTO;

namespace BUS
{
    public class CreateMedicineUseReportHandler : CreateReportHandler
    {
        protected async override Task<DataGridView> ProcessCreateReport(int month, int year,
            DataGridView dgvReport)
        {
            if (await IsExistMedicalSlip(month, year))
            {
                string[] medicineIDs = await GetMedicineIDs(month, year);
                string ID, table = "CTBCSDTHUOC";

                for (int i = 0; i < medicineIDs.Length; i++)
                {
                    ID = await IDHandler.FindNewID(table, "MACTBCSDTHUOC", "SDT", 5);
                    DetailMedicineUseReport detailMedicineUseReport =
                        new DetailMedicineUseReport(ID, month, year, medicineIDs[i]);
                    DataHandler.InsertData(table, detailMedicineUseReport.GetValueForInsertIntoSQL());
                }

                dgvReport = await LoadReport(month, year, dgvReport);
            }

            return dgvReport;
        }

        protected override void ProcessLoadReport(SqlDataReader reader, ref DataGridView dgvReport)
        {
            DetailMedicineUseReport detailMedicineUseReport = new DetailMedicineUseReport(reader);
            Medicine medicine = new Medicine(reader, 6);
            Unit unit = new Unit(reader, 13);

            dgvReport.Rows.Add(detailMedicineUseReport.ID, medicine.name, unit.name,
                detailMedicineUseReport.numberOfUses, detailMedicineUseReport.frequencyUse);
        }

        protected override SqlDataReader ReadData(int month, int year, SqlConnection connection)
        {
            return DataHandler.ReadData("CTBCSDTHUOC CT, THUOC T, DONVITINH DVT", connection, "WHERE THANG = " +
                month + " AND NAM = " + year + " AND CT.MATHUOC = T.MATHUOC AND T.MADONVITINH = " +
                "DVT.MADONVITINH", "*");
        }

        private async Task<string[]> GetMedicineIDs(int month, int year)
        {
            SqlConnection connection = await DataHandler.OpenConnection();
            SqlDataReader reader = DataHandler.ReadData("CTPHIEUKB CTP, PHIEUKB P, CTKB CT", connection,
                GetCreatedDetailMedicalSlipDateConditionForSQL(month, year) + " ORDER BY NGAYKHAMBENH",
                "*");
            List<string> medicineIDs = new List<string>();
            string previousMedicineID = null, medicineID;

            while (reader.HasRows)
            {
                if (!reader.Read())
                {
                    break;
                }

                medicineID = reader.GetString(2);

                if (medicineID != previousMedicineID)
                {
                    medicineIDs.Add(medicineID);
                    previousMedicineID = medicineID;
                }
            }

            DataHandler.CloseConnection(ref connection);

            return medicineIDs.ToArray();
        }

        private async Task<bool> IsExistMedicalSlip(int month, int year)
        {
            return (await CountRecord("CTPHIEUKB CTP, PHIEUKB P, CTKB CT",
                GetCreatedDetailMedicalSlipDateConditionForSQL(month, year))) != 0;
        }

        private string GetCreatedDetailMedicalSlipDateConditionForSQL(int month, int year)
        {
            return GetDateConditionForSQL(month, year, "NGAYKHAMBENH") + " AND CTP.MAPHIEUKB = " +
                "P.MAPHIEUKB AND P.MACTKB = CT.MACTKB";
        }

        protected async override Task<bool> IsExistReport(int month, int year)
        {
            return (await CountRecord("CTBCSDTHUOC", "WHERE THANG = " + month + " AND NAM = " + year +
                "")) != 0;
        }
    }
}