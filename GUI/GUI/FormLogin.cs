using GUI.Properties;
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
    public partial class FormLogin : Form
    {
        private string tbUser_hint = "Tên đăng nhập";
        private string tbPassword_hint = "Mật khẩu";
        private bool eye = false;

        public FormLogin()
        {
            InitializeComponent();
            Init_HintText();
            Init_HintPassword();
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
            this.tbUser.Enter += (s, e) =>
            {
                BUS.Event.Enter_HintText(this.tbUser, tbUser_hint);
            };
            this.tbUser.Leave += (s, e) =>
            {
                BUS.Event.Leave_HintText(this.tbUser, tbUser_hint);
            };
            this.tbPassword.Enter += (s, e) =>
            {
                BUS.Event.Enter_HintText(this.tbPassword, tbPassword_hint, eye);
            };
            this.tbPassword.Leave += (s, e) =>
            {
                BUS.Event.Leave_HintText(this.tbPassword, tbPassword_hint, eye);
            };

        }

    }
}
