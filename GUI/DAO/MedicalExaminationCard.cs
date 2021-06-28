using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MedicalExaminationCard
    {
        private static MedicalExaminationCard instance;
        public static MedicalExaminationCard Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MedicalExaminationCard();
                }
                return instance;
            }
            private set
            {
                MedicalExaminationCard.instance = value;
            }
        }
        private MedicalExaminationCard() { }

        public DataTable GetNumberOfMedicalVisitsbyIdPatient(string id)
        {
            try
            {
                List<DTO.Patient> list = new List<DTO.Patient>();

                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                string table = "CTKB AS C, BENH AS B ,(PHIEUKB  left join HOADON on PHIEUKB.MACTKB = HOADON.MACTKB )";
                string condition = string.Format(" where PHIEUKB.MACTKB=C.MACTKB AND PHIEUKB.MABENH=B.MABENH AND C.MABENHNHAN='{0}'", id);
                string column = " PHIEUKB.MAPHIEUKB,C.NGAYKHAMBENH,B.TENBENH, TONGTIEN ,PHIEUKB.TRIEUCHUNG";
                DataTable data = new DataTable();
                data.Load(DAO.Data.ReadData(table, connection, condition, column));
                connection.Close();
                return data;
            }
            catch
            {
                return null;
            }
        }

        
    }
}
