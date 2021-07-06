using Microsoft.Win32;
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
    public partial class FormMedicalExaminationList : Form
    {
        FormMain parent;
        public FormMedicalExaminationList(FormMain parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.FormClosed += onFormClosed;
            this.bAddPatient.Click += (s, e) =>
            {
                FormAddPatient formAddPatient = new FormAddPatient();
                formAddPatient.InsertPatient += FormAddPatient_InsertPatient; ;
                BUS.Event.ShowFormDialog(formAddPatient);
            };
            this.Load();
            this.dtpSickDay.onValueChanged += DtpSickDay_onValueChanged;
            this.bFind.Click += BFind_Click;
            this.bRegisterPatient.Click += BRegisterPatient_Click; 
            this.bCancel.Click += BCancel_Click;
            this.bRefresh.Click += BRefresh_Click;
            this.cbFindIdPatient.TextChanged += CbFindIdPatient_TextChanged;
            this.cbFindPatient.TextChanged += CbFindPatient_TextChanged;
        }

        private void FormAddPatient_InsertPatient(object sender, Patientevent e)
        {
            dgvPatientList.Refresh();
            dgvPatientList.ClearSelection();
            if (dgvPatientList.Rows.Count > 1)
            {
                //    dgvPatientList.SelectedCells[0].OwningRow.Selected = false;
            }
            LoadNamePatientintoCombobox(ref cbFindPatient);
            LoadIdPatientintoCombobox(ref cbFindIdPatient);
            e.Patient.Stt = (dgvPatientList.Rows.Count + 1).ToString();
            int i = dgvPatientList.Rows.Count;
            dgvPatientList.Rows.Add(new object[] { e.Patient.Stt, e.Patient.Id, e.Patient.Name, e.Patient.Sex, e.Patient.Birthday.ToShortDateString(), e.Patient.Address });
            dgvPatientList.Rows[i].Selected = true;
        }

        private void CbFindPatient_TextChanged(object sender, EventArgs e)
        {
            cbFindIdPatient.Text = null;
        }

        private void CbFindIdPatient_TextChanged(object sender, EventArgs e)
        {
            cbFindPatient.Text = null;
        }
        
        private void BRefresh_Click(object sender, EventArgs e)
        {
            dtpSickDay.Value = DateTime.Now;
            cbFindPatient.Text = null;
            cbFindIdPatient.Text = null;
            LoadDataGridviewbyName(ref dgvPatientList, "");
            LoadListbyDateintoDatagridview(ref dgvMedicalExaminationList);
            LoadDataGridviewAll(ref dgvPatientList);
        }

        private void BFind_Click(object sender, EventArgs e)
        {
            if (cbFindIdPatient.Text == "")
            {
                string name = cbFindPatient.Text;
                LoadDataGridviewbyName(ref dgvPatientList, name);
            }
            else
            {
                string id = cbFindIdPatient.Text;
                LoadDataGridviewbyId(ref dgvPatientList, id);
            }
        }

        private void BRegisterPatient_Click(object sender, EventArgs e)
        {
            InsertCTKB();
        }

        private void DtpSickDay_onValueChanged(object sender, EventArgs e)
        {
            LoadListbyDateintoDatagridview(ref dgvMedicalExaminationList);
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            BUS.Event.ShowFormEffect(parent, 1);
            this.Close();
        }

        private void onFormClosed(object s, FormClosedEventArgs e)
        {
            BUS.Event.ShowFormEffect(parent, 1);
        }

        void LoadDataGridviewAll(ref DataGridView dtgv)
        {
            dtgv.Refresh();
            List<DTO.Patient> list = new List<DTO.Patient>();
            list = DAO.Patient.Instance.SearchAllPatient();
            for (int i = 0; i < list.Count; i++)
            {
                string ngaysinh = list[i].Birthday.ToShortDateString();
                list[i].Stt = (i + 1).ToString();
                dtgv.Rows.Add(new object[] { list[i].Stt, list[i].Id, list[i].Name, list[i].Sex, ngaysinh, list[i].Address });
            }
        }

        void Load()
        {
            dtpSickDay.Value = DateTime.Now;
            Design_Datagridview(ref dgvPatientList);
            Design_Datagridview(ref dgvMedicalExaminationList);
            LoadListbyDateintoDatagridview(ref dgvMedicalExaminationList);
            LoadIdPatientintoCombobox(ref cbFindIdPatient);
            LoadNamePatientintoCombobox(ref cbFindPatient);
            cbFindPatient.Text = null;
            cbFindIdPatient.Text = null;
            LoadDataGridviewAll(ref dgvPatientList);
            //this.dgvPatientList.ClearSelection();
        }

        void Design_Datagridview(ref DataGridView dtgv)
        {
            //dtgv.DefaultCellStyle.Font = new Font("Tahoma", 13);
            //dtgv.DefaultCellStyle.ForeColor = Color.Black;
            //dtgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        void LoadListbyDateintoDatagridview(ref DataGridView dtgv)
        {

            DateTime date = dtpSickDay.Value;
            List<DTO.Patient> list = DAO.Patient.Instance.GetPatienbyDate(date);
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].Stt = (i + 1).ToString();
                }

                dtgv.DataSource = list;
                dtgv.Columns["ID"].Visible = false;
            }


        }
        void LoadNamePatientintoCombobox(ref ComboBox cb)
        {
            DataTable data = DAO.Patient.Instance.Get_NamePatient_Distinct();
            cb.DataSource = data;
            cb.DisplayMember = "HOTEN";
            cb.ValueMember = "HOTEN";

        }
        void LoadIdPatientintoCombobox(ref ComboBox cb)
        {
            List<string> list = DAO.Patient.Instance.Get_IdallPatient();
            cb.DataSource = list;
            //cb.Text = "";
        }
        void LoadDataGridviewbyName(ref DataGridView dtgv, string name)
        {
            dtgv.Rows.Clear();
            List<DTO.Patient> list = DAO.Patient.Instance.SearchPatientbyName(name);

            for (int i = 0; i < list.Count; i++)
            {
                string ngaysinh = list[i].Birthday.ToShortDateString();
                list[i].Stt = (i + 1).ToString();
                dtgv.Rows.Add(new object[] { list[i].Stt,list[i].Id, list[i].Name, list[i].Sex, ngaysinh, list[i].Address });
            }
            //dtgv.DataSource = list;

        }
        void LoadDataGridviewbyId(ref DataGridView dtgv, string id)
        {
            dtgv.Rows.Clear();
            List<DTO.Patient> list= DAO.Patient.Instance.SearchPatientbyID(id);
           
            for (int i = 0; i < list.Count; i++)
            {
                string ngaysinh = list[i].Birthday.ToShortDateString();
                list[i].Stt = (i + 1).ToString();
                dtgv.Rows.Add(new object[] { list[i].Stt, list[i].Id, list[i].Name, list[i].Sex, ngaysinh, list[i].Address });
            }
        }
        bool kiemtrathoigian(DateTime ngaykham)
        {
            DateTime today = DateTime.Now;


            if (ngaykham.Year > today.Year)
            {
                return true;
            }
            else if (ngaykham.Year == today.Year && ngaykham.Month > today.Month)
            {
                return true;
            }
            else if (ngaykham.Year == today.Year && ngaykham.Month == today.Month && ngaykham.Day >= today.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void InsertCTKB()
        {
            try
            {
                //SqlConnection connection = await Data.OpenConnection();



                int soluonghientai = dgvMedicalExaminationList.Rows.Count;

                int soluongbandau = soluonghientai;

                DTO.Parameters thamso = DAO.Parameters.Instance.GetMaxNumberPatient();



                int soluongbenhnhan = DAO.Patient.Instance.get_patientcount();



                //Data.CloseConnection(ref connection);



                List<DTO.Patient> list = new List<DTO.Patient>();
                foreach (DataGridViewRow row in dgvPatientList.SelectedRows)
                {
                    string name = row.Cells["HoTen"].Value.ToString();
                    string sex = row.Cells["GioiTinh"].Value.ToString();
                    DateTime birthday = Convert.ToDateTime(row.Cells["NamSinh"].Value);
                    string address = row.Cells["DiaChi"].Value.ToString();
                    DTO.Patient patient = new DTO.Patient("", name, sex, birthday, address);
                    list.Add(patient);
                }
                if (list.Count == 0)
                {
                    DAO.NotificationHandler.NotifyWarning("Không có bệnh nhân để thêm vào!");
                   
                    return;
                }
                if (thamso.Values > soluonghientai)
                {
                    DateTime ngaykhambenh = dtpSickDay.Value;
                    if (kiemtrathoigian(ngaykhambenh) == false)
                    {
                        DAO.NotificationHandler.NotifyError("Ngày khám bênh không được nhỏ hơn ngày hiện tại!");
                        return;
                    }
                    else
                    {
                        for (int i = list.Count - 1; i >= 0; i--)
                        {
                            string idCTKB = "";
                            string name = list[i].Name;
                            string sex = list[i].Sex;
                            DateTime birthday = list[i].Birthday;
                            string address = list[i].Address;
                            string id = DAO.Patient.Instance.get_IDoldPatient(name, sex, birthday, address);
                            DTO.MedicalExaminationDetails CTKB = new DTO.MedicalExaminationDetails(idCTKB, id, ngaykhambenh);
                            bool checkid = false;
                            foreach (DataGridViewRow row in dgvMedicalExaminationList.Rows)
                            {
                                if (id == row.Cells["ID"].Value.ToString())
                                {
                                    checkid = true;
                                    break;
                                }
                            }
                            if (checkid == false)
                            {
                                DAO.MedicalExaminationDetails.Instance.InsertCTKB(CTKB);



                                soluonghientai++;

                            }
                        }
                        //Data.CloseConnection(ref connection);
                        //DAO.NotificationHandler.NotifyInfo("Đã nhập thành công bệnh nhân!");
                    }
                }
                else
                {
                    DAO.NotificationHandler.NotifyWarning("Số lượng bệnh nhân vượt quá số lượng cho phép!");
                    return;
                }
                LoadListbyDateintoDatagridview(ref dgvMedicalExaminationList);
                if (dgvMedicalExaminationList.Rows.Count - soluonghientai == 0 && soluongbandau < soluonghientai)
                {
                    DAO.NotificationHandler.NotifyInfo("Đã nhập thành công bệnh nhân!");
                }
                else
                {
                    DAO.NotificationHandler.NotifyWarning("Bệnh nhân đã có trong danh sách khám bệnh của ngày được chọn");
                }

            }
            catch
            {
                DAO.NotificationHandler.NotifyError("Lỗi hệ thống!");
            }
        }

        void DeleteRowDatagridview()
        {

        }
        void setDateFormat()
        {
            RegistryKey baseKey;
            baseKey = Registry.CurrentUser;
            baseKey = baseKey.OpenSubKey("Control Panel\\International", true);
            baseKey.SetValue("sShortDate", "dd/MM/yyyy");
        }





    }
}
