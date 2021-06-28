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
    public partial class FormReportPatientExam : Form
    {
        string idPatientExam;
        public FormReportPatientExam(string idPatientExam)
        {
            InitializeComponent();
            this.Load += FormLoad;
            this.idPatientExam = idPatientExam;
        }

        private async void FormLoad(object sender, EventArgs e)
        {
            CRPatientExam rpt = new CRPatientExam();
            SqlConnection con = await Data.OpenConnection();
            string query_1 = "", query_2 = "";
            query_1 = $"SELECT maphieukb, BENHNHAN.HOTEN, CONVERT(NVARCHAR(10), DAY(ngaykhambenh)) + '/' + CONVERT(NVARCHAR(10), MONTH(ngaykhambenh)) + '/' + CONVERT(NVARCHAR(10), YEAR(ngaykhambenh)) as ngaykhambenh" +
            $", trieuchung, tenbenh FROM PHIEUKB, CTKB, BENHNHAN, benh where ctkb.mactkb = '{idPatientExam}' and PHIEUKB.MABENH = BENH.MABENH and CTKB.MACTKB = PHIEUKB.MACTKB and CTKB.MABENHNHAN = BENHNHAN.MABENHNHAN";
            query_2 = $"select tenthuoc, tendonvitinh, soluong, tencachdung " +
            $"from phieukb as pkb, ctkb, ctphieukb as ctpkb, thuoc as t, donvitinh as dvt, cachdung as cd " +
            $"where ctkb.mactkb = '{idPatientExam}' and pkb.MACTKB = ctkb.MACTKB and pkb.MAPHIEUKB = ctpkb.MAPHIEUKB and ctpkb.MATHUOC = t.MATHUOC and ctpkb.MACACHDUNG = cd.MACACHDUNG and t.MADONVITINH = dvt.MADONVITINH";

            SqlDataAdapter dap = new SqlDataAdapter(query_1, con);
            var dt = new DataTable();
            dt.TableName = "DTBTTBENHNHAN";
            DataSet ds = new DataSet();
            dap.Fill(dt);
            ds.Tables.Add(dt);
            dap = new SqlDataAdapter(query_2, con);
            dt = new DataTable();
            dt.TableName = "DTBTHUOCCB";
            dap.Fill(dt);
            ds.Tables.Add(dt);
            dt = new DataTable();
            dt.TableName = "DTBENHNHAN";
            ds.Tables.Add(dt);
            rpt.SetDataSource(ds);
            crvPatientExam.ReportSource = rpt;
        }
    }
}
