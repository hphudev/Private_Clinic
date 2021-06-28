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
    public class MedicalExaminationCardDetails
    {
        private static MedicalExaminationCardDetails instance;
        public static MedicalExaminationCardDetails Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MedicalExaminationCardDetails();
                }
                return instance;
            }
            private set
            {
                MedicalExaminationCardDetails.instance = value;
            }
        }
        private MedicalExaminationCardDetails() { }
        public DataTable GetListMedicine(string idmedicalexaminationcard)
        {
            try
            {
                List<DTO.Patient> list = new List<DTO.Patient>();

                string ConnectionString = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                string table = "CTPHIEUKB AS CTP , THUOC AS T, CACHDUNG AS CD, DONVITINH AS DVT";
                string condition = string.Format("WHERE CTP.MAPHIEUKB='{0}' AND CTP.MATHUOC=T.MATHUOC AND CTP.MACACHDUNG=CD.MACACHDUNG AND T.MADONVITINH=DVT.MADONVITINH", idmedicalexaminationcard);
                string column = "TENTHUOC, TENDONVITINH, DONGIABAN, SOLUONG, TIENTHUOC, TENCACHDUNG";

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
