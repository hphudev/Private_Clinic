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
    public partial class FormMedicalExaminationList : Form
    {
        FormMain parent;
        public FormMedicalExaminationList(FormMain parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.FormClosed += onFormClosed;
            this.bAddPatient.Click += (s, e) =>
            {
                FormAddPatient formAddPatient = new FormAddPatient();
                formAddPatient.ShowDialog();
            };
        }

        private void onFormClosed(object s, FormClosedEventArgs e)
        {
            BUS.Event.ShowFormEffect(parent, 1);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
