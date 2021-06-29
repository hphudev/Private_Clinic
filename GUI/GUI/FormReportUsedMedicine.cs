using DAO;
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

namespace GUI
{
    public partial class FormReportUsedMedicine : Form
    {
        string thang, nam;
        public FormReportUsedMedicine(string thang, string nam)
        {
            InitializeComponent();
            this.thang = thang;
            this.nam = nam;
            this.Load += FormLoad;
        }

        private async void FormLoad(object sender, EventArgs e)
        {
            CRMedicineUsed rpt = new CRMedicineUsed();
            SqlConnection con = await Data.OpenConnection();
            string query_1 = "", query_2 = "";
            query_1 = $"select convert(nvarchar(20), thang) + '/' + convert(nvarchar(20), nam) as ngaylap " +
                $" from CTBCSDTHUOC " +
                $" where thang = '{thang}' and nam = '{nam}'";

            query_2 = $"select DISTINCT thuoc.mathuoc, tenthuoc, tendonvitinh, soluongdung, solandung " +
                $" from CTBCSDTHUOC, thuoc, DONVITINH " +
                $" where CTBCSDTHUOC.MATHUOC = THUOC.MATHUOC and THUOC.MADONVITINH = DONVITINH.MADONVITINH and thang = '{thang}' and nam = '{nam}'";
            SqlDataAdapter dap = new SqlDataAdapter(query_1, con);
            var dt = new DataTable();
            dt.TableName = "DTBSUDUNGTHUOCDATE";
            DataSet ds = new DataSet();
            dap.Fill(dt);
            ds.Tables.Add(dt);
            dap = new SqlDataAdapter(query_2, con);
            dt = new DataTable();
            dt.TableName = "DTBSUDUNGTHUOC";
            dap.Fill(dt);
            ds.Tables.Add(dt);
            //dt = new DataTable();
            //dt.TableName = "DTBENHNHAN";
            //ds.Tables.Add(dt);
            //dt = new DataTable();
            //dt.TableName = "DTBTHUOCCB";
            //ds.Tables.Add(dt);
            //dt = new DataTable();
            //dt.TableName = "DTBTTBENHNHAN";
            //ds.Tables.Add(dt);
            rpt.SetDataSource(ds);
            crvReport.ReportSource = rpt;
        }
    }
}
