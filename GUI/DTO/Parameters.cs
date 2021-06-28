using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Parameters
    {
        public Parameters(string name, int values)
        {
            this.Name = name;
            this.Values = values;
        }

        public Parameters(SqlDataReader data)
        {
            this.name = data["TENTHAMSO"].ToString();
            this.values = (int)data["GIATRI"];
        }

        private string name;
        private int values;

        public string Name { get => name; set => name = value; }
        public int Values { get => values; set => values = value; }
    }
}
