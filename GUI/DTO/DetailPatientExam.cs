using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DetailPatientExam
    {
        string id;
        string idPatientExam;
        string idMedical;
        int medicalNum;
        string idUseWay;
        int money;

        public DetailPatientExam(string id, string idPatientExam, string idMedical, int medicalNum, string idUseWay, int money)
        {
            this.Id = id;
            this.IdPatientExam = idPatientExam;
            this.IdMedical = idMedical;
            this.MedicalNum = medicalNum;
            this.IdUseWay = idUseWay;
            this.Money = money;
        }

        public string Id { get => id; set => id = value; }
        public string IdPatientExam { get => idPatientExam; set => idPatientExam = value; }
        public string IdMedical { get => idMedical; set => idMedical = value; }
        public int MedicalNum { get => medicalNum; set => medicalNum = value; }
        public string IdUseWay { get => idUseWay; set => idUseWay = value; }
        public int Money { get => money; set => money = value; }
    }
}
