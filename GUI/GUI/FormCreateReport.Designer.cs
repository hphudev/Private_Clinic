
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bPrintMedicalReport = new System.Windows.Forms.Button();
            this.dgvMedicineUseReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLanDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCreateMedicineUseReport = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bReturn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRevenueReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPrintTotalReport = new System.Windows.Forms.Button();
            this.bCreateRevenueReport = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.bCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbMonth = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineUseReport)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueReport)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.bPrintMedicalReport);
            this.panel4.Controls.Add(this.dgvMedicineUseReport);
            this.panel4.Location = new System.Drawing.Point(36, 612);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1860, 430);
            this.panel4.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(14, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 26);
            this.label4.TabIndex = 130;
            this.label4.Text = "Báo cáo sử dụng thuốc";
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
            this.bPrintMedicalReport.Location = new System.Drawing.Point(1791, 2);
            this.bPrintMedicalReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPrintMedicalReport.Name = "bPrintMedicalReport";
            this.bPrintMedicalReport.Size = new System.Drawing.Size(48, 48);
            this.bPrintMedicalReport.TabIndex = 77;
            this.bPrintMedicalReport.UseVisualStyleBackColor = false;
            // 
            // dgvMedicineUseReport
            // 
            this.dgvMedicineUseReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicineUseReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicineUseReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicineUseReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicineUseReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicineUseReport.ColumnHeadersHeight = 29;
            this.dgvMedicineUseReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TenThuoc,
            this.DonViTinh,
            this.SoLuong,
            this.SoLanDung});
            this.dgvMedicineUseReport.EnableHeadersVisualStyles = false;
            this.dgvMedicineUseReport.Location = new System.Drawing.Point(19, 54);
            this.dgvMedicineUseReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMedicineUseReport.Name = "dgvMedicineUseReport";
            this.dgvMedicineUseReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicineUseReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicineUseReport.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue;
            this.dgvMedicineUseReport.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMedicineUseReport.RowTemplate.Height = 24;
            this.dgvMedicineUseReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicineUseReport.Size = new System.Drawing.Size(1820, 355);
            this.dgvMedicineUseReport.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 78;
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
            this.DonViTinh.Width = 138;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 123;
            // 
            // SoLanDung
            // 
            this.SoLanDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoLanDung.HeaderText = "Số lần dùng";
            this.SoLanDung.MinimumWidth = 6;
            this.SoLanDung.Name = "SoLanDung";
            this.SoLanDung.ReadOnly = true;
            this.SoLanDung.Width = 152;
            // 
            // bCreateMedicineUseReport
            // 
            this.bCreateMedicineUseReport.Animated = true;
            this.bCreateMedicineUseReport.BackColor = System.Drawing.Color.Transparent;
            this.bCreateMedicineUseReport.BorderRadius = 6;
            this.bCreateMedicineUseReport.CheckedState.Parent = this.bCreateMedicineUseReport;
            this.bCreateMedicineUseReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCreateMedicineUseReport.CustomImages.Parent = this.bCreateMedicineUseReport;
            this.bCreateMedicineUseReport.FillColor = System.Drawing.Color.Ivory;
            this.bCreateMedicineUseReport.FillColor2 = System.Drawing.Color.Ivory;
            this.bCreateMedicineUseReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCreateMedicineUseReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bCreateMedicineUseReport.HoverState.Parent = this.bCreateMedicineUseReport;
            this.bCreateMedicineUseReport.Location = new System.Drawing.Point(445, 112);
            this.bCreateMedicineUseReport.Name = "bCreateMedicineUseReport";
            this.bCreateMedicineUseReport.ShadowDecoration.Parent = this.bCreateMedicineUseReport;
            this.bCreateMedicineUseReport.Size = new System.Drawing.Size(257, 37);
            this.bCreateMedicineUseReport.TabIndex = 138;
            this.bCreateMedicineUseReport.Text = "Xem báo cáo sử dụng thuốc";
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvRevenueReport);
            this.panel1.Controls.Add(this.bPrintTotalReport);
            this.panel1.Location = new System.Drawing.Point(36, 210);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1860, 364);
            this.panel1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 26);
            this.label2.TabIndex = 129;
            this.label2.Text = "Báo cáo doanh thu";
            // 
            // dgvRevenueReport
            // 
            this.dgvRevenueReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRevenueReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRevenueReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRevenueReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRevenueReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRevenueReport.ColumnHeadersHeight = 29;
            this.dgvRevenueReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Ngay,
            this.SoBenhNhan,
            this.DoanhThu,
            this.TyLe});
            this.dgvRevenueReport.EnableHeadersVisualStyles = false;
            this.dgvRevenueReport.Location = new System.Drawing.Point(19, 54);
            this.dgvRevenueReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRevenueReport.Name = "dgvRevenueReport";
            this.dgvRevenueReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRevenueReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRevenueReport.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Blue;
            this.dgvRevenueReport.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRevenueReport.RowTemplate.Height = 24;
            this.dgvRevenueReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRevenueReport.Size = new System.Drawing.Size(1820, 293);
            this.dgvRevenueReport.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "STT";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 78;
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
            this.TyLe.HeaderText = "Tỷ lệ doanh thu";
            this.TyLe.MinimumWidth = 6;
            this.TyLe.Name = "TyLe";
            this.TyLe.ReadOnly = true;
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
            this.bPrintTotalReport.Location = new System.Drawing.Point(1792, 2);
            this.bPrintTotalReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPrintTotalReport.Name = "bPrintTotalReport";
            this.bPrintTotalReport.Size = new System.Drawing.Size(47, 48);
            this.bPrintTotalReport.TabIndex = 78;
            this.bPrintTotalReport.UseVisualStyleBackColor = false;
            // 
            // bCreateRevenueReport
            // 
            this.bCreateRevenueReport.Animated = true;
            this.bCreateRevenueReport.BackColor = System.Drawing.Color.Transparent;
            this.bCreateRevenueReport.BorderRadius = 6;
            this.bCreateRevenueReport.CheckedState.Parent = this.bCreateRevenueReport;
            this.bCreateRevenueReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCreateRevenueReport.CustomImages.Parent = this.bCreateRevenueReport;
            this.bCreateRevenueReport.FillColor = System.Drawing.Color.Ivory;
            this.bCreateRevenueReport.FillColor2 = System.Drawing.Color.Ivory;
            this.bCreateRevenueReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCreateRevenueReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bCreateRevenueReport.HoverState.Parent = this.bCreateRevenueReport;
            this.bCreateRevenueReport.Location = new System.Drawing.Point(445, 157);
            this.bCreateRevenueReport.Name = "bCreateRevenueReport";
            this.bCreateRevenueReport.ShadowDecoration.Parent = this.bCreateRevenueReport;
            this.bCreateRevenueReport.Size = new System.Drawing.Size(257, 37);
            this.bCreateRevenueReport.TabIndex = 130;
            this.bCreateRevenueReport.Text = "Xem báo cáo doanh thu";
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
            this.label10.TabIndex = 0;
            this.label10.Text = "LẬP BÁO CÁO";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.groupBox1.Controls.Add(this.tbYear);
            this.groupBox1.Controls.Add(this.tbMonth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Ivory;
            this.groupBox1.Location = new System.Drawing.Point(36, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 91);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian báo cáo";
            // 
            // tbYear
            // 
            this.tbYear.AutoSize = true;
            this.tbYear.BorderRadius = 3;
            this.tbYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbYear.DefaultText = "";
            this.tbYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbYear.DisabledState.Parent = this.tbYear;
            this.tbYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbYear.FocusedState.Parent = this.tbYear;
            this.tbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbYear.HoverState.Parent = this.tbYear;
            this.tbYear.Location = new System.Drawing.Point(260, 34);
            this.tbYear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbYear.Name = "tbYear";
            this.tbYear.PasswordChar = '\0';
            this.tbYear.PlaceholderText = "";
            this.tbYear.SelectedText = "";
            this.tbYear.ShadowDecoration.Parent = this.tbYear;
            this.tbYear.Size = new System.Drawing.Size(109, 41);
            this.tbYear.TabIndex = 136;
            this.tbYear.TabStop = false;
            this.tbYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMonth
            // 
            this.tbMonth.AutoSize = true;
            this.tbMonth.BorderRadius = 3;
            this.tbMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMonth.DefaultText = "";
            this.tbMonth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMonth.DisabledState.Parent = this.tbMonth;
            this.tbMonth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMonth.FocusedState.Parent = this.tbMonth;
            this.tbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMonth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbMonth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMonth.HoverState.Parent = this.tbMonth;
            this.tbMonth.Location = new System.Drawing.Point(110, 34);
            this.tbMonth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.PasswordChar = '\0';
            this.tbMonth.PlaceholderText = "";
            this.tbMonth.SelectedText = "";
            this.tbMonth.ShadowDecoration.Parent = this.tbMonth;
            this.tbMonth.Size = new System.Drawing.Size(68, 41);
            this.tbMonth.TabIndex = 135;
            this.tbMonth.TabStop = false;
            this.tbMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(188, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 134;
            this.label3.Text = "Năm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 133;
            this.label1.Text = "Tháng:";
            // 
            // FormCreateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.bCreateMedicineUseReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bCreateRevenueReport);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.bReturn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCreateReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineUseReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueReport)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvMedicineUseReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLanDung;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRevenueReport;
        private System.Windows.Forms.Button bPrintMedicalReport;
        private System.Windows.Forms.Button bPrintTotalReport;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton bCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2GradientButton bCreateRevenueReport;
        private Guna.UI2.WinForms.Guna2GradientButton bCreateMedicineUseReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLe;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbYear;
        private Guna.UI2.WinForms.Guna2TextBox tbMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}