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
    public class MedicalUnit
    {
        private static MedicalUnit instance;
        public static MedicalUnit Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MedicalUnit();
                }
                return instance;
            }
            private set
            {
                MedicalUnit.instance = value;
            }
        }

        private MedicalUnit() { }

        public List<DTO.MedicalUnit> GetMedicalUnit()
        {
            try
            {
                List<DTO.MedicalUnit> list = new List<DTO.MedicalUnit>();

                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlDataReader data = Data.ReadData("DONVITINH", connection, "ORDER BY MADONVITINH", "*");

                while (data.Read())
                {
                    DTO.MedicalUnit medicalunit = new DTO.MedicalUnit(data);
                    list.Add(medicalunit);
                }
                connection.Close();
                return list;
            }
            catch
            {
                return null;
            }
        }

        public string GetIdMedicalUnitbyname(string name)
        {
            try
            {
                string id = "";

                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();


                string table = "DONVITINH";
                string condition = string.Format("WHERE TENDONVITINH=N'{0}'", name);

                SqlDataReader data = Data.ReadData(table, connection, condition, "MADONVITINH");
                while (data.Read())
                {
                    id = data["MADONVITINH"].ToString();
                }
                connection.Close();

                return id;
            }
            catch
            {
                return null;
            }
        }

        public string get_IDMax()
        {
            try
            {
                string idmax = "";

                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                string table = "DONVITINH";
                string condition = "";

                SqlDataReader data = Data.ReadData(table, connection, condition, "MAX(MADONVITINH) AS MAX");
                while (data.Read())
                {
                    idmax = data["MAX"].ToString();
                }
                connection.Close();

                return idmax;
            }
            catch
            {
                return null;
            }
        }

        public void InsertMedicalUnit(DTO.MedicalUnit unit)
        {
            try
            {

                string values = string.Format("'{0}',N'{1}'", unit.Medicalunitid, unit.Medicalunitname);
                string table = "DONVITINH";
                DAO.Data.AddData(table, values);

            }
            catch (Exception)
            {

                MessageBox.Show("Không thể thêm đơn vị tính!");
            }
        }

        public int get_medicalunitcount()
        {
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                int count = 0;
                string table = "DONVITINH";
                string condition = "";

                SqlDataReader data = Data.ReadData(table, connection, condition, "Count(*) AS COUNT");
                while (data.Read())
                {
                    count = (int)data["Count"];
                }
                connection.Close();

                return count;
            }
            catch
            {
                return -1;
            }
        }

        public int DeleteMedicalUnitbyId(string id)
        {
            try
            {
                string query = "DELETE DONVITINH WHERE MADONVITINH = '" + id + "'";
                return DAO.Data.ExecutenonQuery(query);
            }
            catch
            {
                return -1;
            }
        }

        public int SearchUnitIntoMedicine(string id)
        {
            try
            {
                int count = 0;

                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                string table = "THUOC";
                string condition = "WHERE MADONVITINH = '" + id + "'";
                SqlDataReader data = Data.ReadData(table, connection, condition, "*");

                while (data.Read())
                {
                    count++;
                }

                connection.Close();

                return count;
            }
            catch
            {
                return -1;
            }
        }
    }
}
