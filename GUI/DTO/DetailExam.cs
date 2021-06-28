using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DetailExam
    {
        string id;
        string idPatient;
        DateTime sickDay;

        public DetailExam(string id, string idPatient, DateTime sickDay)
        {
            this.Id = id;
            this.IdPatient = idPatient;
            this.SickDay = sickDay;
        }

        public string Id { get => id; set => id = value; }
        public string IdPatient { get => idPatient; set => idPatient = value; }
        public DateTime SickDay { get => sickDay; set => sickDay = value; }
    }
}
