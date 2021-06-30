using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using Guna.UI2.WinForms;

namespace BUS
{
    public abstract class CreateImportedMedicineSlipHandler : Handler
    {
        public static async Task<DataGridView> LoadMedicineList(DataGridView dgvMedicineList)
        {
            dgvMedicineList.Rows.Clear();

            int index = 1;
            SqlConnection connection = await DataHandler.OpenConnection();
            SqlDataReader reader = DataHandler.ReadData("THUOC T, DONVITINH DVT", connection, 
                "WHERE T.MADONVITINH = DVT.MADONVITINH ORDER BY MATHUOC", "*");

            while (reader.HasRows)
            {
                if (!reader.Read())
                {
                    break;
                }

                Medicine medicine = new Medicine(reader);
                Unit unit = new Unit(reader, 7);
                dgvMedicineList.Rows.Add(index++, medicine.ID, medicine.name, unit.name,
                    medicine.quantityOfInventory, medicine.importedUnitPrice, medicine.sellableUnitPrice,
                    medicine.ratioToCalculateSellableUnitPrice);
            }

            DataHandler.CloseConnection(ref connection);

            return dgvMedicineList;
        }

        public static void ShowSellableUnitPrice(Guna2TextBox tbImportedUnitPrice, 
            Guna2TextBox tbRatioToCalculateSellableUnitPrice, ref Guna2TextBox tbSellableUnitPrice)
        {
            try
            {
                tbSellableUnitPrice.Text = (int.Parse(tbImportedUnitPrice.Text) *
                    int.Parse(tbRatioToCalculateSellableUnitPrice.Text) / 100).ToString();
            }
            catch (Exception)
            {
                tbSellableUnitPrice.Text = "";
            }
        }

        public static async Task<ComboBox> LoadMedicineName(ComboBox cbMedicineName)
        {
            SqlConnection connection = await DataHandler.OpenConnection();
            SqlDataReader reader = DataHandler.ReadData("THUOC", connection, "", "*");

            while (reader.HasRows)
            {
                if (!reader.Read())
                {
                    break;
                }

                Medicine medicine = new Medicine(reader);
                cbMedicineName.Items.Add(medicine.name);
            }

            DataHandler.CloseConnection(ref connection);

            return cbMedicineName;
        }
        
        public static async Task<ComboBox> LoadUnit(ComboBox cbUnit)
        {
            SqlConnection connection = await DataHandler.OpenConnection();
            SqlDataReader reader = DataHandler.ReadData("DONVITINH", connection, "", "*");

            while (reader.HasRows)
            {
                if (!reader.Read())
                {
                    break;
                }

                Unit unit = new Unit(reader);
                cbUnit.Items.Add(unit.name);
            }

            DataHandler.CloseConnection(ref connection);

            return cbUnit;
        }

        public static async Task<DataGridView> CreateDetailImportedMedicineSlip(string name,
            int importedUnitPrice, string unitName, int ratioToCalculateSellableUnitPrice,
            int quantityOfInput, DataGridView dgvMedicineList)
        {
            Medicine medicine = await AddMedicine(name, importedUnitPrice, unitName,
                ratioToCalculateSellableUnitPrice);
            DetailImportedMedicineSlip detailImportedMedicineSlip =
                await AddDetailImportedMedicineSlip(medicine, quantityOfInput);
            Unit unit = await GetUnit(medicine);
            LoadDetailImportedMedicineSlip(detailImportedMedicineSlip, medicine, unit,
                ref dgvMedicineList);

            return dgvMedicineList;
        }

        private static void LoadDetailImportedMedicineSlip
            (DetailImportedMedicineSlip detailImportedMedicineSlip, Medicine medicine, Unit unit,
            ref DataGridView dgvMedicineList)
        {
            dgvMedicineList.Rows.Add(detailImportedMedicineSlip.ID, medicine.ID, medicine.name,
                unit.name, detailImportedMedicineSlip.quantityOfInput, medicine.importedUnitPrice,
                medicine.sellableUnitPrice, medicine.ratioToCalculateSellableUnitPrice);
        }

        private static async Task<Unit> GetUnit(Medicine medicine)
        {
            SqlConnection connection = await DataHandler.OpenConnection();
            SqlDataReader reader = DataHandler.ReadData("THUOC T, DONVITINH DVT", connection, "WHERE " +
                "T.MADONVITINH = DVT.MADONVITINH AND T.MADONVITINH = '" + medicine.unitID + "'", 
                "DVT.MADONVITINH, TENDONVITINH");
            reader.Read();
            Unit unit = new Unit(reader);
            DataHandler.CloseConnection(ref connection);

            return unit;
        }

        private static async Task<DetailImportedMedicineSlip> AddDetailImportedMedicineSlip
            (Medicine medicine, int quantityOfInput)
        {
            DetailImportedMedicineSlip detailImportedMedicineSlip =
                new DetailImportedMedicineSlip(await IDHandler.FindNewID("CTPHIEUNT", "MACTPHIEUNT",
                "CTPNT", 5), medicine.ID, quantityOfInput, DateTime.Now.Date,
                medicine.sellableUnitPrice, medicine.ratioToCalculateSellableUnitPrice);
            DataHandler.InsertData("CTPHIEUNT", detailImportedMedicineSlip.GetValueForInsertIntoSQL());

            return detailImportedMedicineSlip;
        }

        private static async Task<Medicine> AddMedicine(string name, int importedUnitPrice,
            string unitName, int ratioToCalculateSellableUnitPrice)
        {
            string table = "THUOC";
            SqlConnection connection = await DataHandler.OpenConnection();
            SqlDataReader reader = DataHandler.ReadData("DONVITINH", connection, "WHERE TENDONVITINH = N'" + 
                unitName + "'", "*");
            reader.Read();
            Unit unit = new Unit(reader);
            DataHandler.CloseConnection(ref connection);
            Medicine medicine = new Medicine(await IDHandler.FindNewID(table, "MATHUOC", "T", 5), name,
                importedUnitPrice, unit.ID, ratioToCalculateSellableUnitPrice);

            if (!await IsExistMedicine(medicine))
            {
                DataHandler.InsertData(table, medicine.GetValueForInsertIntoSQL());
            }
            else
            {
                DataHandler.UpdateData(table, "DONGIANHAP = " + medicine.importedUnitPrice + ", " +
                    "TYLETINHDONGIABAN = " + medicine.ratioToCalculateSellableUnitPrice,
                    GetExistMedicineCondition(medicine));
            }

            connection = await DataHandler.OpenConnection();
            reader = DataHandler.ReadData("THUOC", connection,
                GetExistMedicineCondition(medicine), "*");
            reader.Read();
            medicine = new Medicine(reader);
            DataHandler.CloseConnection(ref connection);

            return medicine;
        }

        private static async Task<bool> IsExistMedicine(Medicine medicine)
        {
            int numberOfRecord = await DataHandler.Calculate("COUNT", "*", "THUOC",
                GetExistMedicineCondition(medicine));

            return (numberOfRecord != 0);
        }

        private static string GetExistMedicineCondition(Medicine medicine)
        {
            return "WHERE TENTHUOC = N'" + medicine.name + "' AND MADONVITINH = '" + medicine.unitID +
                "'";
        }

        public static bool IsError(Guna2TextBox tbQuantityOfInput, Guna2TextBox tbImportedUnitPrice,
            Guna2TextBox tbRationToCalculateSellableUnitPrice, ComboBox cbUnit)
        {
            return (!CheckInput(tbImportedUnitPrice, "Đơn giá nhập") || !CheckInput(tbQuantityOfInput,
                "Số lượng nhập") || !CheckInput(tbRationToCalculateSellableUnitPrice,
                "Tỷ lệ tính đơn giá bán", 99) || !CheckUnit(cbUnit));
        }

        public static bool CheckUnit(ComboBox cbUnit)
        {
            if (!cbUnit.Items.Contains(cbUnit.Text))
            {
                NotificationHandler.NotifyError("Đơn vị tính không tồn tại");

                return false;
            }

            return true;
        }
    }
}