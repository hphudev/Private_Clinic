using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MedicalUnit
    {
        public MedicalUnit(string medicalunitid, string medicalunitname)
        {
            this.Medicalunitid = medicalunitid;
            this.Medicalunitname = medicalunitname;
        }
        public MedicalUnit(SqlDataReader data)
        {
            this.Medicalunitid = data["MADONVITINH"].ToString();
            this.Medicalunitname = data["TENDONVITINH"].ToString();
        }

        private string medicalunitid;
        private string medicalunitname;

        public string Medicalunitid { get => medicalunitid; set => medicalunitid = value; }
        public string Medicalunitname { get => medicalunitname; set => medicalunitname = value; }
       
    }
}
