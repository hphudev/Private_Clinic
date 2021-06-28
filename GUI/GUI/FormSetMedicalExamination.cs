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
    public partial class FormSetMedicalExamination : Form
    {
        FormMain parent;
        List<PatientPhu> waitingPatients = new List<PatientPhu>();
        List<TypeSick> typeSicks = new List<TypeSick>();
        List<UseWayPhu> useWays = new List<UseWayPhu>();
        List<MedicinePhu> medicines = new List<MedicinePhu>();
        List<MedicinePhu> choiceMedicines = new List<MedicinePhu>();
        List<UseWayPhu> choiceUseWays = new List<UseWayPhu>();
        List<int> choiceNumMedicals = new List<int>();
        MedicinePhu choiceMedicine = null;
        PatientPhu choicePatient = null;
        int posChoiceMedicine = -1;
        int totalMoney = 0;
        TypeSick choiceTypeSick = null;
        UseWayPhu choiceUseWay = null;
        Timer autoUpdate;
        public delegate void TestEventDelegate(object s, EventArgs e);
        //public event TestEventDelegate TestEvent;

        public FormSetMedicalExamination(FormMain parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.FormClosed += onFormClosed;
            this.Load += FormLoad;
            this.dtpSickDay.ValueChanged += SickDayChanged;
            this.cbFindPatient.TextChanged += cbFindPatientChanged;
            this.dgvPatientWaiting.DoubleClick += dgvPatientWaitingDoubleClicked;
            this.bAddTypeSick.Click += bAddTypeSickClicked;
            this.bWaitingPatientRefresh.Click += bWaitingPatientRefreshClicked;
            this.cbTypeSick.Leave += CheckExistTypeSick;
            this.tbMedicalNum.KeyPress += tbMedicalNameKeyPress;
            this.tbMedicalNum.Leave += tbMedicalNumLeft;
            this.cbMedicalName.Leave += cbMedicalNameLeft;
            this.cbMedicalName.TextChanged += tbMedicalNameTextChanged;
            this.tbIdMedical.TextChanged += tbIdMedicalTextChanged;
            this.bAddUseWay.Click += bAdduseWayClicked;
            this.cbUseWay.Leave += cbUseWayLeft;
            this.bRefresh.Click += bRefreshClicked;
            this.bCancel.Click += bCancelClicked;
            this.bAddInto.Click += bAddIntoClicked;
            this.bSave.Click += bSaveClicked;
            this.bCancelPatient.Click += bCancelPatientClicked;
            this.dgvMedicalList.DoubleClick += dgvMedicalListDoubleClicked;
            this.bDeleteMedical.Click += bDeleteMedicalClicked;
            this.FormClosing += ThisFormClosing;
            CreateAutoUpdate();
        }

        private async void tbMedicalNameTextChanged(object sender, EventArgs e)
        {
            AutoIdMedical();
            
        }

        private void ThisFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.tbSignalSick.Text.Equals("") || !this.cbTypeSick.Text.Equals("") || this.dgvMedicalList.Rows.Count > 0)
            {
                var result = MessageBox.Show("Thông tin bạn đang nhập chưa hoàn thiện!\nBạn có muốn đóng chức năng này không?", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                e.Cancel = result == DialogResult.No;
            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    bRefresh.PerformClick();
                    return true;
                case Keys.F2:
                    cbUseWayLeft(this, new EventArgs());
                    tbMedicalNumLeft(this, new EventArgs());
                    Excute();
                   // bAddInto.PerformClick();
                    return true;
                case Keys.Delete:
                    bDeleteMedical.PerformClick();
                    return true;
                case Keys.F5:
                    bWaitingPatientRefresh.PerformClick();
                    return true;
                case (Keys.Control | Keys.S):
                    bSave.PerformClick();
                    return true;
                case (Keys.F9):
                    bCancelPatient.PerformClick();
                    return true;
                case (Keys.Escape):
                    bCancel.PerformClick();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private async void Excute()
        {
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                //bAddInto.PerformClick();
                bAddIntoClicked(this, new EventArgs());
            };
            timer.Start();
        }
        private void bDeleteMedicalClicked(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvMedicalList.CurrentRow != null)
                {
                    posChoiceMedicine = this.dgvMedicalList.CurrentRow.Index;
                    if (posChoiceMedicine >= 0)
                    {
                        string medicalName = choiceMedicines[posChoiceMedicine].name;
                        DialogResult result = MessageBox.Show($"Bạn có muốn xóa thuốc '{medicalName}' ra khỏi đơn thuốc không?", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                            return;
                        totalMoney -= choiceMedicines[posChoiceMedicine].sellableUnitPrice * choiceNumMedicals[posChoiceMedicine];
                        this.tbSumMedicalMoney.Text = BUS.Support.IntToMoney(totalMoney);
                        choiceMedicines.RemoveAt(posChoiceMedicine);
                        choiceUseWays.RemoveAt(posChoiceMedicine);
                        choiceNumMedicals.RemoveAt(posChoiceMedicine);
                        dgvMedicalList.Rows.RemoveAt(posChoiceMedicine);
                        MessageBox.Show($"Đã xóa thuốc '{medicalName}' ra khỏi danh sách!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thuốc trong đơn cần xóa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = bDeleteMedicalClicked + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMedicalListDoubleClicked(object sender, EventArgs e)
        {
           
        }

        public void MedicineInformation_Adapter(int pos)
        {
            this.cbMedicalName.Text = choiceMedicines[pos].name;
            this.tbMedicalNum.Text = choiceNumMedicals[pos].ToString();
            this.cbUseWay.Text = choiceUseWays[pos].UseWayName;
        }

        private void bCancelPatientClicked(object sender, EventArgs e)
        {
            try
            {
                if (choicePatient == null)
                    return;
                BUS.FormSetMedicalExaminationBUS.DeleteDetailExam(choicePatient, this.dtpSickDay.Value);
                MessageBox.Show("Đã hủy khám thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bWaitingPatientRefresh.PerformClick();
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = bCancelPatientClicked + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private async void tbIdMedicalTextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (this.cbMedicalName.Text.Equals(""))
                //    return;
                //choiceMedicine = new Medicine(
                //   "",
                //   cbMedicalName.Text, 0, "", 0, 0);
                //int pos = BUS.Support.IsContain(medicines, choiceMedicine);
                //if (!cbMedicalName.Text.Equals("") && pos == -1)
                //{
                //    MessageBox.Show($"Thuốc \"{this.cbMedicalName.Text}\" không nằm trong danh mục!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    this.cbMedicalName.Text = "";
                //    return;
                //}
                if (tbIdMedical.Text != "")
                {
                    //cbMedicalName.Text = cbMedicalName.Items[pos].ToString();
                    choiceMedicine = await BUS.FormSetMedicalExaminationBUS.GetMedical(cbMedicalName.Text);
                    this.tbUnitName.Text = await BUS.FormSetMedicalExaminationBUS.GetUnitName(choiceMedicine.unitID);
                }
                else
                {
                    this.tbUnitName.Text = "";
                }
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = tbIdMedicalTextChanged + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckNullSave()
        {
            return choicePatient == null || !gbPatientInformation.Enabled || choiceMedicines.Count == 0;
        }

        private async void bSaveClicked(object sender, EventArgs e)
        {
            try
            {
                if (CheckNullSave())
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin có liên quan!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DetailExam detailExam = await BUS.FormSetMedicalExaminationBUS.GetDetailExam(choicePatient.Id, this.dtpSickDay.Value);
                PatientExam patientExam = new PatientExam(
                    "",
                    detailExam.Id,
                    this.tbSignalSick.Text,
                    choiceTypeSick.Id);

                BUS.FormSetMedicalExaminationBUS.SaveMedicalExam(patientExam, detailExam, choiceMedicines,
                 choiceUseWays, choiceNumMedicals);
                
                MessageBox.Show("Đã lưu phiếu nhập thuốc!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("Bạn có muốn in phiếu khám bệnh không?", "CÂU HỎI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FormReportPatientExam form = new FormReportPatientExam(detailExam.Id);
                    BUS.Event.ShowFormDialog(form);
                }
                dtpSickDay.Value = DateTime.Now;
                FormLoad(this, new EventArgs());
                RefreshChoicePatient();
                this.dgvMedicalList.Rows.Clear();
                RefreshgbExam();
                RefreshgbMedical();
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = bSaveClicked + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool CheckEmtyMedicalGroup()
        {
            return this.tbIdMedical.Text == "" || this.tbMedicalNum.Text == "" || this.cbUseWay.Text == ""
                || choiceMedicine == null || choiceUseWay == null;
        }

        private void bAddIntoClicked(object sender, EventArgs e)
        {
            if (CheckEmtyMedicalGroup())
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin loại thuốc!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (choiceMedicines.Contains(choiceMedicine))
            {
                MessageBox.Show("Loại thuốc này đã tồn tại trong đơn!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.choiceMedicines.Add(choiceMedicine);
            this.choiceUseWays.Add(choiceUseWay);
            this.choiceNumMedicals.Add(int.Parse(this.tbMedicalNum.Text));
            this.dgvMedicalList.Rows.Add(
                (this.dgvMedicalList.Rows.Count + 1).ToString(),
                this.choiceMedicine.ID,
                this.choiceMedicine.name,
                this.tbUnitName.Text,
                this.tbMedicalNum.Text,
                this.choiceMedicine.sellableUnitPrice.ToString(),
                (int.Parse(this.tbMedicalNum.Text) * this.choiceMedicine.sellableUnitPrice).ToString(),
                this.choiceUseWay.UseWayName);
            totalMoney += this.choiceMedicine.sellableUnitPrice * int.Parse(this.tbMedicalNum.Text);
            this.tbSumMedicalMoney.Text = BUS.Support.IntToMoney(totalMoney);
            RefreshgbMedical();
            this.cbMedicalName.Focus();
        }

        private void bCancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bRefreshClicked(object sender, EventArgs e)
        {
            if (!tbIdMedical.Text.Equals(""))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thông tin đang nhập?", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    RefreshgbMedical();
                }
            }
        }

        private async void cbUseWayLeft(object sender, EventArgs e)
        {
            try
            {
                if (cbUseWay.Text == "")
                    return;
                UseWayPhu useWay = await BUS.FormSetMedicalExaminationBUS.GetUseWay(this.cbUseWay.Text);
                if (useWay == null)
                {
                    DialogResult result = MessageBox.Show("Cách dùng này không tồn tại!\nBạn có muốn thêm mới không?",
                        "CẢNH BÁO",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        FormAddUseWayPhu formAddUseWay = new FormAddUseWayPhu(this.cbUseWay.Text);
                        BUS.Event.ShowFormDialog(formAddUseWay);
                        cbUseWay_Adapter();
                        choiceUseWay = await BUS.FormSetMedicalExaminationBUS.GetUseWay(this.cbUseWay.Text);
                    }
                    else
                    {
                        this.cbUseWay.Text = "";
                    }
                }
                else
                {
                    this.choiceUseWay = useWay;
                    this.cbUseWay.Text = this.choiceUseWay.UseWayName;
                }

            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = cbUseWayLeft + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbMedicalNumLeft(object sender, EventArgs e)
        {
            try
            {
                if (!tbMedicalNum.Enabled || choiceMedicine == null)
                    return;
                int num = 0, num2 = 0;
                if (!tbMedicalNum.Text.Equals(""))
                    num2 += int.Parse(tbMedicalNum.Text);
                num = this.choiceMedicine.quantityOfInventory;
                if (num < num2 && num > 0)
                {
                    MessageBox.Show($"Số lượng thuốc tối đa chỉ còn \"{num}\"! ", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tbMedicalNum.Text = num.ToString();
                }
                if (num == 0)
                {
                    MessageBox.Show($"Thuốc '{cbMedicalName.Text}' đã hết!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RefreshgbMedical();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = tbMedicalNumLeft + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bAdduseWayClicked(object sender, EventArgs e)
        {
            try
            {
                FormAddUseWayPhu formAddUseWay = new FormAddUseWayPhu("");
                BUS.Event.ShowFormDialog(formAddUseWay);
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = bAdduseWayClicked + {a.Message}", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMedicalNameLeft(object sender, EventArgs e)
        {
            try
            {
                if (choiceMedicine == null)
                    return;
                int pos = BUS.Support.IsContain(medicines, choiceMedicine);
                if (!cbMedicalName.Text.Equals("") && pos == -1)
                {
                    MessageBox.Show($"Thuốc \"{this.cbMedicalName.Text}\" không nằm trong danh mục!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cbMedicalName.Text = "";
                    return;
                }
                //if (pos != -1)
                //{
                //    cbMedicalName.Text = cbMedicalName.Items[pos].ToString();
                //    choiceMedicine = await BUS.FormSetMedicalExaminationBUS.GetMedical(cbMedicalName.Text);
                //    this.tbUnitName.Text = await BUS.FormSetMedicalExaminationBUS.GetUnitName(choiceMedicine.unitID);
                //}
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = cbMedicalNameLeft + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbMedicalNameKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
                if (e.Handled)
                    MessageBox.Show("Số lượng thuốc phải là số!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = tbMedicalNameKeyPress + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private async void CheckExistTypeSick(object sender, EventArgs e)
        {
            try
            {
                if (this.cbTypeSick.Text.Equals(""))
                    return;
                bool check = await BUS.FormSetMedicalExaminationBUS.CheckTypeSickLeaveEvent(this.cbTypeSick.Text);
                if (!check)
                {
                    DialogResult result = MessageBox.Show("Loại bệnh này không tồn tại trong cơ sở dữ liệu\nBạn có muốn thêm mới?",
                        "CẢNH BÁO",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        FormAddTypeSickPhu formAddTypeSick = new FormAddTypeSickPhu(this.cbTypeSick.Text);
                        BUS.Event.ShowFormDialog(formAddTypeSick);
                        cbTypeSick_Adapter();
                    }
                    else
                        this.cbTypeSick.Text = "";
                }
                if (!cbTypeSick.Text.Equals(""))
                {
                    foreach(var typeSick in typeSicks)
                    {
                        if (typeSick.Name.Equals(typeSick.Name))
                            choiceTypeSick = typeSick;
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = CheckExistTypeSick + {a.Message}", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void cbUseWay_Adapter()
        {
            try
            {
                List<UseWayPhu> useWaysTmp = await BUS.FormSetMedicalExaminationBUS.GetUseWays();
                if (useWays.SequenceEqual(useWaysTmp))
                    return;
                this.useWays = useWaysTmp.ToList<UseWayPhu>();
                this.cbUseWay.Items.Clear();
                List<String> useWayName = new List<string>();
                foreach (var useWay in useWays)
                {
                    useWayName.Add(useWay.UseWayName);
                }
                this.cbUseWay.Items.AddRange(useWayName.ToArray());
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = cbUseWay_Adapter + {a.Message}", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public async void cbTypeSick_Adapter()
        {
            try
            {
                typeSicks = await BUS.FormSetMedicalExaminationBUS.cbTypeSickApdapter();
                cbTypeSick.Items.Clear();
                List<string> typeSickNames = new List<string>();
                foreach (var typeSick in typeSicks)
                {
                    typeSickNames.Add(typeSick.Name);
                    
                }
                cbTypeSick.Items.AddRange(typeSickNames.ToArray());
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = cbTypeSick_Adapter + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void cbMedicalName_Adpater()
        {
            try
            {
                List<MedicinePhu> medicalTmp = await BUS.FormSetMedicalExaminationBUS.cbMedicalAdpater();
                if (this.medicines.ToArray().SequenceEqual(medicalTmp.ToArray()))
                    return;
                this.medicines = new List<MedicinePhu>(medicalTmp);
                cbMedicalName.Items.Clear();
                List<String> medicineNames = new List<string>();
                foreach (var medicine in medicines)
                {
                    medicineNames.Add(medicine.name);
                }
                cbMedicalName.Items.AddRange(medicineNames.ToArray());
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = cbMedicalName_Adpater + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void RefreshChoicePatient()
        {
            try
            {
                choicePatient = null;
                this.tbIdPatient.Text = "";
                this.tbPatientName.Text = "";
                this.tbPatientSex.Text = "";
                this.tbPatientAddress.Text = "";
                this.tbPatientDate.Text = "";
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = RefreshChoicePatient + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bWaitingPatientRefreshClicked(object sender, EventArgs e)
        {
            try
            {
                //Ngày khám bệnh
                if (!this.tbSignalSick.Text.Equals("") || !this.cbTypeSick.Text.Equals("") || this.dgvMedicalList.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Thông tin bạn đang nhập chưa hoàn thiện!\nBạn có muốn tải lại không?", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                        return;
                }
                dtpSickDay.Value = DateTime.Now;
                FormLoad(this, new EventArgs());
                RefreshChoicePatient();
                this.dgvMedicalList.Rows.Clear();
                RefreshgbExam();
                RefreshgbMedical();
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = bWaitingPatientRefreshClicked + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshgbMedical()
        {
            this.tbIdMedical.Text = "";
            this.tbMedicalNum.Text = "";
            this.cbMedicalName.Text = "";
            this.tbUnitName.Text = "";
            this.cbUseWay.Text = "";
            this.choiceMedicine = null;
            this.choiceUseWay = null;
        }

        private void RefreshgbExam()
        {
            this.tbSignalSick.Text = "";
            this.cbTypeSick.Text = "";
            choicePatient = null;
            choiceMedicines = new List<MedicinePhu>();
            choiceUseWays = new List<UseWayPhu>();
            choiceNumMedicals = new List<int>();
        }

        private void AutoLock()
        {
            try
            {
                if (choicePatient == null)
                {
                    gbPatientInformation.Enabled = false;
                    gbMedicalExam.Enabled = false;
                }
                else
                {
                    gbPatientInformation.Enabled = true;
                }
                if (this.tbSignalSick.Text.Equals("")
                    || this.cbTypeSick.Text.Equals(""))
                    this.gbMedicalExam.Enabled = false;
                else
                    this.gbMedicalExam.Enabled = true;
                if (this.tbIdMedical.Text.Equals(""))
                {
                    this.tbMedicalNum.Enabled = this.cbUseWay.Enabled = false;
                    if (this.cbMedicalName.Text == "")
                    {
                        this.tbMedicalNum.Text = "";
                        this.cbUseWay.Text = "";
                    }
                }
                else
                    this.tbMedicalNum.Enabled = this.cbUseWay.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống = {AutoLock}", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateAutoUpdate()
        {
            autoUpdate = new Timer();
            autoUpdate.Interval = 100;
            autoUpdate.Tick += async (s, e) =>
            {
                try
                {
                    int count = await BUS.FormSetMedicalExaminationBUS.CountMedicalExam() + 1;
                    this.tbIdMedicalExam.Text = BUS.Support.IdAdapter("PKB", count, 6);
                    this.tbDaySick.Text = DateTime.Now.ToShortDateString();
                    AutoLock();
                    if (this.dtpSickDay.Value.Date < DateTime.Now.Date)
                        this.lWarming.Visible = true;
                    else
                        this.lWarming.Visible = false;
                    cbMedicalName_Adpater();
                    //AutoIdMedical();
                    cbUseWay_Adapter();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi hệ thống = {autoUpdate}", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            };
            autoUpdate.Start();
        }

        private void bAddTypeSickClicked(object sender, EventArgs e)
        {
            try
            {
                FormAddTypeSickPhu formAddTypeSick = new FormAddTypeSickPhu(null);
                BUS.Event.ShowFormDialog(formAddTypeSick);
                cbTypeSick_Adapter();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống = {bAddTypeSickClicked}", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void AutoIdMedical()
        {
            try
            {
                MedicinePhu Medical = await BUS.FormSetMedicalExaminationBUS.GetMedical(this.cbMedicalName.Text);
                if (Medical == null)
                {
                    this.tbIdMedical.Text = "";
                    return;
                }
                this.tbIdMedical.Text = Medical.ID;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống = {AutoIdMedical}", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvPatientWaitingDoubleClicked(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvPatientWaiting.CurrentRow != null)
                {
                    choicePatient = waitingPatients.ElementAt(this.dgvPatientWaiting.CurrentRow.Index);
                    PatientInformation_Adapter(choicePatient);
                }
                   
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống = {dgvPatientWaitingDoubleClicked}", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PatientInformation_Adapter(PatientPhu patient)
        {
            try
            {
                this.tbIdPatient.Text = patient.Id;
                this.tbPatientName.Text = patient.Name;
                this.tbPatientSex.Text = patient.Sex;
                this.tbPatientDate.Text = patient.Date.ToShortDateString().ToString();
                this.tbPatientAddress.Text = patient.Address;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống = {PatientInformation_Adapter}", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Đổ dữ liệu vào cbFindPatient
        private void NamePatientFind_Adapter(List<PatientPhu> patients)
        {
            try
            {
                List<string> patientNames = new List<string>();
                //Lọc trùng tên
                foreach (var patient in patients)
                {
                    patientNames.Remove(patient.Name);
                    patientNames.Add(patient.Name);
                }
                //Đổ dữ liệu
                this.cbFindPatient.Items.Clear();
                this.cbFindPatient.Items.AddRange(patientNames.ToArray());
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống = {NamePatientFind_Adapter}", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FormLoad(object s, EventArgs e)
        {
            try
            {
                totalMoney = 0;
                this.tbSumMedicalMoney.Text = "0";
                //Đổ dữ liệu vào cbTypeSick
                cbTypeSick_Adapter();
                //Đổ dữ liệu vào cbMedicalName
                cbMedicalName_Adpater();
                //Xóa dữ liệu dgvPatientWaiting
                //Lấy danh sách các bệnh nhân chờ khám
                waitingPatients = null;
                waitingPatients = await BUS.FormSetMedicalExaminationBUS.LoadForm(DateTime.Parse(this.dtpSickDay.Value.ToString()));
                //Hiển thị danh sách
                int stt = 0;
                int selectIndex = -1;
                int countAdded = 0;
                this.dgvPatientWaiting.Rows.Clear();

                for (int i = 0; i < waitingPatients.Count; i++)
                {
                    PatientPhu patient = waitingPatients.ElementAt(i);
                    string findingContent = cbFindPatient.Text.ToLower();
                    if (findingContent == ""
                        || (findingContent != "" && patient.Name.ToLower().Contains(findingContent)))
                    {
                        countAdded++;
                        this.dgvPatientWaiting.Rows.Add(
                            ++stt,
                            patient.Id,
                            patient.Name,
                            patient.Sex,
                            patient.Date.ToShortDateString(),
                            patient.Address);
                        if (choicePatient != null && choicePatient.Id == patient.Id)
                            selectIndex = countAdded - 1;
                    }
                    
                }
                int ii = this.dgvPatientWaiting.Rows.Count;
                //Ghi nhớ dòng đã doubleclick
                if (selectIndex != -1)
                    this.dgvPatientWaiting.Rows[selectIndex].Selected = true;
                else
                    this.dgvPatientWaiting.ClearSelection();

                //Đổ dữ liệu vào bộ lọc tìm kiếm
                NamePatientFind_Adapter(waitingPatients);
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = FormLoad + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void cbFindPatientChanged(object s, EventArgs e)
        {
            try
            {
                FormLoad(this, new EventArgs());

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống = {cbFindPatientChanged}", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SickDayChanged(object s, EventArgs e)
        {
            try
            {
                this.dgvPatientWaiting.Rows.Clear();
                FormLoad(this, new EventArgs());
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống = {SickDayChanged}", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void onFormClosed(object s, FormClosedEventArgs e)
        {
            try
            {
                BUS.Event.ShowFormEffect(parent, 1);
                autoUpdate.Stop();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống = {onFormClosed}", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Label10_Click(object sender, EventArgs e)
        {
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
