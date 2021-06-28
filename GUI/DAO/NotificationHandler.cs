using System.Windows.Forms;

namespace DAO
{
    public abstract class NotificationHandler : Handler
    {
        public static void NotifyError(string content)
        {
            MessageBox.Show(content + ".", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void NotifyWarning(string content)
        {
            MessageBox.Show(content + "!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void NotifyInfo(string content)
        {
            MessageBox.Show(content + ".", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}