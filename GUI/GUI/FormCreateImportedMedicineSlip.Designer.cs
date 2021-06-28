﻿
namespace GUI
{
    partial class FormCreateImportedMedicineSlip
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMedicineList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLeTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bReturn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRationToCalculateSellableUnitPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbSellableUnitPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.bReset = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbImportedUnitPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbQuantityOfInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.bAddUnit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.bCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dgvMedicineList);
            this.panel4.Location = new System.Drawing.Point(34, 482);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1863, 409);
            this.panel4.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 139;
            this.label1.Text = "Danh sách nhập thuốc";
            // 
            // dgvMedicineList
            // 
            this.dgvMedicineList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicineList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicineList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicineList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicineList.ColumnHeadersHeight = 29;
            this.dgvMedicineList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MaThuoc,
            this.TenThuoc,
            this.DonViTinh,
            this.SoLuong,
            this.DonGiaNhap,
            this.DonGiaBan,
            this.TyLeTinh});
            this.dgvMedicineList.EnableHeadersVisualStyles = false;
            this.dgvMedicineList.Location = new System.Drawing.Point(8, 46);
            this.dgvMedicineList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMedicineList.Name = "dgvMedicineList";
            this.dgvMedicineList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMedicineList.RowHeadersWidth = 51;
            this.dgvMedicineList.RowTemplate.Height = 24;
            this.dgvMedicineList.Size = new System.Drawing.Size(1836, 346);
            this.dgvMedicineList.TabIndex = 1;
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
            // MaThuoc
            // 
            this.MaThuoc.HeaderText = "Mã thuốc";
            this.MaThuoc.MinimumWidth = 6;
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.ReadOnly = true;
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
            // DonGiaNhap
            // 
            this.DonGiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DonGiaNhap.HeaderText = "Đơn giá nhập";
            this.DonGiaNhap.MinimumWidth = 6;
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.ReadOnly = true;
            this.DonGiaNhap.Width = 164;
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.HeaderText = "Đơn giá bán";
            this.DonGiaBan.MinimumWidth = 6;
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.ReadOnly = true;
            // 
            // TyLeTinh
            // 
            this.TyLeTinh.HeaderText = "Tỷ lệ tính đơn giá bán";
            this.TyLeTinh.MinimumWidth = 6;
            this.TyLeTinh.Name = "TyLeTinh";
            this.TyLeTinh.ReadOnly = true;
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
            this.bReturn.Location = new System.Drawing.Point(1777, 4);
            this.bReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(137, 79);
            this.bReturn.TabIndex = 29;
            this.bReturn.Text = "QUAY LẠI";
            this.bReturn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(34, 213);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 261);
            this.panel1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRationToCalculateSellableUnitPrice);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.bAdd);
            this.groupBox1.Controls.Add(this.tbSellableUnitPrice);
            this.groupBox1.Controls.Add(this.bReset);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbImportedUnitPrice);
            this.groupBox1.Controls.Add(this.tbQuantityOfInput);
            this.groupBox1.Controls.Add(this.cbUnit);
            this.groupBox1.Controls.Add(this.bAddUnit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.Ivory;
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thuốc";
            // 
            // tbRationToCalculateSellableUnitPrice
            // 
            this.tbRationToCalculateSellableUnitPrice.AutoSize = true;
            this.tbRationToCalculateSellableUnitPrice.BorderRadius = 6;
            this.tbRationToCalculateSellableUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRationToCalculateSellableUnitPrice.DefaultText = "";
            this.tbRationToCalculateSellableUnitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbRationToCalculateSellableUnitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbRationToCalculateSellableUnitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRationToCalculateSellableUnitPrice.DisabledState.Parent = this.tbRationToCalculateSellableUnitPrice;
            this.tbRationToCalculateSellableUnitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRationToCalculateSellableUnitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRationToCalculateSellableUnitPrice.FocusedState.Parent = this.tbRationToCalculateSellableUnitPrice;
            this.tbRationToCalculateSellableUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRationToCalculateSellableUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.tbRationToCalculateSellableUnitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRationToCalculateSellableUnitPrice.HoverState.Parent = this.tbRationToCalculateSellableUnitPrice;
            this.tbRationToCalculateSellableUnitPrice.Location = new System.Drawing.Point(649, 174);
            this.tbRationToCalculateSellableUnitPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbRationToCalculateSellableUnitPrice.Name = "tbRationToCalculateSellableUnitPrice";
            this.tbRationToCalculateSellableUnitPrice.PasswordChar = '\0';
            this.tbRationToCalculateSellableUnitPrice.PlaceholderText = "";
            this.tbRationToCalculateSellableUnitPrice.SelectedText = "";
            this.tbRationToCalculateSellableUnitPrice.ShadowDecoration.Parent = this.tbRationToCalculateSellableUnitPrice;
            this.tbRationToCalculateSellableUnitPrice.Size = new System.Drawing.Size(153, 43);
            this.tbRationToCalculateSellableUnitPrice.TabIndex = 148;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Honeydew;
            this.label9.Location = new System.Drawing.Point(362, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 26);
            this.label9.TabIndex = 147;
            this.label9.Text = "Tỷ lệ tính đơn giá bán:";
            // 
            // bAdd
            // 
            this.bAdd.Animated = true;
            this.bAdd.BackColor = System.Drawing.Color.Transparent;
            this.bAdd.BorderRadius = 6;
            this.bAdd.CheckedState.Parent = this.bAdd;
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAdd.CustomImages.Parent = this.bAdd;
            this.bAdd.FillColor = System.Drawing.Color.Ivory;
            this.bAdd.FillColor2 = System.Drawing.Color.Ivory;
            this.bAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bAdd.HoverState.Parent = this.bAdd;
            this.bAdd.Location = new System.Drawing.Point(668, 71);
            this.bAdd.Name = "bAdd";
            this.bAdd.ShadowDecoration.Parent = this.bAdd;
            this.bAdd.Size = new System.Drawing.Size(134, 37);
            this.bAdd.TabIndex = 143;
            this.bAdd.Text = "Lưu";
            // 
            // tbSellableUnitPrice
            // 
            this.tbSellableUnitPrice.AutoSize = true;
            this.tbSellableUnitPrice.BorderRadius = 6;
            this.tbSellableUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSellableUnitPrice.DefaultText = "";
            this.tbSellableUnitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSellableUnitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSellableUnitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSellableUnitPrice.DisabledState.Parent = this.tbSellableUnitPrice;
            this.tbSellableUnitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSellableUnitPrice.Enabled = false;
            this.tbSellableUnitPrice.FillColor = System.Drawing.Color.Gainsboro;
            this.tbSellableUnitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSellableUnitPrice.FocusedState.Parent = this.tbSellableUnitPrice;
            this.tbSellableUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSellableUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.tbSellableUnitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSellableUnitPrice.HoverState.Parent = this.tbSellableUnitPrice;
            this.tbSellableUnitPrice.Location = new System.Drawing.Point(649, 122);
            this.tbSellableUnitPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbSellableUnitPrice.Name = "tbSellableUnitPrice";
            this.tbSellableUnitPrice.PasswordChar = '\0';
            this.tbSellableUnitPrice.PlaceholderText = "";
            this.tbSellableUnitPrice.SelectedText = "";
            this.tbSellableUnitPrice.ShadowDecoration.Parent = this.tbSellableUnitPrice;
            this.tbSellableUnitPrice.Size = new System.Drawing.Size(153, 43);
            this.tbSellableUnitPrice.TabIndex = 146;
            // 
            // bReset
            // 
            this.bReset.Animated = true;
            this.bReset.BackColor = System.Drawing.Color.Transparent;
            this.bReset.BorderRadius = 6;
            this.bReset.CheckedState.Parent = this.bReset;
            this.bReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bReset.CustomImages.Parent = this.bReset;
            this.bReset.FillColor = System.Drawing.Color.Ivory;
            this.bReset.FillColor2 = System.Drawing.Color.Ivory;
            this.bReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bReset.HoverState.Parent = this.bReset;
            this.bReset.Location = new System.Drawing.Point(668, 24);
            this.bReset.Name = "bReset";
            this.bReset.ShadowDecoration.Parent = this.bReset;
            this.bReset.Size = new System.Drawing.Size(134, 37);
            this.bReset.TabIndex = 144;
            this.bReset.Text = "Làm mới";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Honeydew;
            this.label7.Location = new System.Drawing.Point(362, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 26);
            this.label7.TabIndex = 145;
            this.label7.Text = "Đơn giá bán:";
            // 
            // tbImportedUnitPrice
            // 
            this.tbImportedUnitPrice.AutoSize = true;
            this.tbImportedUnitPrice.BorderRadius = 6;
            this.tbImportedUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbImportedUnitPrice.DefaultText = "";
            this.tbImportedUnitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbImportedUnitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbImportedUnitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbImportedUnitPrice.DisabledState.Parent = this.tbImportedUnitPrice;
            this.tbImportedUnitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbImportedUnitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbImportedUnitPrice.FocusedState.Parent = this.tbImportedUnitPrice;
            this.tbImportedUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImportedUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.tbImportedUnitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbImportedUnitPrice.HoverState.Parent = this.tbImportedUnitPrice;
            this.tbImportedUnitPrice.Location = new System.Drawing.Point(186, 174);
            this.tbImportedUnitPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbImportedUnitPrice.Name = "tbImportedUnitPrice";
            this.tbImportedUnitPrice.PasswordChar = '\0';
            this.tbImportedUnitPrice.PlaceholderText = "";
            this.tbImportedUnitPrice.SelectedText = "";
            this.tbImportedUnitPrice.ShadowDecoration.Parent = this.tbImportedUnitPrice;
            this.tbImportedUnitPrice.Size = new System.Drawing.Size(153, 43);
            this.tbImportedUnitPrice.TabIndex = 141;
            // 
            // tbQuantityOfInput
            // 
            this.tbQuantityOfInput.AutoSize = true;
            this.tbQuantityOfInput.BorderRadius = 6;
            this.tbQuantityOfInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbQuantityOfInput.DefaultText = "";
            this.tbQuantityOfInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbQuantityOfInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbQuantityOfInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQuantityOfInput.DisabledState.Parent = this.tbQuantityOfInput;
            this.tbQuantityOfInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQuantityOfInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQuantityOfInput.FocusedState.Parent = this.tbQuantityOfInput;
            this.tbQuantityOfInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantityOfInput.ForeColor = System.Drawing.Color.Black;
            this.tbQuantityOfInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQuantityOfInput.HoverState.Parent = this.tbQuantityOfInput;
            this.tbQuantityOfInput.Location = new System.Drawing.Point(186, 122);
            this.tbQuantityOfInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbQuantityOfInput.Name = "tbQuantityOfInput";
            this.tbQuantityOfInput.PasswordChar = '\0';
            this.tbQuantityOfInput.PlaceholderText = "";
            this.tbQuantityOfInput.SelectedText = "";
            this.tbQuantityOfInput.ShadowDecoration.Parent = this.tbQuantityOfInput;
            this.tbQuantityOfInput.Size = new System.Drawing.Size(153, 43);
            this.tbQuantityOfInput.TabIndex = 140;
            // 
            // cbUnit
            // 
            this.cbUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(186, 76);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(153, 37);
            this.cbUnit.TabIndex = 139;
            // 
            // bAddUnit
            // 
            this.bAddUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bAddUnit.BackgroundImage = global::GUI.Properties.Resources.button_add1;
            this.bAddUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAddUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddUnit.FlatAppearance.BorderSize = 0;
            this.bAddUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddUnit.Location = new System.Drawing.Point(345, 75);
            this.bAddUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAddUnit.Name = "bAddUnit";
            this.bAddUnit.Size = new System.Drawing.Size(37, 36);
            this.bAddUnit.TabIndex = 56;
            this.bAddUnit.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(13, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 26);
            this.label5.TabIndex = 49;
            this.label5.Text = "Đơn giá nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 47;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 26);
            this.label3.TabIndex = 46;
            this.label3.Text = "Đơn vị tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tên thuốc:";
            // 
            // cbName
            // 
            this.cbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(186, 29);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(310, 37);
            this.cbName.TabIndex = 149;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel1.Controls.Add(this.bCancel);
            this.guna2GradientPanel1.Controls.Add(this.label14);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1924, 92);
            this.guna2GradientPanel1.TabIndex = 71;
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
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1924, 92);
            this.label14.TabIndex = 113;
            this.label14.Text = "LẬP PHIẾU NHẬP THUỐC";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 10;
            this.guna2Elipse3.TargetControl = this.panel4;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.cbUnit;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.cbName;
            // 
            // FormCreateImportedMedicineSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1924, 933);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCreateImportedMedicineSlip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCreateImportedMedicineSlip_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvMedicineList;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton bCancel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bAddUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUnit;
        private Guna.UI2.WinForms.Guna2TextBox tbImportedUnitPrice;
        private Guna.UI2.WinForms.Guna2TextBox tbQuantityOfInput;
        private Guna.UI2.WinForms.Guna2GradientButton bReset;
        private Guna.UI2.WinForms.Guna2GradientButton bAdd;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2TextBox tbRationToCalculateSellableUnitPrice;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox tbSellableUnitPrice;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLeTinh;
    }
}