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
    public partial class FormAddTypeSickPhu : Form
    {
        public FormAddTypeSickPhu(string TypeName)
        {
            InitializeComponent();
            this.tbSickName.Text = TypeName;
            this.bSave.Click += bSaveClicked;
            this.bCancel.Click += bCancelClicked;
            this.bRefresh.Click += bRefreshClicked;
            this.KeyPreview = true;
            this.KeyDown += thisKeyDown;
        }

        private void thisKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bSaveClicked(this, new EventArgs());
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bRefreshClicked(object sender, EventArgs e)
        {
            this.tbSickName.Text = "";
        }

        private void bCancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void bSaveClicked(object sender, EventArgs e)
        {
            if (this.tbSickName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên bệnh!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool check = await BUS.FormAddTypeSickBUS.CheckExistTypeSick(this.tbSickName.Text);
            if (!check)
            {
                int count = await BUS.FormAddTypeSickBUS.CountTypeSick() + 1;
                TypeSick typeSick = new TypeSick(
                    BUS.Support.IdAdapter("B", count, 2),
                    this.tbSickName.Text);
                BUS.FormAddTypeSickBUS.AddTypeSick(typeSick);
                MessageBox.Show("Lưu loại bệnh thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Loại bệnh này đang tồn tại!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPredict_Load(object sender, EventArgs e)
        {

        }


    }
}
