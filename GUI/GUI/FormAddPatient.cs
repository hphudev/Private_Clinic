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
    public partial class FormAddPatient : Form
    {
        public FormAddPatient()
        {
            InitializeComponent();
            this.pDragBar.MouseDown += (s, e) =>
            {
                BUS.Event.MouseDown_DragBar(this);
            };
            
        }

        private void FormAddPatient_Load(object sender, EventArgs e)
        {
            //Form form = this;
            //form.Hide();
        }
    }
}
