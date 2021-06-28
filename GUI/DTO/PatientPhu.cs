using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PatientPhu
    {
        string id;
        string name;
        string sex;
        DateTime date;
        string address;

        public PatientPhu(string id, string name, string sex, DateTime date, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Sex = sex;
            this.Date = date;
            this.Address = address;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Address { get => address; set => address = value; }
    }
}
