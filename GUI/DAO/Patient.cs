using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAO
{
    public class Patient
    {
        private static Patient instance;
        public static Patient Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Patient();
                }
                return instance;
            }
            private set
            {
                Patient.instance = value;
            }
        }
        private Patient() { }
        public List<DTO.Patient> GetPatienbyDate(DateTime ngaykhambenh)
        {
            try
            {
                List<DTO.Patient> list = new List<DTO.Patient>();

                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                string day = ngaykhambenh.Day.ToString();
                string month = ngaykhambenh.Month.ToString();
                string year = ngaykhambenh.Year.ToString();
                string condition = string.Format("Where YEAR(ngaykhambenh) = '{0}' AND MONTH(ngaykhambenh)= '{1}' AND DAY(ngaykhambenh)='{2}' AND BENHNHAN.MABENHNHAN=CTKB.MABENHNHAN ORDER BY MACTKB", year, month, day);
                string column = "BENHNHAN.MABENHNHAN, HOTEN, GIOITINH, NGAYSINH, DIACHI";
                SqlDataReader data = Data.ReadData("BENHNHAN,CTKB", connection, condition, column);

                while (data.Read())
                {
                    DTO.Patient patient = new DTO.Patient(data);
                    list.Add(patient);
                }
                connection.Close();
                return list;
            }
            catch
            {
                return null;
            }
        }

        public void InsertPatient(DTO.Patient patient)
        {
            try
            {
                string ngaysinh = patient.Birthday.ToString("yyyy-MM-dd");
                string values = string.Format("'{0}',N'{1}',N'{2}','{3}',N'{4}'", patient.Id, patient.Name, patient.Sex, ngaysinh, patient.Address);
                string table = "BENHNHAN";
                DAO.Data.AddData(table, values);

            }
            catch (Exception)
            {

                MessageBox.Show("Không thể thêm bệnh nhân!");
            }
        }

        public void UpdatePatient(DTO.Patient patient)
        {
            try
            {
                //string ngaykham = patient.Medical_examination_day.ToString("yyyy-MM-dd hh:mm:ss");
                string ngaysinh = patient.Birthday.ToString("yyyy-MM-dd");
                string update = string.Format("HOTEN=N'{0}',GIOITINH=N'{1}',NGAYSINH='{2}',DIACHI=N'{3}'", patient.Name, patient.Sex, ngaysinh, patient.Address);
                string condition = "Where mabenhnhan = '" + patient.Id + "'";
                string table = "BENHNHAN";

                DAO.Data.UpdateData(table, update, condition);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thêm bệnh nhân!");
            }
        }

        public int get_patientcount()
        {
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                int count = 0;
                string table = "BENHNHAN";
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

        public string get_IDMax()
        {
            try
            {
                string idmax = "";

                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                string table = "BENHNHAN";
                string condition = "";

                SqlDataReader data = Data.ReadData(table, connection, condition, "MAX(MABENHNHAN) AS MAX");
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

        public string get_IDoldPatient(string name, string sex, DateTime birthday, string address)
        {
            try
            {
                string id = "";

                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                string day = birthday.Day.ToString();
                string month = birthday.Month.ToString();
                string year = birthday.Year.ToString();

                string table = "BENHNHAN";
                string condition = string.Format("WHERE HOTEN=N'{0}' AND GIOITINH=N'{1}' AND DIACHI=N'{2}' AND YEAR(NGAYSINH) = '{3}' AND MONTH(NGAYSINH)= '{4}' AND DAY(NGAYSINH)='{5}'", name, sex, address, year, month, day);

                SqlDataReader data = Data.ReadData(table, connection, condition, "MABENHNHAN");
                while (data.Read())
                {
                    id = data["MABENHNHAN"].ToString();
                }
                connection.Close();

                return id;
            }
            catch
            {
                return null;
            }
        }

        public List<string> Get_IdallPatient()
        {
            List<string> listid = new List<string>();

            string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlDataReader data = DAO.Data.ReadData("BENHNHAN", connection, "", "MABENHNHAN");

            while (data.Read())
            {
                listid.Add(data["MABENHNHAN"].ToString());
            }

            connection.Close();
            return listid;
        }

        public List<DTO.Patient> SearchPatientbyID(string id)
        {
            List<DTO.Patient> list = new List<DTO.Patient>();

            string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string table = "BENHNHAN";
            string condition = string.Format("WHERE MABENHNHAN = N'{0}'", id);
            string column = "*";

            SqlDataReader data = DAO.Data.ReadData(table, connection, condition, column);

            while (data.Read())
            {
                DTO.Patient patient = new DTO.Patient(data);
                list.Add(patient);
            }
            connection.Close();

            return list;
        }

        public DataTable Get_NamePatient_Distinct()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string table = "BENHNHAN";
            string condition = "";
            string column = " DISTINCT HOTEN";

            DataTable data = new DataTable();
            data.Load(DAO.Data.ReadData(table, connection, condition, column));

            connection.Close();

            return data;
        }

        public DataTable Get_Name_Id_Patientbydate_Distinct(DateTime ngaykhambenh)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string table = "BENHNHAN,CTKB";
            string day = ngaykhambenh.Day.ToString();
            string month = ngaykhambenh.Month.ToString();
            string year = ngaykhambenh.Year.ToString();
            string condition = string.Format("Where YEAR(ngaykhambenh) = '{0}' AND MONTH(ngaykhambenh)= '{1}' AND DAY(ngaykhambenh)='{2}' AND BENHNHAN.MABENHNHAN=CTKB.MABENHNHAN", year, month, day);
            string column = " DISTINCT HOTEN, BENHNHAN.MABENHNHAN";

            DataTable data = new DataTable();
            data.Load(DAO.Data.ReadData(table, connection, condition, column));

            connection.Close();

            return data;
        }

        public List<DTO.Patient> SearchPatientbyName(string name)
        {
            List<DTO.Patient> list = new List<DTO.Patient>();

            string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string table = "BENHNHAN";
            string condition = string.Format("WHERE HOTEN = N'{0}'", name);
            string column = "*";

            SqlDataReader data = DAO.Data.ReadData(table, connection, condition, column);

            while (data.Read())
            {
                DTO.Patient patient = new DTO.Patient(data);
                list.Add(patient);
            }
            connection.Close();

            return list;
        }
        //NGUYEN HOANG NAM
        public List<DTO.Patient> SearchAllPatient()
        {
            List<DTO.Patient> list = new List<DTO.Patient>();

            string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string table = "BENHNHAN";
            string condition = "";
            string column = "*";

            SqlDataReader data = DAO.Data.ReadData(table, connection, condition, column);

            while (data.Read())
            {
                DTO.Patient patient = new DTO.Patient(data);
                list.Add(patient);
            }
            connection.Close();

            return list;
        }
        //NGUYEN HOANG NAM
        public List<DTO.Patient> SearchPatientByNameAndDate(string name, DateTime ngaykhambenh)
        {
            List<DTO.Patient> list = new List<DTO.Patient>();

            string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string day = ngaykhambenh.Day.ToString();
            string month = ngaykhambenh.Month.ToString();
            string year = ngaykhambenh.Year.ToString();
            string condition = string.Format("Where YEAR(ngaykhambenh) = '{0}' AND MONTH(ngaykhambenh)= '{1}' AND DAY(ngaykhambenh)='{2}' AND BENHNHAN.MABENHNHAN=CTKB.MABENHNHAN AND HOTEN = N'{3}' ORDER BY MACTKB", year, month, day, name);
            string table = "BENHNHAN,CTKB";

            string column = "BENHNHAN.MABENHNHAN, HOTEN, GIOITINH, NGAYSINH, DIACHI";

            SqlDataReader data = DAO.Data.ReadData(table, connection, condition, column);

            while (data.Read())
            {
                DTO.Patient patient = new DTO.Patient(data);
                list.Add(patient);
            }
            connection.Close();

            return list;
        }
    }
}
