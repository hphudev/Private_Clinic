using System;
using System.Windows.Forms;
using DAO;
using Guna.UI2.WinForms;

namespace BUS
{
    public abstract class Handler
    {
        public static bool CheckInput(object sender, string name, int minValue = 0)
        {
            try
            {
                string s = " phải lớn hơn ";

                if (int.Parse(((Guna2TextBox)sender).Text) <= minValue)
                {
                    if (minValue != 0)
                    {
                        s += "hoặc bằng ";
                        minValue++;
                    }

                    NotificationHandler.NotifyError(name + s + minValue);

                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                NotificationHandler.NotifyError(name + " không được phép bỏ trống");

                return false;
            }
        }
    }
}