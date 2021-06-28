using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAO
{
    public class MedicalExaminationDetails
    {
        private static MedicalExaminationDetails instance;
        public static MedicalExaminationDetails Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MedicalExaminationDetails();
                }
                return instance;
            }
            private set
            {
                MedicalExaminationDetails.instance = value;
            }
        }
        private MedicalExaminationDetails() { }
        public string get_IDMax()
        {
            try
            {
                string idmax = "";

                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                string table = "CTKB";
                string condition = "";

                SqlDataReader data = Data.ReadData(table, connection, condition, "MAX(MACTKB) AS MAX");
                while (data.Read())
                {
                    idmax = data["MAX"].ToString();
                }
                connection.Close();
                if (idmax == null)
                {
                    idmax = "";
                }
                return idmax;
            }
            catch
            {
                return null;
            }
        }
        string CreateID()
        {
            string id = get_IDMax();
            if (id != null)
            {
                id = id.Remove(0, 4);
                string stt = (Convert.ToInt32(id) + 1).ToString();

                id = "CTKB";
                for (int i = 0; i < 9 - 4 - stt.Length; i++)
                {
                    id = id + "0";
                }
                id = id + stt;
            }

            return id;
        }
        public void InsertCTKB(DTO.MedicalExaminationDetails CTKB)
        {
            try
            {
                CTKB.Medicalexaminationdetailsid = get_IDMax();


                if (CTKB.Medicalexaminationdetailsid == "")
                {
                    CTKB.Medicalexaminationdetailsid = "CTKB00001";
                }
                else if (CTKB.Medicalexaminationdetailsid != null)
                {
                    CTKB.Medicalexaminationdetailsid = CreateID();
                }
                else
                {
                    MessageBox.Show("Lỗi kết nối: không tạo được mã CTKB!");
                    return;
                }

                if (CTKB.Medicalexaminationday.ToShortDateString() == DateTime.Today.ToShortDateString())
                {
                    CTKB.Medicalexaminationday = DateTime.Now.AddMinutes(10);
                }
                string ngaykham = CTKB.Medicalexaminationday.Year.ToString() + "/" + CTKB.Medicalexaminationday.Month.ToString() + "/" + CTKB.Medicalexaminationday.Day.ToString() + " " + CTKB.Medicalexaminationday.Hour.ToString() + ":" + CTKB.Medicalexaminationday.Minute.ToString() + ":" + CTKB.Medicalexaminationday.Second.ToString();

                string values = string.Format("'{0}','{1}','{2}'", CTKB.Medicalexaminationdetailsid, CTKB.Patientid, ngaykham);
                string table = "CTKB";

                string query = "INSERT INTO " + table + " VALUES (" + values + ")";
                Data.ExecutenonQuery(query);

            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thêm bệnh nhân!");
            }
        }
    }
}
