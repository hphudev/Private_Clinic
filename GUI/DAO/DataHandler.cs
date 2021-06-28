using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    //Thái
    public abstract class DataHandler : Handler
    {
        #region Operations

        //Thái
        public static async Task<SqlConnection> OpenConnection(ProgressBar progressBar = null)
        {
            try
            {
                if (progressBar != null)
                {
                    progressBar.Invoke((MethodInvoker)delegate
                    {
                        progressBar.Value = 5;
                    });
                }

                string connectionString =
                    ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);

                return await Task.Factory.StartNew(() =>
                {
                    connection.Open();

                    if (progressBar != null)
                    {
                        progressBar.Invoke((MethodInvoker)delegate
                        {
                            progressBar.Value += 5;
                        });
                    }

                    return connection;
                });

            }
            catch (Exception)
            {
                return null;
            }
        }

        //Thái
        public static void CloseConnection(ref SqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch (Exception)
            {

            }
        }

        //Thái
        public static SqlDataReader ReadData(string tables, SqlConnection connection, string condition,
            string columns)
        {
            try
            {
                string sqlQuery = "SELECT " + columns + " FROM " + tables + " " + condition;
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                return command.ExecuteReader();
            }
            catch (Exception)
            {
                return null;
            }
        }

        //Thái
        public static async void InsertData(string table, string value)
        {
            try
            {
                SqlConnection connection = await OpenConnection();
                string sqlQuery = "INSERT INTO " + table + " VALUES (" + value + ")";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                CloseConnection(ref connection);
            }
            catch (Exception)
            {

            }
        }

        //Thái
        public static async void DeleteData(string table, string condition)
        {
            try
            {
                SqlConnection connection = await OpenConnection();
                string sqlQuery = "DELETE FROM " + table + " " + condition;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                CloseConnection(ref connection);
            }
            catch (Exception)
            {
                //IO.ExportError("Lỗi không xác định\n(Class )");
            }
        }

        //Thái
        public static async void UpdateData(string table, string update, string condition)
        {
            try
            {
                SqlConnection connection = await OpenConnection();
                string sqlQuery = "UPDATE " + table + " SET " + update + " " + condition;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                CloseConnection(ref connection);
            }
            catch (Exception)
            {

            }
        }

        //Thái
        private static void ExeQuery(string query, SqlConnection connection)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }

        //Thái
        public static async Task<int> Calculate(string type, string columns, string tables,
            string condition)
        {
            try
            {
                SqlConnection connection = await OpenConnection();
                ExeQuery("SET DATEFORMAT MDY", connection);
                string sqlQuery = "SELECT " + type + "(" + columns + ") FROM " + tables + " " +
                    condition;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                int result;

                try
                {
                    result = (int)command.ExecuteScalar();
                }
                catch (InvalidCastException)
                {
                    result = 0;
                }

                CloseConnection(ref connection);

                return result;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        #endregion
    }
}