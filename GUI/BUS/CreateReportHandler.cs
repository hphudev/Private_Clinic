using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using Guna.UI2.WinForms;

namespace BUS
{
    public abstract class CreateReportHandler : Handler
    {
        public async Task<DataGridView> CreateReport(int month, int year, DataGridView dgvReport)
        {
            dgvReport.Rows.Clear();

            if (!IsError(month, year))
            {
                if (!await IsExistReport(month, year))
                {
                    dgvReport = await ProcessCreateReport(month, year, dgvReport);
                }
                else
                {
                    dgvReport = await LoadReport(month, year, dgvReport);
                }
            }

            return dgvReport;
        }

        protected async virtual Task<DataGridView> ProcessCreateReport(int month, int year,
            DataGridView dgvReport)
        {
            return dgvReport;
        }

        public async virtual Task<DataGridView> LoadReport(int month, int year, DataGridView dgvReport)
        {
            SqlConnection connection = await DataHandler.OpenConnection();
            SqlDataReader reader = ReadData(month, year, connection);

            while (reader.HasRows)
            {
                if (!reader.Read())
                {
                    break;
                }

                ProcessLoadReport(reader, ref dgvReport);
            }

            DataHandler.CloseConnection(ref connection);

            return dgvReport;
        }

        protected abstract void ProcessLoadReport(SqlDataReader reader, ref DataGridView dgvReport);

        protected abstract SqlDataReader ReadData(int month, int year, SqlConnection connection);

        protected async virtual Task<bool> IsExistReport(int month, int year)
        {
            return false;
        }

        protected static string GetDateConditionForSQL(int month, int year, string column)
        {
            return "WHERE " + column + " >= '" + GetFirstDayOfMonth(month, year) + "' AND " + column +
                " <= '" + GetLastDayOfMonth(month, year) + "'";
        }

        private static string GetLastDayOfMonth(int month, int year)
        {
            return new DateTime(year, month, DateTime.DaysInMonth(year, month)).ToShortDateString();
        }

        private static string GetFirstDayOfMonth(int month, int year)
        {
            return new DateTime(year, month, 1).ToShortDateString();
        }

        protected static async Task<int> CountRecord(string tables, string condition)
        {
            return await DataHandler.Calculate("COUNT", "*", tables, condition);
        }

        protected static bool IsError(int month, int year)
        {
            DateTime now = DateTime.Now;
            int currentYear = now.Year;

            if (year > currentYear || (year == currentYear && month >= now.Month))
            {
                NotificationHandler.NotifyError("Không được nhập tháng năm lớn hơn hoặc bằng tháng " +
                    "năm hiện tại");

                return true;
            }

            if (!IsMonth(month))
            {
                return true;
            }

            if (year == -1)
            {
                NotificationHandler.NotifyError("Năm không được phép để trống");

                return true;
            }

            return false;
        }

        public static bool IsMonth(int month)
        {
            try
            {
                if (month < 1 || month > 12)
                {
                    NotificationHandler.NotifyError("Tháng chỉ nhận giá trị từ 1 đến 12");

                    return false; ;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}