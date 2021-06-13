using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class CreateRevenueReportHandler : CreateReportHandler
    {
        protected async override Task<DataGridView> ProcessCreateReport(int month, int year,
            DataGridView dgvReport)
        {
            if (await IsExistInvoke(month, year))
            {
                DateTime[] createdReportDates = await GetCreatedDates(month, year,
                    "HOADON HD, CTKB CT", GetCreatedInvokeDateConditionForSQL(month, year), 7);
                string ID, table = "CTBCDOANHTHU";

                for (int i = 0; i < createdReportDates.Length; i++)
                {
                    ID = await IDHandler.FindNewID(table, "MACTBCDOANHTHU", "DT", 5);
                    DetailRevenueReport detailRevenueReport = new DetailRevenueReport(ID,
                        createdReportDates[i]);
                    DataHandler.InsertData(table, detailRevenueReport.GetValueForInsertIntoSQL());
                }

                dgvReport = await LoadReport(month, year, dgvReport);
            }

            return dgvReport;
        }

        protected override void ProcessLoadReport(SqlDataReader reader, ref DataGridView dgvReport)
        {
            DetailRevenueReport detailRevenueReport = new DetailRevenueReport(reader);
            dgvReport.Rows.Add(detailRevenueReport.ID, detailRevenueReport.createdDate.Day.ToString() +
                "/" + detailRevenueReport.createdDate.Month.ToString() + "/" +
                detailRevenueReport.createdDate.Year.ToString(),
                detailRevenueReport.numberOfPatients.ToString(), detailRevenueReport.revenue.ToString(),
                detailRevenueReport.rationMonthRevenue.ToString());
        }

        protected override SqlDataReader ReadData(int month, int year, SqlConnection connection)
        {
            return DataHandler.ReadData("CTBCDOANHTHU", connection, GetDateConditionForSQL(month, year,
                "NGAYLAP"), "*");
        }

        private async Task<DateTime[]> GetCreatedDates(int month, int year, string tables,
            string condition, int index)
        {
            SqlConnection connection = await DataHandler.OpenConnection();
            SqlDataReader reader = DataHandler.ReadData(tables, connection, condition + " ORDER BY " +
                "NGAYKHAMBENH", "*");
            List<DateTime> createdDates = new List<DateTime>();
            DateTime previousCreatedDate = DateTime.Now, createdDate;

            while (reader.HasRows)
            {
                if (!reader.Read())
                {
                    break;
                }

                createdDate = reader.GetDateTime(index);

                if (createdDate != previousCreatedDate)
                {
                    createdDates.Add(createdDate);
                    previousCreatedDate = createdDate;
                }
            }

            DataHandler.CloseConnection(ref connection);

            return createdDates.ToArray();
        }

        private async Task<bool> IsExistInvoke(int month, int year)
        {
            return (await CountRecord("HOADON HD, CTKB CT", GetCreatedInvokeDateConditionForSQL(month,
                year))) != 0;
        }

        private string GetCreatedInvokeDateConditionForSQL(int month, int year)
        {
            return GetDateConditionForSQL(month, year, "NGAYKHAMBENH") + " AND HD.MACTKB = CT.MACTKB";
        }

        protected async override Task<bool> IsExistReport(int month, int year)
        {
            return (await CountRecord("CTBCDOANHTHU", GetDateConditionForSQL(month, year, "NGAYLAP")))
                != 0;
        }
    }
}