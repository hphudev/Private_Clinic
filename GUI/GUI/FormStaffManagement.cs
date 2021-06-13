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
    public partial class FormStaffManagement : Form
    {
        FormMain parent;
        public FormStaffManagement(FormMain parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.FormClosed += onFormClosed;
        }

        private void onFormClosed(object s, FormClosedEventArgs e)
        {
            BUS.EventHandler.ShowFormEffect(parent, 1);
        }
    }
}
