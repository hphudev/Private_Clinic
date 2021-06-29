using System;
using System.Windows.Forms;

namespace GUI
{
    public abstract class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCreateImportedMedicineSlip(null));
        }
    }
}