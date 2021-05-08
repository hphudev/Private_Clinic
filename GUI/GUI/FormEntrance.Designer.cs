
namespace GUI
{
    partial class FormEntrance
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
            this.bCloseForm = new System.Windows.Forms.Button();
            this.pFormShow = new System.Windows.Forms.Panel();
            this.bShowLogin = new System.Windows.Forms.Button();
            this.bShowRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // bCloseForm
            // 
            this.bCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
            this.bCloseForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.bCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCloseForm.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCloseForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bCloseForm.Location = new System.Drawing.Point(1139, 12);
            this.bCloseForm.Name = "bCloseForm";
            this.bCloseForm.Size = new System.Drawing.Size(32, 32);
            this.bCloseForm.TabIndex = 5;
            this.bCloseForm.Text = "X";
            this.bCloseForm.UseVisualStyleBackColor = false;
            // 
            // pFormShow
            // 
            this.pFormShow.BackColor = System.Drawing.Color.White;
            this.pFormShow.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pFormShow.Location = new System.Drawing.Point(115, 147);
            this.pFormShow.Name = "pFormShow";
            this.pFormShow.Size = new System.Drawing.Size(961, 501);
            this.pFormShow.TabIndex = 4;
            // 
            // bShowLogin
            // 
            this.bShowLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.bShowLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.bShowLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bShowLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShowLogin.ForeColor = System.Drawing.Color.White;
            this.bShowLogin.Location = new System.Drawing.Point(115, 96);
            this.bShowLogin.Name = "bShowLogin";
            this.bShowLogin.Size = new System.Drawing.Size(133, 45);
            this.bShowLogin.TabIndex = 0;
            this.bShowLogin.Text = "ĐĂNG NHẬP";
            this.bShowLogin.UseVisualStyleBackColor = false;
            // 
            // bShowRegister
            // 
            this.bShowRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.bShowRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.bShowRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bShowRegister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShowRegister.ForeColor = System.Drawing.Color.White;
            this.bShowRegister.Location = new System.Drawing.Point(254, 96);
            this.bShowRegister.Name = "bShowRegister";
            this.bShowRegister.Size = new System.Drawing.Size(133, 45);
            this.bShowRegister.TabIndex = 1;
            this.bShowRegister.Text = "ĐĂNG KÝ";
            this.bShowRegister.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(705, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÝ PHÒNG MẠCH";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 696);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1185, 12);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Visible = false;
            // 
            // FormEntrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::GUI.Properties.Resources.backfround_61;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 708);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bShowRegister);
            this.Controls.Add(this.bShowLogin);
            this.Controls.Add(this.bCloseForm);
            this.Controls.Add(this.pFormShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEntrance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCloseForm;
        private System.Windows.Forms.Panel pFormShow;
        private System.Windows.Forms.Button bShowLogin;
        private System.Windows.Forms.Button bShowRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}