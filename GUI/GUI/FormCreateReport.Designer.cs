
namespace GUI
{
    partial class FormCreateReport
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpEndday2 = new ns1.BunifuDatepicker();
            this.dtpBeginDay2 = new ns1.BunifuDatepicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bFind = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbMedicalName = new System.Windows.Forms.ComboBox();
            this.bPrintMedicalReport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvMedicalReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLanDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bReturn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bReportTotal = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dtpEndDay = new ns1.BunifuDatepicker();
            this.dtpBeginDay = new ns1.BunifuDatepicker();
            this.bPrintTotalReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMoneyReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.bCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bReportMedical = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalReport)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneyReport)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.bReportMedical);
            this.panel4.Controls.Add(this.dtpEndday2);
            this.panel4.Controls.Add(this.dtpBeginDay2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.bFind);
            this.panel4.Controls.Add(this.cbMedicalName);
            this.panel4.Controls.Add(this.bPrintMedicalReport);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.dgvMedicalReport);
            this.panel4.Location = new System.Drawing.Point(36, 582);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1860, 440);
            this.panel4.TabIndex = 38;
            // 
            // dtpEndday2
            // 
            this.dtpEndday2.BackColor = System.Drawing.Color.White;
            this.dtpEndday2.BorderRadius = 6;
            this.dtpEndday2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpEndday2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndday2.ForeColor = System.Drawing.Color.Black;
            this.dtpEndday2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndday2.FormatCustom = "dd/mm/yyyy";
            this.dtpEndday2.Location = new System.Drawing.Point(339, 52);
            this.dtpEndday2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dtpEndday2.Name = "dtpEndday2";
            this.dtpEndday2.Size = new System.Drawing.Size(297, 42);
            this.dtpEndday2.TabIndex = 137;
            this.dtpEndday2.Value = new System.DateTime(2021, 6, 6, 11, 44, 35, 994);
            // 
            // dtpBeginDay2
            // 
            this.dtpBeginDay2.BackColor = System.Drawing.Color.White;
            this.dtpBeginDay2.BorderRadius = 6;
            this.dtpBeginDay2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBeginDay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBeginDay2.ForeColor = System.Drawing.Color.Black;
            this.dtpBeginDay2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBeginDay2.FormatCustom = "dd/mm/yyyy";
            this.dtpBeginDay2.Location = new System.Drawing.Point(19, 52);
            this.dtpBeginDay2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dtpBeginDay2.Name = "dtpBeginDay2";
            this.dtpBeginDay2.Size = new System.Drawing.Size(297, 42);
            this.dtpBeginDay2.TabIndex = 136;
            this.dtpBeginDay2.Value = new System.DateTime(2021, 6, 6, 11, 44, 35, 994);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(334, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 26);
            this.label5.TabIndex = 135;
            this.label5.Text = "Ngày kết thúc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Honeydew;
            this.label7.Location = new System.Drawing.Point(14, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 26);
            this.label7.TabIndex = 134;
            this.label7.Text = "Ngày bắt đầu";
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
            this.bFind.Location = new System.Drawing.Point(1596, 52);
            this.bFind.Name = "bFind";
            this.bFind.ShadowDecoration.Parent = this.bFind;
            this.bFind.Size = new System.Drawing.Size(102, 37);
            this.bFind.TabIndex = 133;
            this.bFind.Text = "Tìm kiếm";
            // 
            // cbMedicalName
            // 
            this.cbMedicalName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMedicalName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMedicalName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMedicalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbMedicalName.FormattingEnabled = true;
            this.cbMedicalName.Location = new System.Drawing.Point(1189, 52);
            this.cbMedicalName.Name = "cbMedicalName";
            this.cbMedicalName.Size = new System.Drawing.Size(397, 37);
            this.cbMedicalName.TabIndex = 132;
            // 
            // bPrintMedicalReport
            // 
            this.bPrintMedicalReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPrintMedicalReport.BackColor = System.Drawing.Color.Lavender;
            this.bPrintMedicalReport.BackgroundImage = global::GUI.Properties.Resources.print_80px;
            this.bPrintMedicalReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPrintMedicalReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPrintMedicalReport.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.bPrintMedicalReport.FlatAppearance.BorderSize = 2;
            this.bPrintMedicalReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrintMedicalReport.Location = new System.Drawing.Point(1780, 42);
            this.bPrintMedicalReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPrintMedicalReport.Name = "bPrintMedicalReport";
            this.bPrintMedicalReport.Size = new System.Drawing.Size(59, 58);
            this.bPrintMedicalReport.TabIndex = 77;
            this.bPrintMedicalReport.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.ForeColor = System.Drawing.Color.Honeydew;
            this.label6.Location = new System.Drawing.Point(1066, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 26);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tên thuốc:";
            // 
            // dgvMedicalReport
            // 
            this.dgvMedicalReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicalReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicalReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicalReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicalReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicalReport.ColumnHeadersHeight = 29;
            this.dgvMedicalReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TenThuoc,
            this.DonViTinh,
            this.SoLuong,
            this.SoLanDung});
            this.dgvMedicalReport.Location = new System.Drawing.Point(19, 105);
            this.dgvMedicalReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMedicalReport.Name = "dgvMedicalReport";
            this.dgvMedicalReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMedicalReport.RowHeadersWidth = 51;
            this.dgvMedicalReport.RowTemplate.Height = 24;
            this.dgvMedicalReport.Size = new System.Drawing.Size(1820, 314);
            this.dgvMedicalReport.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 72;
            // 
            // TenThuoc
            // 
            this.TenThuoc.HeaderText = "Tên thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            this.DonViTinh.Width = 128;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 111;
            // 
            // SoLanDung
            // 
            this.SoLanDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoLanDung.HeaderText = "Số lần dùng";
            this.SoLanDung.MinimumWidth = 6;
            this.SoLanDung.Name = "SoLanDung";
            this.SoLanDung.ReadOnly = true;
            this.SoLanDung.Width = 137;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 1043);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1924, 12);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 41;
            this.progressBar1.Value = 50;
            // 
            // bReturn
            // 
            this.bReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bReturn.BackColor = System.Drawing.Color.Transparent;
            this.bReturn.BackgroundImage = global::GUI.Properties.Resources.button3;
            this.bReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bReturn.FlatAppearance.BorderSize = 0;
            this.bReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bReturn.Location = new System.Drawing.Point(1927, 11);
            this.bReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(137, 79);
            this.bReturn.TabIndex = 40;
            this.bReturn.Text = "QUAY LẠI";
            this.bReturn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bReportTotal);
            this.panel1.Controls.Add(this.dtpEndDay);
            this.panel1.Controls.Add(this.dtpBeginDay);
            this.panel1.Controls.Add(this.bPrintTotalReport);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvMoneyReport);
            this.panel1.Location = new System.Drawing.Point(36, 160);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1860, 378);
            this.panel1.TabIndex = 43;
            // 
            // bReportTotal
            // 
            this.bReportTotal.Animated = true;
            this.bReportTotal.BackColor = System.Drawing.Color.Transparent;
            this.bReportTotal.BorderRadius = 6;
            this.bReportTotal.CheckedState.Parent = this.bReportTotal;
            this.bReportTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bReportTotal.CustomImages.Parent = this.bReportTotal;
            this.bReportTotal.FillColor = System.Drawing.Color.Ivory;
            this.bReportTotal.FillColor2 = System.Drawing.Color.Ivory;
            this.bReportTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReportTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bReportTotal.HoverState.Parent = this.bReportTotal;
            this.bReportTotal.Location = new System.Drawing.Point(646, 68);
            this.bReportTotal.Name = "bReportTotal";
            this.bReportTotal.ShadowDecoration.Parent = this.bReportTotal;
            this.bReportTotal.Size = new System.Drawing.Size(102, 37);
            this.bReportTotal.TabIndex = 130;
            this.bReportTotal.Text = "Báo cáo";
            // 
            // dtpEndDay
            // 
            this.dtpEndDay.BackColor = System.Drawing.Color.White;
            this.dtpEndDay.BorderRadius = 6;
            this.dtpEndDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpEndDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDay.ForeColor = System.Drawing.Color.Black;
            this.dtpEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDay.FormatCustom = "dd/mm/yyyy";
            this.dtpEndDay.Location = new System.Drawing.Point(339, 68);
            this.dtpEndDay.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dtpEndDay.Name = "dtpEndDay";
            this.dtpEndDay.Size = new System.Drawing.Size(297, 42);
            this.dtpEndDay.TabIndex = 122;
            this.dtpEndDay.Value = new System.DateTime(2021, 6, 6, 11, 44, 35, 994);
            // 
            // dtpBeginDay
            // 
            this.dtpBeginDay.BackColor = System.Drawing.Color.White;
            this.dtpBeginDay.BorderRadius = 6;
            this.dtpBeginDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBeginDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBeginDay.ForeColor = System.Drawing.Color.Black;
            this.dtpBeginDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBeginDay.FormatCustom = "dd/mm/yyyy";
            this.dtpBeginDay.Location = new System.Drawing.Point(19, 68);
            this.dtpBeginDay.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dtpBeginDay.Name = "dtpBeginDay";
            this.dtpBeginDay.Size = new System.Drawing.Size(297, 42);
            this.dtpBeginDay.TabIndex = 121;
            this.dtpBeginDay.Value = new System.DateTime(2021, 6, 6, 11, 44, 35, 994);
            // 
            // bPrintTotalReport
            // 
            this.bPrintTotalReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPrintTotalReport.BackColor = System.Drawing.Color.Lavender;
            this.bPrintTotalReport.BackgroundImage = global::GUI.Properties.Resources.print_80px;
            this.bPrintTotalReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPrintTotalReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPrintTotalReport.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.bPrintTotalReport.FlatAppearance.BorderSize = 2;
            this.bPrintTotalReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrintTotalReport.Location = new System.Drawing.Point(1780, 71);
            this.bPrintTotalReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPrintTotalReport.Name = "bPrintTotalReport";
            this.bPrintTotalReport.Size = new System.Drawing.Size(59, 58);
            this.bPrintTotalReport.TabIndex = 78;
            this.bPrintTotalReport.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(334, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 26);
            this.label3.TabIndex = 46;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // dgvMoneyReport
            // 
            this.dgvMoneyReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMoneyReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMoneyReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMoneyReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMoneyReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMoneyReport.ColumnHeadersHeight = 29;
            this.dgvMoneyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Ngay,
            this.SoBenhNhan,
            this.DoanhThu,
            this.TyLe});
            this.dgvMoneyReport.Location = new System.Drawing.Point(19, 134);
            this.dgvMoneyReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMoneyReport.Name = "dgvMoneyReport";
            this.dgvMoneyReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMoneyReport.RowHeadersWidth = 51;
            this.dgvMoneyReport.RowTemplate.Height = 24;
            this.dgvMoneyReport.Size = new System.Drawing.Size(1820, 227);
            this.dgvMoneyReport.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "STT";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 72;
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // SoBenhNhan
            // 
            this.SoBenhNhan.HeaderText = "Số bệnh nhân";
            this.SoBenhNhan.MinimumWidth = 6;
            this.SoBenhNhan.Name = "SoBenhNhan";
            this.SoBenhNhan.ReadOnly = true;
            // 
            // DoanhThu
            // 
            this.DoanhThu.HeaderText = "DoanhThu";
            this.DoanhThu.MinimumWidth = 6;
            this.DoanhThu.Name = "DoanhThu";
            this.DoanhThu.ReadOnly = true;
            // 
            // TyLe
            // 
            this.TyLe.HeaderText = "Tỷ lệ";
            this.TyLe.MinimumWidth = 6;
            this.TyLe.Name = "TyLe";
            this.TyLe.ReadOnly = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel1.Controls.Add(this.bCancel);
            this.guna2GradientPanel1.Controls.Add(this.label10);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1924, 92);
            this.guna2GradientPanel1.TabIndex = 74;
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
            this.bCancel.Location = new System.Drawing.Point(1797, 12);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(115, 36);
            this.bCancel.TabIndex = 115;
            this.bCancel.Text = "THOÁT";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1924, 92);
            this.label10.TabIndex = 113;
            this.label10.Text = "LẬP BÁO CÁO";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(134)))));
            this.label2.Location = new System.Drawing.Point(31, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 26);
            this.label2.TabIndex = 129;
            this.label2.Text = "Báo cáo doanh thu";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(134)))));
            this.label4.Location = new System.Drawing.Point(31, 552);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 26);
            this.label4.TabIndex = 130;
            this.label4.Text = "Báo cáo doanh thu";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.cbMedicalName;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.panel4;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 10;
            this.guna2Elipse3.TargetControl = this.panel1;
            // 
            // bReportMedical
            // 
            this.bReportMedical.Animated = true;
            this.bReportMedical.BackColor = System.Drawing.Color.Transparent;
            this.bReportMedical.BorderRadius = 6;
            this.bReportMedical.CheckedState.Parent = this.bReportMedical;
            this.bReportMedical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bReportMedical.CustomImages.Parent = this.bReportMedical;
            this.bReportMedical.FillColor = System.Drawing.Color.Ivory;
            this.bReportMedical.FillColor2 = System.Drawing.Color.Ivory;
            this.bReportMedical.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReportMedical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bReportMedical.HoverState.Parent = this.bReportMedical;
            this.bReportMedical.Location = new System.Drawing.Point(646, 55);
            this.bReportMedical.Name = "bReportMedical";
            this.bReportMedical.ShadowDecoration.Parent = this.bReportMedical;
            this.bReportMedical.Size = new System.Drawing.Size(102, 37);
            this.bReportMedical.TabIndex = 138;
            this.bReportMedical.Text = "Báo cáo";
            // 
            // FormSetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bReturn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSetReport";
            this.Text = "Lập báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneyReport)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvMedicalReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLanDung;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMoneyReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bPrintMedicalReport;
        private System.Windows.Forms.Button bPrintTotalReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLe;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton bCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMedicalName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private ns1.BunifuDatepicker dtpEndDay;
        private ns1.BunifuDatepicker dtpBeginDay;
        private Guna.UI2.WinForms.Guna2GradientButton bReportTotal;
        private Guna.UI2.WinForms.Guna2GradientButton bFind;
        private ns1.BunifuDatepicker dtpEndday2;
        private ns1.BunifuDatepicker dtpBeginDay2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GradientButton bReportMedical;
    }
}