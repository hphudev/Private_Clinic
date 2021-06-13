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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.MouseDown += (s, e) =>
            {
                InitDragBar();
            };
            Init_Effect();
            Init_bMedicalExaminationList();
            Init_bSetMedicalExamination();
            Init_bInputMedical();
            Init_bSetInvolke();
            Init_bPatientLookup();
            Init_bSetReport();
            Init_bSetting();
            Init_bStaffManagement();

        }

        private void Init_bSetMedicalExamination()
        {
            bSetMedicalExamination.Click += bSetMedicalExaminationClicked;
        }

        private void Init_Effect()
        {
            bMedicalExaminationList.MouseEnter += BUS.EventHandler.MouseEnterChangeForeColor;
            bMedicalExaminationList.MouseLeave += BUS.EventHandler.MouseLeaveChangeForeColor;
            bSetMedicalExamination.MouseEnter += BUS.EventHandler.MouseEnterChangeForeColor;
            bSetMedicalExamination.MouseLeave += BUS.EventHandler.MouseLeaveChangeForeColor;
            bInputMedical.MouseEnter += BUS.EventHandler.MouseEnterChangeForeColor;
            bInputMedical.MouseLeave += BUS.EventHandler.MouseLeaveChangeForeColor;
            bPatientLookup.MouseEnter += BUS.EventHandler.MouseEnterChangeForeColor;
            bPatientLookup.MouseLeave += BUS.EventHandler.MouseLeaveChangeForeColor;
            //bStaffManagement.MouseEnter += BUS.Event.MouseEnterChangeForeColor;
            //bStaffManagement.MouseLeave += BUS.Event.MouseLeaveChangeForeColor;
            bSetReport.MouseEnter += BUS.EventHandler.MouseEnterChangeForeColor;
            bSetReport.MouseLeave += BUS.EventHandler.MouseLeaveChangeForeColor;
            bSetting.MouseEnter += BUS.EventHandler.MouseEnterChangeForeColor;
            bSetting.MouseLeave += BUS.EventHandler.MouseLeaveChangeForeColor;
            bSetInvolke.MouseEnter += BUS.EventHandler.MouseEnterChangeForeColor;
            bSetInvolke.MouseLeave += BUS.EventHandler.MouseLeaveChangeForeColor;
            bCancel.MouseEnter += BUS.EventHandler.MouseEnterChangeForeColor;
            bCancel.MouseLeave += BUS.EventHandler.MouseLeaveChangeForeColor;
        }

        private void InitDragBar()
        {
            BUS.EventHandler.MouseDown_DragBar(this);
           
        }

        private void Init_bMedicalExaminationList()
        {
            bMedicalExaminationList.Click += bMedicalExaminationListClicked;
        }

        private void Init_bSetInvolke()
        {
            bSetInvolke.Click += bSetInvolkeClicked;

        }

        private void Init_bInputMedical()
        {
            bInputMedical.Click += bInputMedicalClicked;

        }

        private void Init_bPatientLookup()
        {
            bPatientLookup.Click += bPatientLookupClicked;
        }

        private void Init_bStaffManagement()
        {
           // bStaffManagement.Click += bStaffManagementClicked;
        }

        private void Init_bSetReport()
        {
            bSetReport.Click += bSetReportClicked;
        }

        private void Init_bSetting()
        {
            bSetting.Click += bSettingClicked;
        }

        private void BReturn_Click(object sender, EventArgs e)
        {

        }

        private void bMedicalExaminationListClicked(object sender, EventArgs e)
        {
            FormMedicalExaminationList formMedicalExaminationList = new FormMedicalExaminationList(this);
            BUS.EventHandler.ShowChildForm_HideParentForm(formMedicalExaminationList, this);
        }

        private void bSetMedicalExaminationClicked(object s, EventArgs e)
        {
            FormSetMedicalExamination formSetMedicalExamination = new FormSetMedicalExamination(this);
            BUS.EventHandler.ShowChildForm_HideParentForm(formSetMedicalExamination, this);
        }
        
        private void bSetInvolkeClicked(object s, EventArgs e)
        {
            FormSetInvolke formSetInvolke = new FormSetInvolke(this);
            BUS.EventHandler.ShowChildForm_HideParentForm(formSetInvolke, this);
        }

        private void bInputMedicalClicked(object s, EventArgs e)
        {
            FormImportMedicine formInputMedical = new FormImportMedicine(this);
            BUS.EventHandler.ShowChildForm_HideParentForm(formInputMedical, this);
        }

        private void bPatientLookupClicked(object s, EventArgs e)
        {
            FormPatientLookup formPatientLookup = new FormPatientLookup(this);
            BUS.EventHandler.ShowChildForm_HideParentForm(formPatientLookup, this);
        }

        private void bStaffManagementClicked(object s, EventArgs e)
        {
            FormStaffManagement formStaffManagement = new FormStaffManagement(this);
            BUS.EventHandler.ShowChildForm_HideParentForm(formStaffManagement, this);
        }

        private void bSetReportClicked(object s, EventArgs e)
        {
            FormCreateReport formSetReport = new FormCreateReport(this);
            BUS.EventHandler.ShowChildForm_HideParentForm(formSetReport, this);
        }

        private void bSettingClicked(object s, EventArgs e)
        {
            FormSetting formSetting = new FormSetting(this);
            BUS.EventHandler.ShowChildForm_HideParentForm(formSetting, this);
        }
    }
}
