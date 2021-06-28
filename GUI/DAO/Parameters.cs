using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class Parameters
    {
        private static Parameters instance;
        public static Parameters Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Parameters();
                }
                return instance;
            }
            private set
            {
                Parameters.instance = value;
            }
        }
        private Parameters() { }
        public DTO.Parameters GetMaxNumberPatient()
        {
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                DTO.Parameters thamso = new DTO.Parameters("", 0);
                string table = "THAMSO";
                string condition = "Where TENTHAMSO = N'Số bệnh nhân tối đa'";
                SqlDataReader data = Data.ReadData(table, connection, condition, "*");

                while (data.Read())
                {
                    thamso = new DTO.Parameters(data);

                }
                connection.Close();
                return thamso;

            }
            catch
            {
                return null;
            }
        }
        public DTO.Parameters GetMedicalExpenses()
        {
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                DTO.Parameters thamso = new DTO.Parameters("", 0);
                string table = "THAMSO";
                string condition = "Where TENTHAMSO = N'Tiền khám'";
                SqlDataReader data = Data.ReadData(table, connection, condition, "*");

                while (data.Read())
                {
                    thamso = new DTO.Parameters(data);

                }
                connection.Close();
                return thamso;

            }
            catch
            {
                return null;
            }
        }
        public int UpdateMaxNumberPatient(string maxnumberpatient)
        {
            try
            {
                string query = "UPDATE THAMSO SET GIATRI = @maxnumberpatient WHERE TENTHAMSO=N'Số bệnh nhân tối đa'";
                int check=Data.ExecutenonQuery(query,new object[] { maxnumberpatient});
                return check;
            }
            catch
            {
                return -1;
            }
        }
        public int UpdateMedicalExpenses (string medicalexpenses)
        {
            try
            {
                string query = "UPDATE THAMSO SET GIATRI = @medicalexpenses WHERE TENTHAMSO=N'Tiền khám'";
                int check = Data.ExecutenonQuery(query, new object[] { medicalexpenses });
                return check;
            }
            catch
            {
                return -1;
            }
        }
    }
}
