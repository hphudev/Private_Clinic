using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DAO
{
    public static class Data
    {
        #region Operations

        public static async Task<SqlConnection> OpenConnection(ProgressBar progressBar = null)
        {
            try
            {
                if (progressBar != null)
                    progressBar.Invoke((MethodInvoker)delegate {
                    
                        progressBar.Value = 5;
                });
                string connectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new  SqlConnection(connectionString);
                return await Task.Factory.StartNew(()=> {
                    connection.Open();
                    if (progressBar != null)
                        progressBar.Invoke((MethodInvoker)delegate {
                            progressBar.Value += 5;
                    });
                    return connection;
                });
               
            }
            catch (Exception)
            {
                //IO.ExportError("Lỗi không xác định\n(Class Data)");
                return null;
            }
        }

        //public static async SqlConnection OpenConnection()
        //{
        //    try
        //    {
        //        Task <SqlConnection> connection = OpenConnectionAsync();
        //        SqlConnection con =  await connection;
        //        return con;
        //    }
        //    catch (Exception)
        //    {
        //        //IO.ExportError("Lỗi không xác định\n(Class Data)");
        //        return null;
        //    }
        //}

        public static void CloseConnection(ref SqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch (Exception)
            {
                //IO.ExportError("Lỗi không xác định\n(Class Data)");
            }
        }

        public static SqlDataReader ReadData(string table, SqlConnection connection, 
            string condition, string columns)
        {
            try
            {
                string sqlQuery = "SELECT " + columns + " FROM " + table + " " + condition;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                return command.ExecuteReader();
            }
            catch (Exception)
            {
                //IO.ExportError("Lỗi không xác định\n(Class Data)");
                return null;
            }
        }

        public static async void AddData(string table, string value)
        {
            try
            {
                SqlConnection connection = await Data.OpenConnection();
                string sqlQuery = "INSERT INTO " + table + " VALUES (" + value + ")";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                Data.CloseConnection(ref connection);
            }
            catch (Exception)
            {
               //IO.ExportError("Lỗi không xác định\n(Class Data)");
            }
        }

        public static async void DeleteData(string table, string condition)
        {
            try
            {
                SqlConnection connection = await Data.OpenConnection();
                string sqlQuery = "DELETE FROM " + table + " " + condition;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                Data.CloseConnection(ref connection);
            }
            catch (Exception)
            {
                //IO.ExportError("Lỗi không xác định\n(Class Data)");
            }
        }

        public static async void UpdateData(string table, string update, string condition)
        {
            try
            {
                SqlConnection connection = await Data.OpenConnection();
                string sqlQuery = "UPDATE " + table + " SET " + update + " " + condition;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                Data.CloseConnection(ref connection);
            }
            catch (Exception)
            {
                //IO.ExportError("Lỗi không xác định\n(Class Data)");
            }
        }

        public static void ExeQuery(string query, SqlConnection connection)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //IO.ExportError("Lỗi không xác định\n(Class Data)");
            }
        }

        public static async Task<int> Calculate(string type, string column, string tables, string condition)
        {
            try
            {
                SqlConnection connection = await Data.OpenConnection();
                Data.ExeQuery("SET DATEFORMAT DMY", connection);
                string sqlQuery = "SELECT " + type + "(" + column + ") FROM " + tables + " " + 
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

                Data.CloseConnection(ref connection);
                return result;
            }
            catch (Exception)
            {
                //IO.ExportError("Lỗi không xác định\n(Class Data)");
                return -1;
            }
        }
        #endregion
    }
}
