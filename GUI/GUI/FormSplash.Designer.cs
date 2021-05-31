
namespace GUI
{
    partial class FormSplash
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
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.bReConnectServer = new System.Windows.Forms.Button();
            this.lRecommend = new System.Windows.Forms.Label();
            this.lDisconnecting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pBar
            // 
            this.pBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBar.Location = new System.Drawing.Point(0, 586);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(1181, 12);
            this.pBar.Step = 1;
            this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar.TabIndex = 0;
            this.pBar.Visible = false;
            // 
            // bReConnectServer
            // 
            this.bReConnectServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.bReConnectServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bReConnectServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.bReConnectServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReConnectServer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReConnectServer.ForeColor = System.Drawing.Color.White;
            this.bReConnectServer.Location = new System.Drawing.Point(524, 305);
            this.bReConnectServer.Name = "bReConnectServer";
            this.bReConnectServer.Size = new System.Drawing.Size(133, 45);
            this.bReConnectServer.TabIndex = 8;
            this.bReConnectServer.Text = "KẾT NỐI LẠI";
            this.bReConnectServer.UseVisualStyleBackColor = false;
            this.bReConnectServer.Visible = false;
            // 
            // lRecommend
            // 
            this.lRecommend.AutoSize = true;
            this.lRecommend.BackColor = System.Drawing.Color.Transparent;
            this.lRecommend.ForeColor = System.Drawing.Color.White;
            this.lRecommend.Location = new System.Drawing.Point(477, 356);
            this.lRecommend.Name = "lRecommend";
            this.lRecommend.Size = new System.Drawing.Size(241, 17);
            this.lRecommend.TabIndex = 9;
            this.lRecommend.Text = "Bạn có thể nhấn phím Esc để thoát...";
            this.lRecommend.Visible = false;
            // 
            // lDisconnecting
            // 
            this.lDisconnecting.AutoSize = true;
            this.lDisconnecting.BackColor = System.Drawing.Color.Transparent;
            this.lDisconnecting.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDisconnecting.ForeColor = System.Drawing.Color.Orange;
            this.lDisconnecting.Location = new System.Drawing.Point(539, 277);
            this.lDisconnecting.Name = "lDisconnecting";
            this.lDisconnecting.Size = new System.Drawing.Size(106, 20);
            this.lDisconnecting.TabIndex = 10;
            this.lDisconnecting.Text = "MẤT KẾT NỐI";
            this.lDisconnecting.Visible = false;
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.splash_screen_private_clinic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 598);
            this.Controls.Add(this.lDisconnecting);
            this.Controls.Add(this.lRecommend);
            this.Controls.Add(this.bReConnectServer);
            this.Controls.Add(this.pBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashSscreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Button bReConnectServer;
        private System.Windows.Forms.Label lRecommend;
        private System.Windows.Forms.Label lDisconnecting;
    }
}