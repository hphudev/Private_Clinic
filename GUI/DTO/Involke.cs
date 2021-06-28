using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Involke
    {
        string id;
        string idDetailMedical;
        int examMoney;
        int sumMedicalMoney;
        int totalMoney;

        public Involke(string id, string idDetailMedical, int examMoney, int sumMedicalMoney, int totalMoney)
        {
            this.Id = id;
            this.IdDetailMedical = idDetailMedical;
            this.ExamMoney = examMoney;
            this.SumMedicalMoney = sumMedicalMoney;
            this.TotalMoney = totalMoney;
        }

        public string Id { get => id; set => id = value; }
        public string IdDetailMedical { get => idDetailMedical; set => idDetailMedical = value; }
        public int ExamMoney { get => examMoney; set => examMoney = value; }
        public int SumMedicalMoney { get => sumMedicalMoney; set => sumMedicalMoney = value; }
        public int TotalMoney { get => totalMoney; set => totalMoney = value; }
    }
}
