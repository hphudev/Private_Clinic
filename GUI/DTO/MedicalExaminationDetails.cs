using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MedicalExaminationDetails
    {
        public MedicalExaminationDetails(string id, string idpatient, DateTime ngaykhambenh)
        {
            this.Medicalexaminationdetailsid = id;
            this.Patientid = idpatient;
            this.Medicalexaminationday = ngaykhambenh;
        }

        public MedicalExaminationDetails(SqlDataReader data)
        {
            this.Medicalexaminationdetailsid = data["MACTKB"].ToString();

            this.Patientid = data["MABENHNHAN"].ToString();

            this.Medicalexaminationday = (DateTime)data["NGAYKHAMBENH"];

        }

        private string medicalexaminationdetailsid;
        private string patientid;
        private DateTime medicalexaminationday;

        public string Medicalexaminationdetailsid { get => medicalexaminationdetailsid; set => medicalexaminationdetailsid = value; }
        public string Patientid { get => patientid; set => patientid = value; }
        public DateTime Medicalexaminationday { get => medicalexaminationday; set => medicalexaminationday = value; }
        
    }
}
