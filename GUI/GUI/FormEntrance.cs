using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormEntrance : Form
    {
        private Form FormChoice = null;
        private FormSplash FormParent = null;

        public FormEntrance(FormSplash formSplash)
        {
            InitializeComponent();
            this.FormParent = formSplash;
            this.MouseDown += (s, e) =>
            {
                BUS.Event.MouseDown_DragBar(this);
            };
            this.Load += LoadForm;
            Init_TabForm();
        }

        private void Init_TabForm()
        {
            bShowLogin.Click += ClickedShowFormLogin;
            bShowRegister.Click += ClickedShowFormRegister;
        }

        private void LoadForm(object s, EventArgs e)
        {
            ClickedShowFormLogin(this, new EventArgs());
        }

        private void ClickedShowFormLogin(Object s, EventArgs e)
        {
            if (bShowLogin.BackColor.Equals(Color.FromArgb(3, 155, 229)))
            {
                return;
            }
            bShowRegister.BackColor = Color.FromArgb(2, 119, 189);
            bShowLogin.BackColor = Color.FromArgb(3, 155, 229);
            pFormShow.Controls.Clear();
            FormChoice = new FormLogin() { TopLevel = false, TopMost = true };
            pFormShow.Controls.Add(FormChoice);
            FormChoice.Show();
        }

        private void ClickedShowFormRegister(Object s, EventArgs e)
        {
            if (bShowRegister.BackColor.Equals(Color.FromArgb(3, 155, 229)))
            {
                return;
            }
            bShowLogin.BackColor = Color.FromArgb(2, 119, 189);
            bShowRegister.BackColor = Color.FromArgb(3, 155, 229);
            pFormShow.Controls.Clear();
            FormChoice = new FormRegister() { TopLevel = false, TopMost = true };
            pFormShow.Controls.Add(FormChoice);
            FormChoice.Show();
        }
    }
}
