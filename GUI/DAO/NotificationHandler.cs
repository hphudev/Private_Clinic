using System.Windows.Forms;

namespace DAO
{
    public abstract class NotificationHandler : Handler
    {
        public static void NotifyError(string content)
        {
            MessageBox.Show(content + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}