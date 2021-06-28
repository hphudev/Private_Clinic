using System.Data.SqlClient;

namespace DTO
{
    public class DetailMedicineUseReport : DetailReport
    {
        private int month, year;

        public int numberOfUses { get; }

        public int frequencyUse { get; }

        public string medicineID { get; }

        public override string GetValueForInsertIntoSQL()
        {
            string[] tmps = new string[2];
            tmps[0] = "'";
            tmps[1] = "', '";

            return tmps[0] + this.ID + tmps[1] + this.month + tmps[1] + this.year + tmps[1] +
                this.medicineID + tmps[1] + this.numberOfUses + tmps[1] + this.frequencyUse + tmps[0];
        }

        public DetailMedicineUseReport(SqlDataReader reader) : base(reader.GetString(0))
        {
            this.month = reader.GetInt32(1);
            this.year = reader.GetInt32(2);
            this.medicineID = reader.GetString(3);
            this.numberOfUses = reader.GetInt32(4);
            this.frequencyUse = reader.GetInt32(5);
        }

        public DetailMedicineUseReport(string ID, int month, int year, string medicineID,
            int numberOfUses = -1, int frequencyUse = -1) : base(ID)
        {
            this.month = month;
            this.year = year;
            this.medicineID = medicineID;
            this.numberOfUses = numberOfUses;
            this.frequencyUse = frequencyUse;
        }
    }
}