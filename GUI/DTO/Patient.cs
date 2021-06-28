using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Patient
    {
        public Patient()
        {

        }

        public Patient(string id, string name, string sex, DateTime birthday, string address, string stt = null)
        {
            this.stt = stt;
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.birthday = birthday;
            this.address = address;

        }

        public Patient(SqlDataReader data)
        {
            this.Id = data["MABENHNHAN"].ToString();
            this.Name = data["HOTEN"].ToString();
            this.sex = data["GIOITINH"].ToString();
            this.birthday = (DateTime)data["NGAYSINH"];
            this.address = data["DIACHI"].ToString();

        }

        private string stt;
        private string id;
        private string name;
        private string sex;
        private DateTime birthday;

        private string address;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }

        public string Address { get => address; set => address = value; }
        public string Stt { get => stt; set => stt = value; }
    }
}
