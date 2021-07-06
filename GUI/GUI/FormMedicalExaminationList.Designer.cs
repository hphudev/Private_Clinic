
namespace GUI
{
    partial class FormMedicalExaminationList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.bCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lTitle = new System.Windows.Forms.Label();
            this.dtpSickDay = new ns1.BunifuDatepicker();
            this.lSickDay = new System.Windows.Forms.Label();
            this.bFind = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lMedicalList = new System.Windows.Forms.Label();
            this.bRegisterPatient = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cbFindIdPatient = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPatientList = new System.Windows.Forms.DataGridView();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMedicalExaminationList = new System.Windows.Forms.DataGridView();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gbFindPatient = new System.Windows.Forms.GroupBox();
            this.bRefresh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbFindPatient = new System.Windows.Forms.ComboBox();
            this.lInputPatientName = new System.Windows.Forms.Label();
            this.lInputIdPatient = new System.Windows.Forms.Label();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bAddPatient = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalExaminationList)).BeginInit();
            this.gbFindPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel1.Controls.Add(this.bCancel);
            this.guna2GradientPanel1.Controls.Add(this.lTitle);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1339, 92);
            this.guna2GradientPanel1.TabIndex = 20;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.Animated = true;
            this.bCancel.BackColor = System.Drawing.Color.Transparent;
            this.bCancel.BorderColor = System.Drawing.Color.White;
            this.bCancel.BorderRadius = 6;
            this.bCancel.BorderThickness = 1;
            this.bCancel.CheckedState.Parent = this.bCancel;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.CustomImages.Parent = this.bCancel;
            this.bCancel.FillColor = System.Drawing.Color.Transparent;
            this.bCancel.FillColor2 = System.Drawing.Color.Transparent;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.HoverState.Parent = this.bCancel;
            this.bCancel.Location = new System.Drawing.Point(1211, 12);
            this.bCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(115, 36);
            this.bCancel.TabIndex = 115;
            this.bCancel.Text = "THOÁT";
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lTitle.ForeColor = System.Drawing.Color.White;
            this.lTitle.Location = new System.Drawing.Point(0, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(1339, 92);
            this.lTitle.TabIndex = 113;
            this.lTitle.Text = "LẬP DANH SÁCH KHÁM BỆNH";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpSickDay
            // 
            this.dtpSickDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSickDay.BackColor = System.Drawing.Color.White;
            this.dtpSickDay.BorderRadius = 6;
            this.dtpSickDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpSickDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSickDay.ForeColor = System.Drawing.Color.Black;
            this.dtpSickDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSickDay.FormatCustom = "dd/mm/yyyy";
            this.dtpSickDay.Location = new System.Drawing.Point(1033, 137);
            this.dtpSickDay.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dtpSickDay.Name = "dtpSickDay";
            this.dtpSickDay.Size = new System.Drawing.Size(249, 42);
            this.dtpSickDay.TabIndex = 118;
            this.dtpSickDay.Value = new System.DateTime(2021, 6, 6, 11, 44, 35, 994);
            // 
            // lSickDay
            // 
            this.lSickDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lSickDay.AutoSize = true;
            this.lSickDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSickDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.lSickDay.Location = new System.Drawing.Point(1028, 103);
            this.lSickDay.Name = "lSickDay";
            this.lSickDay.Size = new System.Drawing.Size(191, 26);
            this.lSickDay.TabIndex = 117;
            this.lSickDay.Text = "Ngày khám bệnh";
            // 
            // bFind
            // 
            this.bFind.Animated = true;
            this.bFind.BackColor = System.Drawing.Color.Transparent;
            this.bFind.BorderRadius = 6;
            this.bFind.CheckedState.Parent = this.bFind;
            this.bFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFind.CustomImages.Parent = this.bFind;
            this.bFind.FillColor = System.Drawing.Color.Ivory;
            this.bFind.FillColor2 = System.Drawing.Color.Ivory;
            this.bFind.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bFind.HoverState.Parent = this.bFind;
            this.bFind.Location = new System.Drawing.Point(237, 58);
            this.bFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bFind.Name = "bFind";
            this.bFind.ShadowDecoration.Parent = this.bFind;
            this.bFind.Size = new System.Drawing.Size(101, 37);
            this.bFind.TabIndex = 122;
            this.bFind.Text = "Tìm kiếm";
            // 
            // lMedicalList
            // 
            this.lMedicalList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lMedicalList.AutoSize = true;
            this.lMedicalList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMedicalList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.lMedicalList.Location = new System.Drawing.Point(36, 678);
            this.lMedicalList.Name = "lMedicalList";
            this.lMedicalList.Size = new System.Drawing.Size(249, 26);
            this.lMedicalList.TabIndex = 123;
            this.lMedicalList.Text = "Danh sách khám bệnh";
            // 
            // bRegisterPatient
            // 
            this.bRegisterPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRegisterPatient.Animated = true;
            this.bRegisterPatient.BackColor = System.Drawing.Color.Transparent;
            this.bRegisterPatient.BorderRadius = 6;
            this.bRegisterPatient.CheckedState.Parent = this.bRegisterPatient;
            this.bRegisterPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRegisterPatient.CustomImages.Parent = this.bRegisterPatient;
            this.bRegisterPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bRegisterPatient.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bRegisterPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegisterPatient.ForeColor = System.Drawing.Color.Ivory;
            this.bRegisterPatient.HoverState.Parent = this.bRegisterPatient;
            this.bRegisterPatient.Location = new System.Drawing.Point(1172, 286);
            this.bRegisterPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRegisterPatient.Name = "bRegisterPatient";
            this.bRegisterPatient.ShadowDecoration.Parent = this.bRegisterPatient;
            this.bRegisterPatient.Size = new System.Drawing.Size(109, 43);
            this.bRegisterPatient.TabIndex = 125;
            this.bRegisterPatient.Text = "Ghi danh";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.cbFindIdPatient;
            // 
            // cbFindIdPatient
            // 
            this.cbFindIdPatient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFindIdPatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFindIdPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFindIdPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbFindIdPatient.FormattingEnabled = true;
            this.cbFindIdPatient.Location = new System.Drawing.Point(11, 58);
            this.cbFindIdPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFindIdPatient.Name = "cbFindIdPatient";
            this.cbFindIdPatient.Size = new System.Drawing.Size(221, 37);
            this.cbFindIdPatient.TabIndex = 132;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.dgvPatientList);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(41, 333);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 343);
            this.panel1.TabIndex = 127;
            // 
            // dgvPatientList
            // 
            this.dgvPatientList.AllowUserToAddRows = false;
            this.dgvPatientList.AllowUserToDeleteRows = false;
            this.dgvPatientList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatientList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPatientList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatientList.ColumnHeadersHeight = 29;
            this.dgvPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaKB,
            this.HoTen,
            this.GioiTinh,
            this.NamSinh,
            this.DiaChi});
            this.dgvPatientList.EnableHeadersVisualStyles = false;
            this.dgvPatientList.Location = new System.Drawing.Point(27, 21);
            this.dgvPatientList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatientList.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue;
            this.dgvPatientList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatientList.RowTemplate.Height = 24;
            this.dgvPatientList.Size = new System.Drawing.Size(1196, 305);
            this.dgvPatientList.TabIndex = 1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.panel1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.panel2.Controls.Add(this.dgvMedicalExaminationList);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(41, 706);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1241, 313);
            this.panel2.TabIndex = 128;
            // 
            // dgvMedicalExaminationList
            // 
            this.dgvMedicalExaminationList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicalExaminationList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicalExaminationList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicalExaminationList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicalExaminationList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMedicalExaminationList.ColumnHeadersHeight = 29;
            this.dgvMedicalExaminationList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvMedicalExaminationList.EnableHeadersVisualStyles = false;
            this.dgvMedicalExaminationList.Location = new System.Drawing.Point(12, 18);
            this.dgvMedicalExaminationList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMedicalExaminationList.MultiSelect = false;
            this.dgvMedicalExaminationList.Name = "dgvMedicalExaminationList";
            this.dgvMedicalExaminationList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicalExaminationList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMedicalExaminationList.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Blue;
            this.dgvMedicalExaminationList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMedicalExaminationList.RowTemplate.Height = 24;
            this.dgvMedicalExaminationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicalExaminationList.Size = new System.Drawing.Size(1213, 279);
            this.dgvMedicalExaminationList.TabIndex = 2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 10;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // gbFindPatient
            // 
            this.gbFindPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.gbFindPatient.Controls.Add(this.bRefresh);
            this.gbFindPatient.Controls.Add(this.cbFindPatient);
            this.gbFindPatient.Controls.Add(this.lInputPatientName);
            this.gbFindPatient.Controls.Add(this.cbFindIdPatient);
            this.gbFindPatient.Controls.Add(this.lInputIdPatient);
            this.gbFindPatient.Controls.Add(this.bFind);
            this.gbFindPatient.ForeColor = System.Drawing.Color.Ivory;
            this.gbFindPatient.Location = new System.Drawing.Point(41, 124);
            this.gbFindPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFindPatient.Name = "gbFindPatient";
            this.gbFindPatient.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFindPatient.Size = new System.Drawing.Size(467, 178);
            this.gbFindPatient.TabIndex = 131;
            this.gbFindPatient.TabStop = false;
            this.gbFindPatient.Text = "Tìm kiếm bệnh nhân";
            // 
            // bRefresh
            // 
            this.bRefresh.Animated = true;
            this.bRefresh.BackColor = System.Drawing.Color.Transparent;
            this.bRefresh.BorderRadius = 6;
            this.bRefresh.CheckedState.Parent = this.bRefresh;
            this.bRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRefresh.CustomImages.Parent = this.bRefresh;
            this.bRefresh.FillColor = System.Drawing.Color.Ivory;
            this.bRefresh.FillColor2 = System.Drawing.Color.Ivory;
            this.bRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bRefresh.HoverState.Parent = this.bRefresh;
            this.bRefresh.Location = new System.Drawing.Point(345, 58);
            this.bRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.ShadowDecoration.Parent = this.bRefresh;
            this.bRefresh.Size = new System.Drawing.Size(101, 37);
            this.bRefresh.TabIndex = 135;
            this.bRefresh.Text = "Làm mới";
            // 
            // cbFindPatient
            // 
            this.cbFindPatient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFindPatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFindPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFindPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbFindPatient.FormattingEnabled = true;
            this.cbFindPatient.Location = new System.Drawing.Point(11, 130);
            this.cbFindPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFindPatient.Name = "cbFindPatient";
            this.cbFindPatient.Size = new System.Drawing.Size(437, 37);
            this.cbFindPatient.TabIndex = 134;
            // 
            // lInputPatientName
            // 
            this.lInputPatientName.AutoSize = true;
            this.lInputPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInputPatientName.ForeColor = System.Drawing.Color.Ivory;
            this.lInputPatientName.Location = new System.Drawing.Point(5, 98);
            this.lInputPatientName.Name = "lInputPatientName";
            this.lInputPatientName.Size = new System.Drawing.Size(232, 26);
            this.lInputPatientName.TabIndex = 133;
            this.lInputPatientName.Text = "Họ và tên bệnh nhân";
            // 
            // lInputIdPatient
            // 
            this.lInputIdPatient.AutoSize = true;
            this.lInputIdPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInputIdPatient.ForeColor = System.Drawing.Color.Ivory;
            this.lInputIdPatient.Location = new System.Drawing.Point(5, 26);
            this.lInputIdPatient.Name = "lInputIdPatient";
            this.lInputIdPatient.Size = new System.Drawing.Size(162, 26);
            this.lInputIdPatient.TabIndex = 131;
            this.lInputIdPatient.Text = "Mã bệnh nhân";
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.cbFindPatient;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 10;
            this.guna2Elipse5.TargetControl = this.gbFindPatient;
            // 
            // bAddPatient
            // 
            this.bAddPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddPatient.Animated = true;
            this.bAddPatient.BackColor = System.Drawing.Color.Transparent;
            this.bAddPatient.BorderRadius = 6;
            this.bAddPatient.CheckedState.Parent = this.bAddPatient;
            this.bAddPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddPatient.CustomImages.Parent = this.bAddPatient;
            this.bAddPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bAddPatient.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bAddPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddPatient.ForeColor = System.Drawing.Color.Ivory;
            this.bAddPatient.HoverState.Parent = this.bAddPatient;
            this.bAddPatient.Location = new System.Drawing.Point(968, 286);
            this.bAddPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAddPatient.Name = "bAddPatient";
            this.bAddPatient.ShadowDecoration.Parent = this.bAddPatient;
            this.bAddPatient.Size = new System.Drawing.Size(197, 43);
            this.bAddPatient.TabIndex = 132;
            this.bAddPatient.Text = "Thêm bệnh nhân mới";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.label1.Location = new System.Drawing.Point(36, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 26);
            this.label1.TabIndex = 133;
            this.label1.Text = "Danh sách bệnh nhân";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Stt";
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 78;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ và tên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn3.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 116;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "birthday";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 132;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 78;
            // 
            // MaKB
            // 
            this.MaKB.HeaderText = "Mã bệnh nhân";
            this.MaKB.MinimumWidth = 6;
            this.MaKB.Name = "MaKB";
            this.MaKB.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 116;
            // 
            // NamSinh
            // 
            this.NamSinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NamSinh.HeaderText = "Ngày sinh";
            this.NamSinh.MinimumWidth = 6;
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.ReadOnly = true;
            this.NamSinh.Width = 132;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // FormMedicalExaminationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1339, 1055);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAddPatient);
            this.Controls.Add(this.gbFindPatient);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bRegisterPatient);
            this.Controls.Add(this.lMedicalList);
            this.Controls.Add(this.dtpSickDay);
            this.Controls.Add(this.lSickDay);
            this.Controls.Add(this.guna2GradientPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMedicalExaminationList";
            this.Text = "Phần mềm quản lý phòng mạch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2GradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalExaminationList)).EndInit();
            this.gbFindPatient.ResumeLayout(false);
            this.gbFindPatient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label lTitle;
        private ns1.BunifuDatepicker dtpSickDay;
        private System.Windows.Forms.Label lSickDay;
        private Guna.UI2.WinForms.Guna2GradientButton bCancel;
        private Guna.UI2.WinForms.Guna2GradientButton bFind;
        private System.Windows.Forms.Label lMedicalList;
        private Guna.UI2.WinForms.Guna2GradientButton bRegisterPatient;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPatientList;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMedicalExaminationList;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.GroupBox gbFindPatient;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private System.Windows.Forms.ComboBox cbFindPatient;
        private System.Windows.Forms.Label lInputPatientName;
        private System.Windows.Forms.ComboBox cbFindIdPatient;
        private System.Windows.Forms.Label lInputIdPatient;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2GradientButton bAddPatient;
        private Guna.UI2.WinForms.Guna2GradientButton bRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKB;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}