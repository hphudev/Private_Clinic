using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UnitPhu : IdentifiableObjectPhu
    {
        public string name { get; }

        public override string GetValueForInsertIntoSQL()
        {
            throw new System.NotImplementedException();
        }

        //public Unit(SqlDataReader reader, int startIndex = 0) : base(reader.GetString(startIndex++))
        //{
        //    this.name = reader.GetString(startIndex++);
        //}

        public UnitPhu(string ID, string name) : base(ID)
        {
            this.name = name;
        }
    }
}
