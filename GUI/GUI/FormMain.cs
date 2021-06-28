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
            bMedicalExaminationList.MouseEnter += BUS.Event.MouseEnterChangeForeColor;
            bMedicalExaminationList.MouseLeave += BUS.Event.MouseLeaveChangeForeColor;
            bSetMedicalExamination.MouseEnter += BUS.Event.MouseEnterChangeForeColor;
            bSetMedicalExamination.MouseLeave += BUS.Event.MouseLeaveChangeForeColor;
            bInputMedical.MouseEnter += BUS.Event.MouseEnterChangeForeColor;
            bInputMedical.MouseLeave += BUS.Event.MouseLeaveChangeForeColor;
            bPatientLookup.MouseEnter += BUS.Event.MouseEnterChangeForeColor;
            bPatientLookup.MouseLeave += BUS.Event.MouseLeaveChangeForeColor;
            //bStaffManagement.MouseEnter += BUS.Event.MouseEnterChangeForeColor;
            //bStaffManagement.MouseLeave += BUS.Event.MouseLeaveChangeForeColor;
            bSetReport.MouseEnter += BUS.Event.MouseEnterChangeForeColor;
            bSetReport.MouseLeave += BUS.Event.MouseLeaveChangeForeColor;
            bSetting.MouseEnter += BUS.Event.MouseEnterChangeForeColor;
            bSetting.MouseLeave += BUS.Event.MouseLeaveChangeForeColor;
            bSetInvolke.MouseEnter += BUS.Event.MouseEnterChangeForeColor;
            bSetInvolke.MouseLeave += BUS.Event.MouseLeaveChangeForeColor;
            bCancel.MouseEnter += BUS.Event.MouseEnterChangeForeColor;
            bCancel.MouseLeave += BUS.Event.MouseLeaveChangeForeColor;
        }

        private void InitDragBar()
        {
            BUS.Event.MouseDown_DragBar(this);
           
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
            BUS.Event.ShowChildForm_HideParentForm(formMedicalExaminationList, this);
        }

        private void bSetMedicalExaminationClicked(object s, EventArgs e)
        {
            FormSetMedicalExamination formSetMedicalExamination = new FormSetMedicalExamination(this);
            BUS.Event.ShowChildForm_HideParentForm(formSetMedicalExamination, this);
        }
        
        private void bSetInvolkeClicked(object s, EventArgs e)
        {
            FormSetInvolke formSetInvolke = new FormSetInvolke(this);
            BUS.Event.ShowChildForm_HideParentForm(formSetInvolke, this);
        }

        private void bInputMedicalClicked(object s, EventArgs e)
        {
            FormCreateImportedMedicineSlip formInputMedical = new FormCreateImportedMedicineSlip(this);
            BUS.Event.ShowChildForm_HideParentForm(formInputMedical, this);
        }

        private void bPatientLookupClicked(object s, EventArgs e)
        {
            FormPatientLookup formPatientLookup = new FormPatientLookup(this);
            BUS.Event.ShowChildForm_HideParentForm(formPatientLookup, this);
        }

        private void bStaffManagementClicked(object s, EventArgs e)
        {
            FormStaffManagement formStaffManagement = new FormStaffManagement(this);
            BUS.Event.ShowChildForm_HideParentForm(formStaffManagement, this);
        }

        private void bSetReportClicked(object s, EventArgs e)
        {
            FormCreateReport formSetReport = new FormCreateReport(this);
            BUS.Event.ShowChildForm_HideParentForm(formSetReport, this);
        }

        private void bSettingClicked(object s, EventArgs e)
        {
            FormSetting formSetting = new FormSetting(this);
            BUS.Event.ShowChildForm_HideParentForm(formSetting, this);
        }
    }
}
