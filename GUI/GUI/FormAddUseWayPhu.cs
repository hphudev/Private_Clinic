using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUI
{
    public partial class FormAddUseWayPhu : Form
    {
        public FormAddUseWayPhu(string content)
        {
            InitializeComponent();
            this.tbUseWayName.Text = content;
            this.bCancel.Click += bCancelClicked;
            this.bRefresh.Click += bRefreshClicked;
            this.bSave.Click += bSaveClicked;
        }

        private async void bSaveClicked(object sender, EventArgs e)
        {
            UseWayPhu useWay = await BUS.FormAddUseWayBUS.GetUseWay(this.tbUseWayName.Text);
            if (useWay == null)
            {
                if (this.tbUseWayName.Text == "")
                {
                    MessageBox.Show("Tên cách dùng mới rỗng!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                useWay = new UseWayPhu(
                    "",
                    this.tbUseWayName.Text);
                BUS.FormAddUseWayBUS.AddUseWay(useWay);
                MessageBox.Show("Lưu cách dùng thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cách dùng này đang tồn tại!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bRefreshClicked(object sender, EventArgs e)
        {
            this.tbUseWayName.Text = "";
        }

        private void bCancelClicked(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
