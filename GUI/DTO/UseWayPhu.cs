using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UseWayPhu: IEquatable<UseWayPhu>
    {
        string id;
        string useWayName;

        public UseWayPhu(string id, string useWayName)
        {
            this.Id = id;
            this.UseWayName = useWayName;
        }

        public string Id { get => id; set => id = value; }
        public string UseWayName { get => useWayName; set => useWayName = value; }

        public bool Equals(UseWayPhu other)
        {
            return this.Id.Equals(other.Id) && this.UseWayName.Equals(other.UseWayName);
        }
    }
}
