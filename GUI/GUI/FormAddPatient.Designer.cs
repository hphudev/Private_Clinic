
namespace GUI
{
    partial class FormAddPatient
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
            this.pDragBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.bCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbSex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpDate = new ns1.BunifuDatepicker();
            this.bSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bRefresh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.pDragBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDragBar
            // 
            this.pDragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(134)))));
            this.pDragBar.Controls.Add(this.bCancel);
            this.pDragBar.Controls.Add(this.label1);
            this.pDragBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDragBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.pDragBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.pDragBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pDragBar.Location = new System.Drawing.Point(0, 0);
            this.pDragBar.Name = "pDragBar";
            this.pDragBar.ShadowDecoration.Parent = this.pDragBar;
            this.pDragBar.Size = new System.Drawing.Size(563, 83);
            this.pDragBar.TabIndex = 0;
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
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.HoverState.Parent = this.bCancel;
            this.bCancel.Location = new System.Drawing.Point(483, 12);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(68, 36);
            this.bCancel.TabIndex = 114;
            this.bCancel.Text = "THOÁT";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 83);
            this.label1.TabIndex = 113;
            this.label1.Text = "THÊM BỆNH NHÂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.label5.Location = new System.Drawing.Point(11, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.label4.Location = new System.Drawing.Point(11, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.label3.Location = new System.Drawing.Point(9, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.label2.Location = new System.Drawing.Point(9, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Họ và tên:";
            // 
            // tbName
            // 
            this.tbName.AutoSize = true;
            this.tbName.BorderRadius = 6;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.Parent = this.tbName;
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.FocusedState.Parent = this.tbName;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.HoverState.Parent = this.tbName;
            this.tbName.Location = new System.Drawing.Point(157, 133);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderText = "";
            this.tbName.SelectedText = "";
            this.tbName.ShadowDecoration.Parent = this.tbName;
            this.tbName.Size = new System.Drawing.Size(382, 43);
            this.tbName.TabIndex = 20;
            // 
            // cbSex
            // 
            this.cbSex.BackColor = System.Drawing.Color.Transparent;
            this.cbSex.BorderRadius = 6;
            this.cbSex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FocusedColor = System.Drawing.Color.Empty;
            this.cbSex.FocusedState.Parent = this.cbSex;
            this.cbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSex.ForeColor = System.Drawing.Color.Black;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.HoverState.Parent = this.cbSex;
            this.cbSex.ItemHeight = 30;
            this.cbSex.ItemsAppearance.Parent = this.cbSex;
            this.cbSex.Location = new System.Drawing.Point(157, 195);
            this.cbSex.Name = "cbSex";
            this.cbSex.ShadowDecoration.Parent = this.cbSex;
            this.cbSex.Size = new System.Drawing.Size(155, 36);
            this.cbSex.Sorted = true;
            this.cbSex.StartIndex = 0;
            this.cbSex.TabIndex = 21;
            // 
            // dtpDate
            // 
            this.dtpDate.BackColor = System.Drawing.Color.White;
            this.dtpDate.BorderRadius = 6;
            this.dtpDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.ForeColor = System.Drawing.Color.Black;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.FormatCustom = "dd/mm/yyyy";
            this.dtpDate.Location = new System.Drawing.Point(157, 255);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(382, 42);
            this.dtpDate.TabIndex = 22;
            this.dtpDate.Value = new System.DateTime(2021, 6, 6, 11, 44, 35, 994);
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Animated = true;
            this.bSave.BackColor = System.Drawing.Color.Transparent;
            this.bSave.BorderRadius = 6;
            this.bSave.CheckedState.Parent = this.bSave;
            this.bSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSave.CustomImages.Parent = this.bSave;
            this.bSave.FillColor = System.Drawing.Color.Ivory;
            this.bSave.FillColor2 = System.Drawing.Color.Ivory;
            this.bSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bSave.HoverState.Parent = this.bSave;
            this.bSave.Location = new System.Drawing.Point(421, 394);
            this.bSave.Name = "bSave";
            this.bSave.ShadowDecoration.Parent = this.bSave;
            this.bSave.Size = new System.Drawing.Size(118, 47);
            this.bSave.TabIndex = 115;
            this.bSave.Text = "Lưu lại";
            // 
            // bRefresh
            // 
            this.bRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRefresh.Animated = true;
            this.bRefresh.BackColor = System.Drawing.Color.Transparent;
            this.bRefresh.BorderRadius = 6;
            this.bRefresh.CheckedState.Parent = this.bRefresh;
            this.bRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRefresh.CustomImages.Parent = this.bRefresh;
            this.bRefresh.FillColor = System.Drawing.Color.Ivory;
            this.bRefresh.FillColor2 = System.Drawing.Color.Ivory;
            this.bRefresh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.bRefresh.HoverState.Parent = this.bRefresh;
            this.bRefresh.Location = new System.Drawing.Point(280, 394);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.ShadowDecoration.Parent = this.bRefresh;
            this.bRefresh.Size = new System.Drawing.Size(124, 47);
            this.bRefresh.TabIndex = 116;
            this.bRefresh.Text = "Làm mới";
            // 
            // tbAddress
            // 
            this.tbAddress.AutoSize = true;
            this.tbAddress.BorderRadius = 6;
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.DefaultText = "";
            this.tbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAddress.DisabledState.Parent = this.tbAddress;
            this.tbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddress.FocusedState.Parent = this.tbAddress;
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.ForeColor = System.Drawing.Color.Black;
            this.tbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddress.HoverState.Parent = this.tbAddress;
            this.tbAddress.Location = new System.Drawing.Point(157, 315);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PasswordChar = '\0';
            this.tbAddress.PlaceholderText = "";
            this.tbAddress.SelectedText = "";
            this.tbAddress.ShadowDecoration.Parent = this.tbAddress;
            this.tbAddress.Size = new System.Drawing.Size(382, 43);
            this.tbAddress.TabIndex = 117;
            // 
            // FormAddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(563, 464);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pDragBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddPatient";
            this.Load += new System.EventHandler(this.FormAddPatient_Load);
            this.pDragBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton bCancel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private ns1.BunifuDatepicker dtpDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbSex;
        private Guna.UI2.WinForms.Guna2TextBox tbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton bSave;
        private Guna.UI2.WinForms.Guna2GradientButton bRefresh;
        private Guna.UI2.WinForms.Guna2TextBox tbAddress;
        private Guna.UI2.WinForms.Guna2GradientPanel pDragBar;
    }
}