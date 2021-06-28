using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public abstract class IdentifiableObjectPhu
    {
        public string ID { get; }

        public abstract string GetValueForInsertIntoSQL();

        public IdentifiableObjectPhu(string ID)
        {
            this.ID = ID;
        }
    }
}
