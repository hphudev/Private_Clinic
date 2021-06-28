using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class FormAddTypeSickDAO
    {
        public static async Task<string> GetIdTypeSick(string typeSickName)
        {
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(
                "benh",
                connection,
                $"where tenbenh = N'{typeSickName}'",
                "mabenh");
            if (reader.HasRows && reader.Read())
            {
                return reader.GetString(0);
            }
            else
                return null;
        }

        public static void AddTypeSick(TypeSick typeSick)
        {
             Data.AddData(
                "benh",
                $"N'{typeSick.Id}', N'{typeSick.Name}'");
        }

        public static async Task<int> CountTypeSick()
        {
            int count = await Data.Calculate(
                "count",
                "*",
                "benh",
                "");
            return count;
        }
    }
}
