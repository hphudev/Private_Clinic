using System.Data.SqlClient;

namespace DTO
{
    public class Unit : IdentifiableObject
    {
        public string name { get; }

        public override string GetValueForInsertIntoSQL()
        {
            throw new System.NotImplementedException();
        }

        public Unit(SqlDataReader reader, int startIndex = 0) : base(reader.GetString(startIndex++))
        {
            this.name = reader.GetString(startIndex++);
        }

        public Unit(string ID, string name) : base(ID)
        {
            this.name = name;
        }
    }
}