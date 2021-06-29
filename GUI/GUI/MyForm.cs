using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class MyForm : Form
    {
        protected FormMain parent;

        public MyForm()
        {
            InitializeComponent();
        }

        protected void LockInputNumber(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception)
            {

            }
        }

        protected void LockInputWord(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception)
            {

            }
        }

        protected virtual void AddEventHandler()
        {
            this.FormClosed += ShowParentForm;
        }

        private void ShowParentForm(object sender, FormClosedEventArgs e)
        {
            BUS.EventHandler.ShowFormEffect(parent, 1);
        }

        protected void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}