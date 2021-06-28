using System.Data.SqlClient;
using DAO;
using System.Threading.Tasks;
using System;

namespace BUS
{
    public abstract class IDHandler : Handler
    {
        public static async Task<string> FindNewID(string table, string primaryKeyColumn, string code,
            int quantityOfNumber)
        {
            try
            {
                string lastID = await GetLastID(table, primaryKeyColumn);
                int numberInID = 1;

                if (lastID != null)
                {
                    numberInID = FindNumberInID(lastID, code) + 1;
                }

                SetID(ref lastID, numberInID, code, quantityOfNumber);

                return lastID;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private static int FindNumberInID(string ID, string code)
        {
            try
            {
                char[] charArrayCode = code.ToCharArray();
                string[] fragments = ID.Split(charArrayCode);

                return int.Parse(fragments[fragments.Length - 1]);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private static void SetID(ref string ID, int numberInID, string code, int quantityOfNumber)
        {
            try
            {
                int quantityOfZero = quantityOfNumber, tmp = numberInID;
                ID = code;

                while (tmp > 0)
                {
                    quantityOfZero--;
                    tmp /= 10;
                }    

                for (int i = 0; i < quantityOfZero; i++)
                {
                    ID += "0";
                }

                ID += numberInID.ToString();
            }
            catch (Exception)
            {

            }
        }

        private static async Task<string> GetLastID(string table, string primaryKeyColumn)
        {
            try
            {
                SqlConnection connection = await DataHandler.OpenConnection();
                SqlDataReader reader = DataHandler.ReadData(table, connection, " ORDER BY " + primaryKeyColumn +
                    " DESC", "TOP 1 " + primaryKeyColumn);

                if (reader.Read())
                {
                    string ID = reader.GetString(0);
                    DataHandler.CloseConnection(ref connection);

                    return ID;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}