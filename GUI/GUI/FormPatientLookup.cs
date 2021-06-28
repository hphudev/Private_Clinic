using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPatientLookup : Form
    {
        FormMain parent;
        public FormPatientLookup(FormMain parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.FormClosed += onFormClosed;
            this.Load += FormPatientLookup_Load;
            this.bCancel.Click += BCancel_Click; 
            this.chbSickDay.CheckedChanged += ChbSickDay_CheckedChanged; 
            this.dtpSickDay.onValueChanged += DtpSickDay_onValueChanged; 
            this.bFind.Click += BFind_Click; 
            this.bRefresh.Click += BRefresh_Click; 
            this.dgvPatientList.CellClick += DgvPatientList_CellClick; 
            this.dgvExamList.CellClick += DgvExamList_CellClick;
            this.cbFindIdPatient.TextChanged += CbFindIdPatient_TextChanged;
            this.cbFindNamePatient.TextChanged += CbFindNamePatient_TextChanged;
            this.bPrint.Click += (s, e) =>
            {
                FormReportPatientLookup form = new FormReportPatientLookup(dtpSickDay.Value, chbSickDay.Checked);
                BUS.Event.ShowFormDialog(form);
            };
        }

        private void CbFindNamePatient_TextChanged(object sender, EventArgs e)
        {
            if(cbFindNamePatient.Text != "")
            cbFindIdPatient.Text = "";
        }

        private void CbFindIdPatient_TextChanged(object sender, EventArgs e)
        {
            if(cbFindIdPatient.Text != "")
            cbFindNamePatient.Text = "";
        }

        private void DgvExamList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvExamList.Rows.Count>=1 && dgvExamList.SelectedCells[0].OwningRow.Cells["MaKham"].Value !=null)
            {
                dgvExamList.SelectedCells[0].OwningRow.Selected = true;
                string id = dgvExamList.SelectedCells[0].OwningRow.Cells["MaKham"].Value.ToString();
                LoadListMedicine(ref dgvMedicalList, id);
            }
            else
            {
                LoadListMedicine(ref dgvMedicalList, "");
            }
        }

        private void DgvPatientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string name = dataGridView1.SelectedCells[0].OwningRow.Cells["HoTen"].Value.ToString();
            //string sex = dataGridView1.SelectedCells[0].OwningRow.Cells["GioiTinh"].Value.ToString();
            //DateTime birthday = (DateTime)dataGridView1.SelectedCells[0].OwningRow.Cells["NamSinh"].Value;
            //string address = dataGridView1.SelectedCells[0].OwningRow.Cells["DiaChi"].Value.ToString();
            //string id = DAO.Patient.Instance.get_IDoldPatient(name, sex, birthday, address);

            LoadExamlistAndMedicineList();

        }

        private void BRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BFind_Click(object sender, EventArgs e)
        {
            if (chbSickDay.Checked == false)
            {
                if (cbFindIdPatient.Text == "")
                {
                    LoadDataGridviewbyName(ref dgvPatientList, cbFindNamePatient.Text);
                }
                else
                {
                    LoadDataGridviewbyId(ref dgvPatientList, cbFindIdPatient.Text);
                }
            }
            else
            {
                if (cbFindIdPatient.Text == "")
                {
                    LoadDataGridviewbyNameAndDate(ref dgvPatientList, cbFindNamePatient.Text,dtpSickDay.Value);
                }
                else
                {
                    LoadDataGridviewbyIDAndDate(ref dgvPatientList, cbFindIdPatient.Text, dtpSickDay.Value);
                }
            }
            LoadExamlistAndMedicineList();
        }

        private void DtpSickDay_onValueChanged(object sender, EventArgs e)
        {
            LoadComboboxSearch(ref cbFindIdPatient ,ref cbFindNamePatient, chbSickDay, dtpSickDay.Value);
            if (chbSickDay.Checked == true)
            {
                if (cbFindIdPatient.Text != "")
                {
                    //LoadDataGridviewbyId(ref dgvPatientList, cbFindIdPatient.Text);
                    LoadListbyDateintoDatagridview(ref dgvPatientList, dtpSickDay.Value);
                    LoadExamlistAndMedicineList();
                }
                else
                {
                    LoadListMedicine(ref dgvMedicalList, "");
                    LoadNumberOfMedicalVisits(ref dgvExamList, "");
                    LoadDataGridviewbyName(ref dgvPatientList, "");
                }
            }
            
        }

        private void ChbSickDay_CheckedChanged(object sender, EventArgs e)
        {
            LoadComboboxSearch(ref cbFindIdPatient,ref cbFindNamePatient, chbSickDay, dtpSickDay.Value);
            if (chbSickDay.Checked == true)
            {
                if (cbFindIdPatient.Text != "")
                {
                    //LoadDataGridviewbyId(ref dgvPatientList, cbFindIdPatient.Text);
                    LoadListbyDateintoDatagridview(ref dgvPatientList, dtpSickDay.Value);
                    LoadExamlistAndMedicineList();
                }
                else
                {
                    LoadListMedicine(ref dgvMedicalList, "");
                    LoadNumberOfMedicalVisits(ref dgvExamList, "");
                    LoadDataGridviewbyName(ref dgvPatientList, "");
                }
            }
            else
            {
                LoadDataGridviewbyId(ref dgvPatientList, cbFindIdPatient.Text);
                LoadExamlistAndMedicineList();
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            BUS.Event.ShowFormEffect(parent, 1);
            this.Close();
        }

        private void FormPatientLookup_Load(object sender, EventArgs e)
        {
            dtpSickDay.Value = DateTime.Now;
            Design_Datagridview(ref dgvPatientList);
            Design_Datagridview(ref dgvExamList);
            Design_Datagridview(ref dgvMedicalList);
            LoadComboboxSearch(ref cbFindIdPatient,ref cbFindNamePatient, chbSickDay, dtpSickDay.Value);
            LoadDataGridviewbyId(ref dgvPatientList, cbFindIdPatient.Text);
            LoadExamlistAndMedicineList();
        }

        private void onFormClosed(object s, FormClosedEventArgs e)
        {
            BUS.Event.ShowFormEffect(parent, 1);
        }
        

        void Design_Datagridview(ref DataGridView dtgv)
        {
            dtgv.DefaultCellStyle.Font = new Font("Tahoma", 13);
            dtgv.DefaultCellStyle.ForeColor = Color.Black;
            dtgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        void LoadNamePatientintoCombobox(ref ComboBox cb)
        {
            DataTable data = DAO.Patient.Instance.Get_NamePatient_Distinct();
            data.Rows.Add(new object[] { "Tất cả" });
            cb.DataSource = data;
            cb.DisplayMember = "HOTEN";
            cb.ValueMember = "HOTEN";

        }
        void LoadIdPatientintoCombobox(ref ComboBox cb)
        {
            List<string> list = DAO.Patient.Instance.Get_IdallPatient();
            list.Add("Tất cả");
            cb.DataSource = list;
            
        }
        void LoadComboboxSearch(ref ComboBox cbid,ref ComboBox cbname, CheckBox checkbox, DateTime date)
        {

            if (checkbox.Checked == false)
            {
                LoadNamePatientintoCombobox(ref cbname);
                LoadIdPatientintoCombobox(ref cbid);
            }
            else
            {

                DataTable dataname = DAO.Patient.Instance.Get_Name_Id_Patientbydate_Distinct(date);
                dataname.Rows.Add(new object[] { "Tất cả","" });
                
                cbname.DataSource = dataname;
                cbname.DisplayMember = "HOTEN";
                cbname.SelectedItem = 0;
                if (cbname.Items.Count == 0)
                {
                    cbname.Text = null;
                }
                DataTable dataid = DAO.Patient.Instance.Get_Name_Id_Patientbydate_Distinct(date);
                dataid.Rows.Add(new object[] { "", "Tất cả" });
                cbid.DataSource = dataid;
                cbid.DisplayMember = "MABENHNHAN";
                cbid.SelectedItem = 0;
                if (cbid.Items.Count == 0)
                {
                    cbid.Text = null;
                }
            }
            cbid.Text = "Tất cả";
            if(cbid.Text!=null)
            {
                cbname.Text = null;
            }
           
        }
        void LoadDataGridviewbyName(ref DataGridView dtgv, string name)
        {
            dtgv.Refresh();
            List<DTO.Patient> list = new List<DTO.Patient>();
            if (name != "Tất cả")
            {
                list = DAO.Patient.Instance.SearchPatientbyName(name);
            }
            else
            {
                list = DAO.Patient.Instance.SearchAllPatient();
            }    
            for (int i = 0; i < list.Count; i++)
            {

                list[i].Stt = (i + 1).ToString();
                //dtgv.Rows.Add(new object[] { list[i].Stt, list[i].Name, list[i].Sex, list[i].Birthday, list[i].Address });
            }
            dtgv.DataSource = list;
            dtgv.Columns["Id"].Visible = false;
            for (int i = 0; i < list.Count; i++)
            {
                dtgv.Rows[i].Cells["NamSinh"].Value = list[i].Birthday.ToShortDateString();
            }
        }
        void LoadDataGridviewbyNameAndDate(ref DataGridView dtgv, string name,DateTime date )
        {
            dtgv.Refresh();
            List<DTO.Patient> list = new List<DTO.Patient>();
            if (name != "Tất cả")
            {
                list = DAO.Patient.Instance.SearchPatientByNameAndDate(name,date);
            }
            else
            {
                list = DAO.Patient.Instance.GetPatienbyDate(date);
            }
            for (int i = 0; i < list.Count; i++)
            {

                list[i].Stt = (i + 1).ToString();
                //dtgv.Rows.Add(new object[] { list[i].Stt, list[i].Name, list[i].Sex, list[i].Birthday, list[i].Address });
            }
            dtgv.DataSource = list;
            dtgv.Columns["Id"].Visible = false;
            for (int i = 0; i < list.Count; i++)
            {
                dtgv.Rows[i].Cells["NamSinh"].Value = list[i].Birthday.ToShortDateString();
            }
        }

        void LoadDataGridviewbyId(ref DataGridView dtgv, string id)
        {
            dtgv.Refresh();
            List<DTO.Patient> list = new List<DTO.Patient>();
            if (id != "Tất cả")
            {
                list = DAO.Patient.Instance.SearchPatientbyID(id);
            }
            else
            {
                list = DAO.Patient.Instance.SearchAllPatient();
            }

            for (int i = 0; i < list.Count; i++)
            {
                string ngaysinh = list[i].Birthday.ToShortDateString();
                list[i].Stt = (i + 1).ToString();
                //dtgv.Rows.Add(new object[] { list[i].Stt, list[i].Id, list[i].Name, list[i].Sex, ngaysinh, list[i].Address });
            }
            dtgv.DataSource = list;
            dtgv.Columns["Id"].Visible = false;
            for (int i = 0; i < list.Count; i++)
            {
                dtgv.Rows[i].Cells["NamSinh"].Value = list[i].Birthday.ToShortDateString();
            }
        }
        void LoadDataGridviewbyIDAndDate(ref DataGridView dtgv, string id, DateTime date)
        {
            dtgv.Refresh();
            List<DTO.Patient> list = new List<DTO.Patient>();
            if (id != "Tất cả")
            {
                list = DAO.Patient.Instance.SearchPatientbyID(id);
            }
            else
            {
                list = DAO.Patient.Instance.GetPatienbyDate(date);
            }
            for (int i = 0; i < list.Count; i++)
            {

                list[i].Stt = (i + 1).ToString();
                //dtgv.Rows.Add(new object[] { list[i].Stt, list[i].Name, list[i].Sex, list[i].Birthday, list[i].Address });
            }
            dtgv.DataSource = list;
            dtgv.Columns["Id"].Visible = false;
            for (int i = 0; i < list.Count; i++)
            {
                dtgv.Rows[i].Cells["NamSinh"].Value = list[i].Birthday.ToShortDateString();
            }
        }
        void LoadListbyDateintoDatagridview(ref DataGridView dtgv,DateTime date)
        {

            List<DTO.Patient> list = DAO.Patient.Instance.GetPatienbyDate(date);
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].Stt = (i + 1).ToString();
                }

                dtgv.DataSource = list;
                dtgv.Columns["ID"].Visible = false;
                //dtgv.Columns["Id"].Visible = false;
                for (int i = 0; i < list.Count; i++)
                {
                    dtgv.Rows[i].Cells["NamSinh"].Value = list[i].Birthday.ToShortDateString();
                }
            }


        }
        void Clear()
        {
            //LoadListMedicine(ref dgvMedicalList, "");
            //LoadNumberOfMedicalVisits(ref dgvExamList, "");
            //LoadDataGridviewbyName(ref dgvPatientList, "");
            chbSickDay.Checked = false;
            dtpSickDay.Value = DateTime.Now;
            LoadComboboxSearch(ref cbFindIdPatient,ref cbFindNamePatient, chbSickDay, dtpSickDay.Value);
            LoadDataGridviewbyId(ref dgvPatientList, cbFindIdPatient.Text);
            LoadExamlistAndMedicineList();
        }
        void LoadNumberOfMedicalVisits(ref DataGridView dtgv, string idpatient)
        {
            dtgv.Refresh();
            DataTable data = DAO.MedicalExaminationCard.Instance.GetNumberOfMedicalVisitsbyIdPatient(idpatient);
            DataColumn col = new DataColumn("STT", typeof(int));
            data.Columns.Add(col);
            dtgv.DataSource = data;
            for (int i = 0; i < dtgv.Rows.Count - 1; i++)
            {
                dtgv.Rows[i].Cells["STT"].Value = i + 1;
                string ngaykham = dtgv.Rows[i].Cells["NGAYKHAM"].Value.ToString();
                dtgv.Rows[i].Cells["NGAYKHAM"].Value = (Convert.ToDateTime(ngaykham).ToShortDateString());
            }
        }
        void LoadListMedicine(ref DataGridView dtgv, string idmedicalexaminationcard)
        {
            dtgv.Refresh();
            DataTable data = DAO.MedicalExaminationCardDetails.Instance.GetListMedicine(idmedicalexaminationcard);
            DataColumn col = new DataColumn("STT", typeof(int));
            data.Columns.Add(col);
            dtgv.DataSource = data;
            for (int i = 0; i < dtgv.Rows.Count - 1; i++)
            {
                dtgv.Rows[i].Cells["dataGridViewTextBoxColumn12"].Value = i + 1;
                
            }
            
        }
        void LoadExamlistAndMedicineList()
        {
            if (dgvPatientList.Rows.Count>=1 && dgvPatientList.SelectedCells[0].OwningRow.Cells["Id"].Value!=null)
            {
                dgvPatientList.SelectedCells[0].OwningRow.Selected = true;
                string id = dgvPatientList.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
                LoadNumberOfMedicalVisits(ref dgvExamList, id);
            }
            else
            {
                LoadNumberOfMedicalVisits(ref dgvExamList, "");
            }
            if (dgvExamList.Rows[0].Cells["MaKham"].Value != null)
            {
                dgvExamList.Rows[0].Selected = true;
                string id = dgvExamList.Rows[0].Cells["MaKham"].Value.ToString();
                LoadListMedicine(ref dgvMedicalList, id);
            }
            else
            {
                LoadListMedicine(ref dgvMedicalList, "");
            }
        }
    }
}
