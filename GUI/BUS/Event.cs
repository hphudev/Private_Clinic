﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.InteropServices;

namespace BUS
{
    public static class Event
    {
        public static Image openEye = null;
        public static Image closeEye = null;

        #region Thư viện Custom Drag Bar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        #region Hiển thị form với hiệu ứng Opacity
        public static void ShowFormEffect(Form form, int timer_para)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            form.Opacity = 0;
            timer.Interval = timer_para;
            timer.Tick += (s, e) =>
            {
                if (form.Opacity < 1)
                {
                    form.Opacity += 0.1;
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
            form.Opacity = 1;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = timer_para;
            timer.Tick += (s, e) =>
            {
                if (form.Opacity > 0)
                {
                    form.Opacity -= 0.1;
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
            ShowFormEffect(child, 1);
            HideFormEffect(parent, 1, false);
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

    }
}
