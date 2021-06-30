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
using BUS;
namespace GUI
{
    public partial class FormSetInvolke : Form
    {
        FormMain parent;
        int choicePosPatientExam;
        string choiceIdPatientExam = null;
        int totalMoney = 0, totalMedicalMoney = 0, totalExamMoney = 0;
        public FormSetInvolke(FormMain parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.FormClosed += onFormClosed;
            this.bRefresh.Click += bRefreshClicked;
            this.Load += FormLoad;
            this.chbDaySick.CheckedChanged += chbDaySickCheckedChanged;
            this.dtpSickDay.ValueChanged += dtpSickDayValueChanged;
            this.cbIdPatientExam.TextChanged += cbIdPatientExamTextChanged;
            this.cbPatientName.TextChanged += cbPatientNameTextChanged;
            this.dgvPatientExamed.DoubleClick += dgvPatientExamedDoubleClicked;
            this.bPay.Click += bBayClicked;
            this.bCancel.Click += bCancelClicked;
            this.bRefreshDate.Click += bRefreshDateClicked;
        }

        private void dtpSickDayValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chbDaySick.Checked)
                {
                    LoadForm(this.dtpSickDay.Value);
                    cbIdPatient_Adapter(this.dtpSickDay.Value);
                    cbPatientName_Adapter(this.dtpSickDay.Value);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = dtpSickDayValueChanged + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        private void chbDaySickCheckedChanged(object sender, EventArgs e)
        {
            LoadForm(this.dtpSickDay.Value);
        }

        private void bRefreshDateClicked(object sender, EventArgs e)
        {
            this.dtpSickDay.Value = DateTime.Now;
        }

        private void bCancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Escape):
                    this.Close();
                    return true;
                case (Keys.Control | Keys.T):
                    bPay.PerformClick();
                    return true;
                case (Keys.F5):
                    bRefresh.PerformClick();
                    return true;
                case (Keys.F6):
                    bRefreshDate.PerformClick();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private async void bBayClicked(object sender, EventArgs e)
        {
            try
            {
                
                if (choiceIdPatientExam != null)
                {
                   
                    List<PatientExam> patientExams = await BUS.FormSetInvolkeBUS.GetPatientExams(null, choiceIdPatientExam, this.dtpSickDay.Value);
                    int count = await BUS.FormSetInvolkeBUS.CountInvolke() + 1;
                    string id = BUS.Support.IdAdapter("HD", count, 5);
                    Involke invoke = new Involke(
                        id,
                        patientExams[0].Id_detail,
                        totalExamMoney,
                        totalMedicalMoney,
                        totalMoney);
                    BUS.FormSetInvolkeBUS.AddInvolke(invoke);
                    if (this.dgvPatientExamed.Rows[choicePosPatientExam].Cells[6].Value.ToString() == "Đã thanh toán")
                    {
                        MessageBox.Show("Hóa đơn này đã thanh toán!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    LoadForm(this.dtpSickDay.Value);
                   
                    MessageBox.Show("Đã thanh toán hóa đơn thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult result = MessageBox.Show("Bạn có muốn in hóa đơn không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        FormReportInvolke form = new FormReportInvolke(patientExams[0].Id);
                        BUS.Event.ShowFormDialog(form);
                    }
                    choiceIdPatientExam = null;
                }
                else
                {
                    DAO.NotificationHandler.NotifyWarning("Vui lòng chọn phiếu khám bệnh để thanh toán");
                }
            }
            catch (Exception a)
            {
                
                MessageBox.Show($"Lỗi hệ thống = bBayClicked + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void dgvPatientExamedDoubleClicked(object sender, EventArgs e)
        {
            try
            {
                
                if (this.dgvPatientExamed.CurrentRow == null || this.dgvPatientExamed.CurrentRow.Index == choicePosPatientExam)
                    return;
                choiceIdPatientExam = this.dgvPatientExamed.CurrentRow.Cells[1].Value.ToString();
                choicePosPatientExam = this.dgvPatientExamed.CurrentRow.Index;
                totalMoney = totalMedicalMoney = totalExamMoney = 0;
                this.dgvMedicalList.Rows.Clear();
                List<DetailPatientExam> detailPatientExams = await BUS.FormSetInvolkeBUS.GetDetailPatientExams(choiceIdPatientExam);
                foreach (var detailPatientExam in detailPatientExams)
                {
                    MedicinePhu medicine = await BUS.FormSetInvolkeBUS.GetMedicine(detailPatientExam.IdMedical);
                    this.dgvMedicalList.Rows.Add(
                        this.dgvMedicalList.Rows.Count + 1,
                        medicine.name,
                        await BUS.FormSetInvolkeBUS.GetUnitName(medicine.unitID),
                        detailPatientExam.Money / detailPatientExam.MedicalNum,
                        detailPatientExam.MedicalNum,
                        detailPatientExam.Money);
                    totalMedicalMoney += detailPatientExam.Money;
                }
                totalExamMoney = await BUS.FormSetInvolkeBUS.GetExamMoney();
                this.tbTotalMoneyExam.Text = BUS.Support.IntToMoney(totalExamMoney);
                this.tbTotalMoneyMedical.Text = BUS.Support.IntToMoney(totalMedicalMoney);
                this.totalMoney = totalExamMoney + totalMedicalMoney;
                this.tbTotal.Text = BUS.Support.IntToMoney(totalMoney);
                
            }
            catch (Exception a)
            {
                
                MessageBox.Show($"Lỗi hệ thống = dgvPatientExamedDoubleClicked + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bRefreshClicked(object sender, EventArgs e)
        {
            this.cbPatientName.Text = "";
            this.cbIdPatientExam.Text = "";
        }

        private void cbPatientNameTextChanged(object sender, EventArgs e)
        {
            LoadForm(this.dtpSickDay.Value);
        }

        private void cbIdPatientExamTextChanged(object sender, EventArgs e)
        {
            LoadForm(this.dtpSickDay.Value);
        }

        private async void cbIdPatient_Adapter(DateTime date)
        {
            try
            {
                
                this.cbIdPatientExam.Items.Clear();
                List<PatientExam> patientExams = await BUS.FormSetInvolkeBUS.GetPatientExams(null, null, date, this.chbDaySick.Checked);
                foreach (var patientExam in patientExams)
                {
                    cbIdPatientExam.Items.Add(patientExam.Id);
                }
                
            }
            catch (Exception a) 
            {
                
                MessageBox.Show($"Lỗi hệ thống = dgvPatientExamedDoubleClicked + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void cbPatientName_Adapter(DateTime date)
        {
            try
            {
                
                this.cbPatientName.Items.Clear();
                List<PatientPhu> patients = await BUS.FormSetInvolkeBUS.GetPatients(null, date, this.chbDaySick.Checked);
                foreach (var patient in patients)
                {
                    this.cbPatientName.Items.Add(patient.Name);
                }
                
            }
            catch (Exception a)
            {
                
                MessageBox.Show($"Lỗi hệ thống = cbPatientName_Adapter + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void FormLoad(object sender, EventArgs e)
        {
            try
            {
                if (this.dtpSickDay.Value != DateTime.Now)
                {
                    //this.dtpSickDay.Value = DateTime.Now;
                    LoadForm(DateTime.Now);
                    cbIdPatient_Adapter(this.dtpSickDay.Value);
                    cbPatientName_Adapter(this.dtpSickDay.Value);
                }
                //cbIdPatient_Adapter(this.dtpSickDay.Value);
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = FormLoad + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private async void LoadForm(DateTime date = new DateTime())
        {
            try
            {
                int i = 0;
                choiceIdPatientExam = null;
                choicePosPatientExam = -1;
                this.dgvPatientExamed.Rows.Clear();
                this.dgvMedicalList.Rows.Clear();
                List<PatientExam> patientExams = await BUS.FormSetInvolkeBUS.GetPatientExams(
                    (this.cbPatientName.Text == "") ? null : this.cbPatientName.Text,
                    (this.cbIdPatientExam.Text == "") ? null : this.cbIdPatientExam.Text,
                    date, this.chbDaySick.Checked);
                if (this.dgvPatientExamed == null || this.dgvPatientExamed.Columns.Count <= 0)
                    return;
                foreach (var patientExam in patientExams)
                {
                    List<PatientPhu> patients = await BUS.FormSetInvolkeBUS.GetPatients(patientExam.Id, date, this.chbDaySick.Checked);
                    int count = await DAO.FormSetInvolkeDAO.CountInvolke(patientExam.Id);
                    this.dgvPatientExamed.Rows.Add(
                        this.dgvPatientExamed.Rows.Count + 1,
                        patientExam.Id,
                        patients[0].Name,
                        patients[0].Sex,
                        patients[0].Date.ToShortDateString(),
                        patients[0].Address,
                        (count == 0) ? "Chưa thanh toán" : "Đã thanh toán");
                }
                this.dgvPatientExamed.ClearSelection();
                
            }
            catch (Exception a)
            {
                MessageBox.Show($"Lỗi hệ thống = LoadForm + '{a.Message}'", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        private void onFormClosed(object s, FormClosedEventArgs e)
        {
            BUS.Event.ShowFormEffect(parent, 1);
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
