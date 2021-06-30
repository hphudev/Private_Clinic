
namespace GUI
{
    partial class FormAddUseWay
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
            this.label1 = new System.Windows.Forms.Label();
            this.pDragBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.bCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tbUseWayName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bRefresh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pDragBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 82);
            this.label1.TabIndex = 113;
            this.label1.Text = "THÊM CÁCH DÙNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pDragBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pDragBar.Name = "pDragBar";
            this.pDragBar.ShadowDecoration.Parent = this.pDragBar;
            this.pDragBar.Size = new System.Drawing.Size(619, 82);
            this.pDragBar.TabIndex = 133;
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
            this.bCancel.Location = new System.Drawing.Point(539, 12);
            this.bCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(68, 36);
            this.bCancel.TabIndex = 114;
            this.bCancel.Text = "THOÁT";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // tbUseWayName
            // 
            this.tbUseWayName.AutoSize = true;
            this.tbUseWayName.BorderRadius = 6;
            this.tbUseWayName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUseWayName.DefaultText = "";
            this.tbUseWayName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUseWayName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUseWayName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUseWayName.DisabledState.Parent = this.tbUseWayName;
            this.tbUseWayName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUseWayName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUseWayName.FocusedState.Parent = this.tbUseWayName;
            this.tbUseWayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUseWayName.ForeColor = System.Drawing.Color.Black;
            this.tbUseWayName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUseWayName.HoverState.Parent = this.tbUseWayName;
            this.tbUseWayName.Location = new System.Drawing.Point(205, 121);
            this.tbUseWayName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbUseWayName.Name = "tbUseWayName";
            this.tbUseWayName.PasswordChar = '\0';
            this.tbUseWayName.PlaceholderText = "";
            this.tbUseWayName.SelectedText = "";
            this.tbUseWayName.ShadowDecoration.Parent = this.tbUseWayName;
            this.tbUseWayName.Size = new System.Drawing.Size(381, 43);
            this.tbUseWayName.TabIndex = 135;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(126)))), ((int)(((byte)(186)))));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 134;
            this.label2.Text = "Tên cách dùng:";
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
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
            this.bRefresh.Location = new System.Drawing.Point(326, 194);
            this.bRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.ShadowDecoration.Parent = this.bRefresh;
            this.bRefresh.Size = new System.Drawing.Size(124, 47);
            this.bRefresh.TabIndex = 137;
            this.bRefresh.Text = "Làm mới";
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
            this.bSave.Location = new System.Drawing.Point(469, 194);
            this.bSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSave.Name = "bSave";
            this.bSave.ShadowDecoration.Parent = this.bSave;
            this.bSave.Size = new System.Drawing.Size(117, 47);
            this.bSave.TabIndex = 136;
            this.bSave.Text = "Lưu lại";
            // 
            // FormAddUseWay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(619, 267);
            this.Controls.Add(this.pDragBar);
            this.Controls.Add(this.tbUseWayName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.bSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddUseWay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddUsing";
            this.pDragBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel pDragBar;
        private Guna.UI2.WinForms.Guna2GradientButton bCancel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox tbUseWayName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2GradientButton bRefresh;
        private Guna.UI2.WinForms.Guna2GradientButton bSave;
    }
}