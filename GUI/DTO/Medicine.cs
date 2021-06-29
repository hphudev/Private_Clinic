using System.Data.SqlClient;

namespace DTO
{
    public class Medicine : IdentifiableObject
    {
        public int quantityOfInventory { get; }

        public int sellableUnitPrice { get; }

        public int ratioToCalculateSellableUnitPrice { get; }

        public int importedUnitPrice { get; }

        public string unitID { get; }

        public string name { get; }

        public override string GetValueForInsertIntoSQL()
        {
            string[] tmps = new string[2];
            tmps[0] = "'";
            tmps[1] = "', '";

            return tmps[0] + this.ID + "', N'" + this.name + tmps[1] + this.quantityOfInventory +
                tmps[1] + this.importedUnitPrice + tmps[1] + this.sellableUnitPrice + tmps[1] +
                this.unitID + tmps[1] + this.ratioToCalculateSellableUnitPrice + tmps[0];
        }

        public Medicine(SqlDataReader reader, int startIndex = 0) : base(reader.GetString(startIndex++))
        {
            this.name = reader.GetString(startIndex++);
            this.quantityOfInventory = reader.GetInt32(startIndex++);
            this.importedUnitPrice = reader.GetInt32(startIndex++);
            this.sellableUnitPrice = reader.GetInt32(startIndex++);
            this.unitID = reader.GetString(startIndex++);
            this.ratioToCalculateSellableUnitPrice = reader.GetInt32(startIndex++);
        }

        public Medicine(string ID, string name, int importedUnitPrice, string unitID,
            int ratioToCalculateSellableUnitPrice, int quantityOfInventory = 0, int sellableUnitPrice = 0) : base(ID)
        {
            this.name = name;
            this.quantityOfInventory = quantityOfInventory;
            this.importedUnitPrice = importedUnitPrice;
            this.sellableUnitPrice = sellableUnitPrice;
            this.unitID = unitID;
            this.ratioToCalculateSellableUnitPrice = ratioToCalculateSellableUnitPrice;
        }
    }
}