using System;
using System.Data.SqlClient;

namespace DTO
{
    public class DetailRevenueReport : DetailReport
    {
        public DateTime createdDate { get; }

        public int numberOfPatients { get; }

        public int revenue { get; }

        public int rationMonthRevenue { get; }

        public override string GetValueForInsertIntoSQL()
        {
            string[] tmps = new string[2];
            tmps[0] = "'";
            tmps[1] = "', '";

            return tmps[0] + this.ID + tmps[1] + this.createdDate.ToShortDateString() + tmps[1] +
                this.numberOfPatients + tmps[1] + this.revenue + tmps[1] + this.rationMonthRevenue +
                tmps[0];
        }

        public DetailRevenueReport(SqlDataReader reader) : base(reader.GetString(0))
        {
            this.createdDate = reader.GetDateTime(1);
            this.numberOfPatients = reader.GetInt32(2);
            this.revenue = reader.GetInt32(3);
            this.rationMonthRevenue = reader.GetInt32(4);
        }

        public DetailRevenueReport(string ID, DateTime createdDate, int numberOfPatients = -1,
            int revenue = -1, int rationMonthRevenue = -1) : base(ID)
        {
            this.createdDate = createdDate;
            this.numberOfPatients = numberOfPatients;
            this.revenue = revenue;
            this.rationMonthRevenue = rationMonthRevenue;
        }
    }
}