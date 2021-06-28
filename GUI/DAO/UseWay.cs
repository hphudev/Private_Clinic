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
    public class UseWay
    {
        private static UseWay instance;
        public static UseWay Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UseWay();
                }
                return instance;
            }
            private set
            {
                UseWay.instance = value;
            }
        }
        private UseWay() { }

        public List<DTO.UseWay> GetUseWay()
        {
            try
            {
                List<DTO.UseWay> list = new List<DTO.UseWay>();

                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                
                SqlDataReader data = Data.ReadData("CACHDUNG", connection,"ORDER BY MACACHDUNG", "*");

                while (data.Read())
                {
                    DTO.UseWay useway =new DTO.UseWay(data);
                    list.Add(useway);
                }
                connection.Close();
                return list;
            }
            catch
            {
                return null;
            }
        }

        public string GetIdUseWaybyname(string name)
        {
            try
            {
                string id = "";

                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                
                string table = "CACHDUNG";
                string condition = string.Format("WHERE TENCACHDUNG=N'{0}'", name);

                SqlDataReader data = Data.ReadData(table, connection, condition, "MACACHDUNG");
                while (data.Read())
                {
                    id = data["MACACHDUNG"].ToString();
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

                string table = "CACHDUNG";
                string condition = "";

                SqlDataReader data = Data.ReadData(table, connection, condition, "MAX(MACACHDUNG) AS MAX");
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

        public void InsertUseway(DTO.UseWay useway)
        {
            try
            {

                string values = string.Format("'{0}',N'{1}'", useway.Usewayid,useway.Usewayname);
                string table = "CACHDUNG";
                DAO.Data.AddData(table, values);

            }
            catch (Exception)
            {

                MessageBox.Show("Không thể thêm cách dùng!");
            }
        }

        public int get_usewaycount()
        {
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                int count = 0;
                string table = "CACHDUNG";
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

        public int DeleteUseWaybyId(string id)
        {
            try
            {
                string query = "DELETE CACHDUNG WHERE MACACHDUNG = '"+id+"'";
                return DAO.Data.ExecutenonQuery(query);
            }
            catch
            {
                return -1;
            }
        }

        public int SearchUseWayIntoMedicalExaminationCarDetails(string id)
        {
            try
            {
                int count = 0;

                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                string table = "CTPHIEUKB";
                string condition = "WHERE MACACHDUNG = '" + id + "'";
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
