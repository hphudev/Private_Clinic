
namespace GUI
{
    partial class FormReportInvolke
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
            this.crvInvolke = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvInvolke
            // 
            this.crvInvolke.ActiveViewIndex = -1;
            this.crvInvolke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInvolke.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInvolke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInvolke.Location = new System.Drawing.Point(0, 0);
            this.crvInvolke.Name = "crvInvolke";
            this.crvInvolke.Size = new System.Drawing.Size(800, 450);
            this.crvInvolke.TabIndex = 0;
            // 
            // FormReportInvolke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvInvolke);
            this.Name = "FormReportInvolke";
            this.Text = "FormReportInvolke";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInvolke;
    }
}