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
    public partial class FormRegister : Form
    {

        private string tbUser_hint = "Tên đăng nhập";
        private string tbPassword_hint = "Mật khẩu";
        private string tbCard_hint = "Số chứng minh nhân dân";
        private string tbName_hint = "Họ và tên";
        private string tbEmail_hint = "Email";
        private string tbConfirmPassword_hint = "Xác nhận mật khẩu";
        private bool eye = false;
        private FormEntrance parent;

        public FormRegister(FormEntrance parent)
        {
            InitializeComponent();
            Init_HintText();
            Init_HintPassword();
            this.parent = parent;
        }

        private void Init_HintPassword()
        {
            this.pbEye.Click += (s, e) =>
            {
                eye = !eye;
                BUS.Event.HintPassword(this.tbPassword, this.pbEye, eye, !this.tbPassword.Text.Equals(tbPassword_hint));
            };
        }

        private void Init_HintText()
        {
            //1
            this.tbUser.Enter += (s, e) =>
            {
                BUS.Event.Enter_HintText(this.tbUser, tbUser_hint);
            };
            this.tbUser.Leave += (s, e) =>
            {
                BUS.Event.Leave_HintText(this.tbUser, tbUser_hint);
            };
            //2
            this.tbPassword.Enter += (s, e) =>
            {
                BUS.Event.Enter_HintText(this.tbPassword, tbPassword_hint, eye);
            };
            this.tbPassword.Leave += (s, e) =>
            {
                BUS.Event.Leave_HintText(this.tbPassword, tbPassword_hint, eye);
            };
            //3
            this.tbConfirmPassword.Enter += (s, e) =>
            {
                BUS.Event.Enter_HintText(this.tbConfirmPassword, tbConfirmPassword_hint, eye);
            };
            this.tbConfirmPassword.Leave += (s, e) =>
            {
                BUS.Event.Leave_HintText(this.tbConfirmPassword, tbConfirmPassword_hint, eye);
            };
            //4
            this.tbName.Enter += (s, e) =>
            {
                BUS.Event.Enter_HintText(this.tbName, tbName_hint);
            };
            this.tbName.Leave += (s, e) =>
            {
                BUS.Event.Leave_HintText(this.tbName, tbName_hint);
            };
            //5
            this.tbCard.Enter += (s, e) =>
            {
                BUS.Event.Enter_HintText(this.tbCard, tbCard_hint);
            };
            this.tbCard.Leave += (s, e) =>
            {
                BUS.Event.Leave_HintText(this.tbCard, tbCard_hint);
            };
            //6
            this.tbEmail.Enter += (s, e) =>
            {
                BUS.Event.Enter_HintText(this.tbEmail, tbEmail_hint);
            };
            this.tbEmail.Leave += (s, e) =>
            {
                BUS.Event.Leave_HintText(this.tbEmail, tbEmail_hint);
            };
            

        }

        private void bRegisterClicked(Object s, EventArgs e)
        {
            FormMain formMain = new FormMain();
            BUS.Event.ShowChildForm_HideParentForm(formMain, parent);
        }
    }
}
