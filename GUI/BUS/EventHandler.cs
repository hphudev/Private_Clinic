using System;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BUS
{
    public abstract class EventHandler : Handler
    {
        public static Image openEye = null;
        public static Image closeEye = null;
        public static Form formBackground = null;

        #region Thư viện Custom Drag Bar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        #region Hiển thị form với hiệu ứng Opacity
        public static void ShowFormEffect(Form form, int interval)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            form.Opacity = 0;
            timer.Interval = interval;
            timer.Tick += (s, e) =>
            {
                if (form.Opacity < 1)
                {
                    form.Opacity += 0.05;
                }
                else
                {
                    timer.Stop();
                }
            };
            form.Show();
            timer.Start();
        }
        #endregion

        #region Ẩn form với hiệu ứng Opacity
        public static void HideFormEffect(Form form, int timer_para, bool doClose)
        {
            form.Hide();
            form.Opacity = 1;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = timer_para;
            timer.Tick += (s, e) =>
            {
                if (form.Opacity > 0)
                {
                    form.Opacity -= 0.2;
                }
                else
                {
                    if (!doClose)
                        form.Hide();
                    else
                        form.Close();
                    timer.Stop();
                }
            };
            timer.Start();
        }
        #endregion

        #region Hiễn thị form con và ẩn form cha
        static public void ShowChildForm_HideParentForm(Form child, Form parent)
        {
            HideFormEffect(parent, 1, false);
            ShowFormEffect(child, 1);
        }
        #endregion

        #region Đóng form con và hiển thị form cha
        static public void CloseChildForm_ShowParentForm(Form child, Form parent)
        {
            HideFormEffect(child, 1, true);
            ShowFormEffect(parent, 1);
        }
        #endregion

        #region Đóng băng form
        static public async Task FreezeForm(int time)
        {
            await Task.Factory.StartNew(() =>
            {
                Thread.Sleep(time);
            });
        }
        #endregion

        #region Ẩn văn bản chỉ thị khi EnterEvent
        static public void Enter_HintText(TextBox textBox, string hintText, bool Eye = true)
        {
            textBox.ForeColor = Color.Black;
            if (textBox.Text == hintText)
            {
                textBox.Text = "";
                textBox.UseSystemPasswordChar = (Eye == false);
            }
        }
        #endregion

        #region Hiển thị văn bản chỉ thị khi LeaveEvent
        static public void Leave_HintText(TextBox textBox, string hintText, bool Eye = true)
        {
            textBox.ForeColor = Color.DarkGray;
            if (textBox.Text == "")
            {
                textBox.UseSystemPasswordChar = false;
                textBox.Text = hintText;
            }
            else
            {
                textBox.ForeColor = Color.Black;
                textBox.UseSystemPasswordChar = (Eye == false);
            }
        }
        #endregion

        #region Sự kiện Mousedown DragBar
        public static void MouseDown_DragBar(Form form)
        {
            ReleaseCapture();
            SendMessage(form.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Ẩn ký tự Password từ Textbox
        public static void HintPassword(TextBox textBox, PictureBox pictureBox, bool Eye, bool isHint)
        {
            textBox.UseSystemPasswordChar = (Eye == false) && (isHint);
            pictureBox.Image = (Eye) ? openEye : closeEye;
        }
        #endregion

        #region Đổi màu văn bản khi đưa chuột vào Button
        static public void MouseEnterChangeForeColor(object s, EventArgs e)
        {
            Button button = (Button)s;
            button.ForeColor = Color.FromArgb(178, 34, 34);
        }
        #endregion

        #region Đổi màu văn bản khi đưa chuột vào Button
        static public void MouseLeaveChangeForeColor(object s, EventArgs e)
        {
            Button button = (Button)s;
            button.ForeColor = Color.White;
        }
        #endregion

        static public void ShowFormBackground(Form parent, Form formBackground)
        {
            if (formBackground == null)
            {
                formBackground = new Form();
            }
            formBackground.StartPosition = FormStartPosition.Manual;
            formBackground.FormBorderStyle = FormBorderStyle.None;
            formBackground.Opacity = 0.50d;
            formBackground.BackColor = Color.Black;
            formBackground.WindowState = FormWindowState.Maximized;
            formBackground.TopMost = true;
            formBackground.Location = parent.Location;
            formBackground.ShowInTaskbar = false;
            formBackground.Show();
            parent.Owner = formBackground;
        }

        static public void CloseFormBackground(Form formBackground)
        {
            if (formBackground != null)
                formBackground.Dispose();
        }

        static public void ShowFormDialog(Form main)
        {
            if (main != null)
            {
                Form formBackground = new Form();
                ShowFormBackground(main, formBackground);
                main.TopMost = true;
                main.ShowDialog();
                CloseFormBackground(formBackground);
            }
        }
    }
}
