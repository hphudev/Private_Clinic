
namespace GUI
{
    partial class FormReportPatientLookup
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
            this.crvPatient = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvPatient
            // 
            this.crvPatient.ActiveViewIndex = -1;
            this.crvPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPatient.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPatient.Location = new System.Drawing.Point(0, 0);
            this.crvPatient.Name = "crvPatient";
            this.crvPatient.Size = new System.Drawing.Size(852, 743);
            this.crvPatient.TabIndex = 0;
            // 
            // FormReportPatientLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 743);
            this.Controls.Add(this.crvPatient);
            this.Name = "FormReportPatientLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportPatient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPatient;
    }
}