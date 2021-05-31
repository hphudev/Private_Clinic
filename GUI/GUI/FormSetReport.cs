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
    public partial class FormSetReport : Form
    {
        FormMain parent;
        public FormSetReport(FormMain parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.FormClosed += onFormClosed;
        }

        private void onFormClosed(object s, FormClosedEventArgs e)
        {
            BUS.Event.ShowFormEffect(parent, 1);
        }
    }
}
