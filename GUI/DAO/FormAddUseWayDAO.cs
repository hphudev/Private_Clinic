using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class FormAddUseWayDAO
    {
        public static async Task<List<UseWayPhu>> GetUseWays()
        {
            List<UseWayPhu> useWays = new List<UseWayPhu>();
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(
                "cachdung",
                connection,
                "",
                "*");
            while (reader.HasRows)
            {
                if (!reader.Read())
                    break;
                UseWayPhu useWay = new UseWayPhu(
                    reader.GetString(0),
                    reader.GetString(1));
                useWays.Add(useWay);
            }
            Data.CloseConnection(ref connection);
            return useWays;
        }

        public static void AddUseWay(UseWayPhu useWay)
        {
            try
            {
                Data.AddData(
                "cachdung",
                $"N'{useWay.Id}', N'{useWay.UseWayName}'");
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public static async Task<UseWayPhu> GetUseWay(string useWayName)
        {
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(
                "cachdung",
                connection,
                $"where tencachdung = N'{useWayName}'",
                "*");
            if (reader.HasRows && reader.Read())
            {
                UseWayPhu useWay = new UseWayPhu(
                    reader.GetString(0),
                    reader.GetString(1));
                Data.CloseConnection(ref connection);
                return useWay;
            }
            Data.CloseConnection(ref connection);
            return null;
        }

        public static async Task<int> CountUseWays()
        {
            return await Data.Calculate(
                "count",
                "*",
                "cachdung",
                "");
        }
    }
}
