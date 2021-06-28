using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAO;
namespace GUI
{
    public partial class FormReportInvolke : Form
    {
        string idPatientExam;
        public FormReportInvolke(string idPatientExam)
        {
            InitializeComponent();
            this.idPatientExam = idPatientExam;
            this.Load += FormLoad;
        }

        private async void FormLoad(object sender, EventArgs e)
        {
            CRInvolke rpt = new CRInvolke();
            SqlConnection con = await Data.OpenConnection();
            string query_1 = "", query_2 = "";
            query_1 = $"select HOADON.sohd as mahoadon, PHIEUKB.maphieukb, HOADON.TIENKHAM as tienkham, HOADON.TONGTIENTHUOC as tongtienthuoc, HOADON.TONGTIEN as tongtien" +
                $" from phieukb, ctkb, hoadon " +
                $" where phieukb.MAPHIEUKB = '{idPatientExam}' and PHIEUKB.MACTKB = ctkb.MACTKB and ctkb.MACTKB = HOADON.MACTKB";



            query_2 = $"select tenthuoc, soluong, dongiaban, tienthuoc " +
                $"from phieukb, ctphieukb, thuoc " +
                $"where PHIEUKB.MAPHIEUKB = '{idPatientExam}' and PHIEUKB.MAPHIEUKB = CTPHIEUKB.MAPHIEUKB and THUOC.MATHUOC = CTPHIEUKB.MATHUOC";

            


            SqlDataAdapter dap = new SqlDataAdapter(query_2, con);
            var dt = new DataTable();
            dt.TableName = "DTBCTPKB";
            DataSet ds = new DataSet();
            dap.Fill(dt);
            ds.Tables.Add(dt);
            dap = new SqlDataAdapter(query_1, con);
            dt = new DataTable();
            dt.TableName = "DTBHOADON";
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
            crvInvolke.ReportSource = rpt;
        }
    }
}
