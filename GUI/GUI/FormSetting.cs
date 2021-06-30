using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUI
{
    public partial class FormSetting : Form
    {
        FormMain parent;
        public FormSetting(FormMain parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.FormClosed += onFormClosed;
            this.bSaveParameters.Click += BSaveParameters_Click;
            this.Load += FormSetting_Load;
            this.bCancel.Click += BCancel_Click;
            this.bDeleteUseWay.Click += BDeleteUseWay_Click;
            this.bDeleteUnit.Click += BDeleteUnit_Click;
            this.bRefeshAddUnit.Click += (s, e) =>
            {
                FormAddMedicalUnit formAddMedicalUnit = new FormAddMedicalUnit();
                formAddMedicalUnit.InsertUnit += FormAddMedicalUnit_InsertUnit;
                BUS.Event.ShowFormDialog(formAddMedicalUnit);
            };
            this.bRefeshAddUseWay.Click += (s, e) =>
            {
                FormAddUseWay formAddUseWay = new FormAddUseWay();
                formAddUseWay.InsertUseway += FormAddUseWay_InsertUseway; ;
                BUS.Event.ShowFormDialog(formAddUseWay);
            };
        }

        private void BDeleteUnit_Click(object sender, EventArgs e)
        {
            List<DTO.MedicalUnit> list = new List<MedicalUnit>();
            foreach (DataGridViewRow row in dgvUnitList.SelectedRows)
            {
                DTO.MedicalUnit unit = new DTO.MedicalUnit(row.Cells["MADONVITINH"].Value.ToString(), row.Cells["DONVITINH"].Value.ToString());
                list.Add(unit);
            }
            if (list.Count > 0)
            {
                DeleteMedicalUnitList(list);

                LoadMedicalUnitList(ref dgvUnitList);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đơn vị tính muốn xóa!");
            }
        }

        private void FormAddMedicalUnit_InsertUnit(object sender, Unitevent e)
        {
            dgvUnitList.Refresh();
            if (dgvUnitList.Rows.Count > 1)
            {
                dgvUnitList.SelectedCells[0].OwningRow.Selected = false;
            }

            string stt = dgvUnitList.Rows.Count.ToString();
            int i = dgvUnitList.Rows.Count - 1;
            dgvUnitList.Rows.Add(new object[] { stt, e.Unit.Medicalunitid, e.Unit.Medicalunitname });

            dgvUnitList.Rows[i].Selected = true;
        }

        private void BDeleteUseWay_Click(object sender, EventArgs e)
        {
            List<DTO.UseWay> list = new List<UseWay>();
            foreach(DataGridViewRow row in dgvUseWayList.SelectedRows)
            {
                DTO.UseWay useway = new DTO.UseWay(row.Cells["MACACHDUNG"].Value.ToString(), row.Cells["CACHDUNG"].Value.ToString());
                list.Add(useway);
            }
            if (list.Count > 0)
            {
                DeleteUseWayList(list);

                LoadUseWayList(ref dgvUseWayList);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn cách dùng muốn xóa!");
            }    
        }

        private void FormAddUseWay_InsertUseway(object sender, Usewayevent e)
        {
            dgvUseWayList.Refresh();
            if (dgvUseWayList.Rows.Count > 1)
            {
                dgvUseWayList.SelectedCells[0].OwningRow.Selected = false;
            }

            string stt = dgvUseWayList.Rows.Count.ToString();
            int i = dgvUseWayList.Rows.Count - 1;
            dgvUseWayList.Rows.Add(new object[] { stt, e.Useway.Usewayid, e.Useway.Usewayname});

            dgvUseWayList.Rows[i].Selected = true;
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            BUS.Event.ShowFormEffect(parent, 1);
            this.Close();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            LoadParameters();
            //Design_Datagridview(ref dgvUnitList);
            //Design_Datagridview(ref dgvUseWayList);
            LoadUseWayList(ref dgvUseWayList);
            LoadMedicalUnitList(ref dgvUnitList);
        }

        private void BSaveParameters_Click(object sender, EventArgs e)
        {
            UpdateParameters();
            
        }

        private void onFormClosed(object s, FormClosedEventArgs e)
        {
            BUS.Event.ShowFormEffect(parent, 1);
        }

        void Design_Datagridview(ref DataGridView dtgv)
        {
            dtgv.DefaultCellStyle.Font = new Font("Tahoma", 13);
            dtgv.DefaultCellStyle.ForeColor=Color.Black;
            dtgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void LoadParameters()
        {
            tbMaxNumberPatient.Text = DAO.Parameters.Instance.GetMaxNumberPatient().Values.ToString();
            tbMedicalExpenses.Text = DAO.Parameters.Instance.GetMedicalExpenses().Values.ToString();
        }

        bool CheckIsNumber(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < '0' || number[i] > '9')
                return false;
            }
            return true;
        }
        
        int UpdateMaxNumberPatient(string maxnumberpatient)
        {
            if (CheckIsNumber(maxnumberpatient)==false)
            {
                MessageBox.Show("Số bệnh nhân tối đa phải là kiểu số!");
                return -2;
            }
            else
            {
                int check = DAO.Parameters.Instance.UpdateMaxNumberPatient(maxnumberpatient);
                return check;
            }
        }

        int UpdateMedicalExpenses(string medicalexpenses)
        {
            if (CheckIsNumber(medicalexpenses) == false)
            {
                MessageBox.Show("Tiền khám phải là kiểu số!");
                return -2;
            }
            else
            {
                int check = DAO.Parameters.Instance.UpdateMedicalExpenses(medicalexpenses);
                return check;
            }
        }

        void UpdateParameters()
        {
            if (tbMaxNumberPatient.Text == "" && tbMedicalExpenses.Text == "")
            {
                MessageBox.Show("Không có dữ liệu để cập nhật!");
                //return;
            }
            else
            {
                int checkMaxNumberPatient=0;
                int checkMedicalExpenses=0;
                if (tbMaxNumberPatient.Text != "")
                {
                    checkMaxNumberPatient = UpdateMaxNumberPatient(tbMaxNumberPatient.Text);
                }
                if (tbMedicalExpenses.Text != "")
                {
                    checkMedicalExpenses = UpdateMedicalExpenses(tbMedicalExpenses.Text);
                }
                if(checkMaxNumberPatient == 1 || checkMedicalExpenses == 1)
                {
                    MessageBox.Show("Đã cập nhật thành công!");
                }    
                else
                {
                    MessageBox.Show("Không thể cập nhật!");
                }                    
            }
            LoadParameters();
        }
        
        void LoadUseWayList(ref DataGridView dtgv)
        {
            dtgv.Rows.Clear();
            List<DTO.UseWay> list = DAO.UseWay.Instance.GetUseWay();
            int i = 0;
            foreach(DTO.UseWay iteam in list)
            {
                string stt = (i + 1).ToString();
                dtgv.Rows.Add(stt, iteam.Usewayid, iteam.Usewayname);
                i++;
            }
        }

        void LoadMedicalUnitList(ref DataGridView dtgv)
        {
            dtgv.Rows.Clear();
            List<DTO.MedicalUnit> list = DAO.MedicalUnit.Instance.GetMedicalUnit();
            int i = 0;
            foreach (DTO.MedicalUnit iteam in list)
            {
                string stt = (i + 1).ToString();
                dtgv.Rows.Add(stt, iteam.Medicalunitid, iteam.Medicalunitname);
                i++;
            }
        }

        void DeleteUseWayList(List<DTO.UseWay> list)
        {
            int checkdelete = 0;
            List<string> listcannotbedelete = new List<string>();
            if (MessageBox.Show("Bạn có chắc muốn xóa toàn bộ thông tin không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                foreach(DTO.UseWay iteam in list)
                {
                    string id = iteam.Usewayid;
                    int check=DAO.UseWay.Instance.SearchUseWayIntoMedicalExaminationCarDetails(id);
                    if (check == 0)
                    {
                        int i= DAO.UseWay.Instance.DeleteUseWaybyId(id);
                        checkdelete =checkdelete + i;
                    }
                    else if (check == -1)
                    {
                        MessageBox.Show("Lỗi kết nối!");
                        return;
                    }
                    else
                    {
                        listcannotbedelete.Add(id);
                    } 
                    
                }
                if(checkdelete==list.Count)
                {
                    MessageBox.Show("Đã xóa thành công!");
                }
                else
                {
                    string mess="";
                    foreach(string id in listcannotbedelete)
                    {
                        mess = mess + ' ' + id;
                    }
                    MessageBox.Show("Không thể xóa những cách dùng có mã sau do đã được sử dụng:" + mess);
                }    
               
            }
           
        }
        void DeleteMedicalUnitList(List<DTO.MedicalUnit> list)
        {
            int checkdelete = 0;
            List<string> listcannotbedelete = new List<string>();
            if (MessageBox.Show("Bạn có chắc muốn xóa toàn bộ thông tin không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                foreach (DTO.MedicalUnit iteam in list)
                {
                    string id = iteam.Medicalunitid;
                    int check = DAO.MedicalUnit.Instance.SearchUnitIntoMedicine(id);
                    if (check == 0)
                    {
                        int i = DAO.MedicalUnit.Instance.DeleteMedicalUnitbyId(id);
                        checkdelete = checkdelete + i;
                    }
                    else if (check == -1)
                    {
                        MessageBox.Show("Lỗi kết nối!");
                        return;
                    }
                    else
                    {
                        listcannotbedelete.Add(id);
                    }

                }
                if (checkdelete == list.Count)
                {
                    MessageBox.Show("Đã xóa thành công!");
                }
                else
                {
                    string mess = "";
                    foreach (string id in listcannotbedelete)
                    {
                        mess = mess + ' ' + id;
                    }
                    MessageBox.Show("Không thể xóa những đơn vị tính có mã sau do đã được sử dụng:" + mess);
                }

            }

        }
    }
}
