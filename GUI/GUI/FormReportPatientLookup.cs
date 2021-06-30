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
    public partial class FormReportPatientLookup : Form
    {
        DateTime date;
        bool check;
        public FormReportPatientLookup(DateTime date, bool check)
        {
            InitializeComponent();
            this.Load += FormLoad;
            this.date = date;
            this.check = check;
        }

        private async void FormLoad(object sender, EventArgs e)
        {
            
            CRPatientList rpt = new CRPatientList();
            SqlConnection con = await Data.OpenConnection();
            string query = "";
            if (!check)
            {
                query = $"select DISTINCT BENHNHAN.mabenhnhan, hoten, gioitinh, CONVERT(NVARCHAR(10),DAY(ngaysinh)) + '/' + CONVERT(NVARCHAR(10),MONTH(ngaysinh)) + '/' + CONVERT(NVARCHAR(10),YEAR(ngaysinh)) as NGAYSINH, diachi, count( distinct phieukb.maphieukb) as TongSoLanKham, sum(HOADON.tongtien) as TongTien from benhnhan, phieukb, ctkb left join hoadon on (HOADON.MACTKB = ctkb.MACTKB) where BENHNHAN.MABENHNHAN = CTKB.MABENHNHAN and CTKB.MACTKB = PHIEUKB.MACTKB group by benhnhan.mabenhnhan, hoten, gioitinh, ngaysinh, diachi";
            }
            else
            {
                query = $"select DISTINCT BENHNHAN.mabenhnhan, hoten, gioitinh, CONVERT(NVARCHAR(10),DAY(ngaysinh)) + '/' + CONVERT(NVARCHAR(10),MONTH(ngaysinh)) + '/' + CONVERT(NVARCHAR(10),YEAR(ngaysinh)) as NGAYSINH, diachi, count( distinct phieukb.maphieukb) as TongSoLanKham, sum(HOADON.tongtien) as TongTien from benhnhan, phieukb, ctkb left join hoadon on (HOADON.MACTKB = ctkb.MACTKB) where BENHNHAN.MABENHNHAN = CTKB.MABENHNHAN and CTKB.MACTKB = PHIEUKB.MACTKB AND DAY(ctkb.ngaykhambenh) = '{date.Day.ToString()}' and MONTH(ctkb.ngaykhambenh) ='{date.Month.ToString()}' and YEAR(ctkb.ngaykhambenh) = '{date.Year.ToString()}' group by benhnhan.mabenhnhan, hoten, gioitinh, ngaysinh, diachi";
            }
            SqlDataAdapter dap = new SqlDataAdapter(query, con);
            var dt = new DataTable();
            dt.TableName = "DTBENHNHAN";
            DataSet ds = new DataSet();
            dap.Fill(dt);
            ds.Tables.Add(dt);
            rpt.SetDataSource(ds);
            crvPatient.ReportSource = rpt;
            //CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            //reportDocument.Load(crvPatient);
        }
    }
}
