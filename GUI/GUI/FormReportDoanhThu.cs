using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
namespace GUI
{
    public partial class FormReportDoanhThu : Form
    {
        string thang, nam;
        public FormReportDoanhThu(string thang, string nam)
        {
            InitializeComponent();
            this.thang = thang;
            this.nam = nam;
            this.Load += FormLoad;
        }

        private async void FormLoad(object sender, EventArgs e)
        {
            CRDoanhThu rpt = new CRDoanhThu();
            SqlConnection con = await Data.OpenConnection();
            string query_1 = "", query_2 = "";
            query_1 = $"select convert(nvarchar(20), MONTH(NGAYLAP)) +'/' + convert(nvarchar(20), YEAR(NGAYLAP)) as ngaylap" +
                $" from CTBCDOANHTHU " +
                $" where MONTH(NGAYLAP) = '{thang}' and YEAR(NGAYLAP) = '{nam}'";

            query_2 = $"select convert(nvarchar(20), DAY(ngaylap)) + '/' + convert(nvarchar(20), MONTH(NGAYLAP)) +'/' + convert(nvarchar(20), YEAR(NGAYLAP)) as ngaylap, sobenhnhan, doanhthu, TYLEDOANHTHUTHANG as tyle " +
                $" from CTBCDOANHTHU " +
                $" where MONTH(NGAYLAP) = '{thang}' and YEAR(NGAYLAP) = '{nam}'";
            SqlDataAdapter dap = new SqlDataAdapter(query_1, con);
            var dt = new DataTable();
            dt.TableName = "DTBDOANHTHUDATE";
            DataSet ds = new DataSet();
            dap.Fill(dt);
            ds.Tables.Add(dt);
            dap = new SqlDataAdapter(query_2, con);
            dt = new DataTable();
            dt.TableName = "DTBDOANHTHU";
            dap.Fill(dt);
            ds.Tables.Add(dt);
            dt = new DataTable();
            dt.TableName = "DTBENHNHAN";
            ds.Tables.Add(dt);
            dt = new DataTable();
            dt.TableName = "DTBTHUOCCB";
            ds.Tables.Add(dt);
            dt = new DataTable();
            dt.TableName = "DTBTTBENHNHAN";
            ds.Tables.Add(dt);
            rpt.SetDataSource(ds);
            crvReport.ReportSource = rpt;
        }
    }
}
