using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PatientExam
    {
        string id;
        string id_detail;
        string signalSick;
        string idTypeSick;

        public PatientExam(string id, string id_detail, string signalSick, string idTypeSick)
        {
            this.Id = id;
            this.Id_detail = id_detail;
            this.SignalSick = signalSick;
            this.IdTypeSick = idTypeSick;
        }

        public string Id { get => id; set => id = value; }
        public string Id_detail { get => id_detail; set => id_detail = value; }
        public string SignalSick { get => signalSick; set => signalSick = value; }
        public string IdTypeSick { get => idTypeSick; set => idTypeSick = value; }
    }
}
