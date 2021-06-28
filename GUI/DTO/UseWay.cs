using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DTO
{
    public class UseWay
    {
        public UseWay(string usewayid, string usewayname)
        {
            this.Usewayid = usewayid;
            this.Usewayname = usewayname;
        }
        public UseWay(SqlDataReader data)
        {
            this.Usewayid = data["MACACHDUNG"].ToString();
            this.Usewayname = data["TENCACHDUNG"].ToString();
        }

        private string usewayid;
        private string usewayname;

        public string Usewayid { get => usewayid; set => usewayid = value; }
        public string Usewayname { get => usewayname; set => usewayname = value; }
    }
}
