using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormAddUseWay : Form
    {
        public FormAddUseWay()
        {
            InitializeComponent();
            this.pDragBar.MouseDown += (s, e) =>
            {
                BUS.Event.MouseDown_DragBar(this);
            };
            this.bCancel.Click += BCancel_Click;
            this.bSave.Click += BSave_Click;
            this.bRefresh.Click += BRefresh_Click;
        }

        private void BRefresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Insertuseway();
            }
            else
            {
                clear();
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            Insertuseway();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string  CheckNameUseWay()
        {
            try
            {
                string id = "";
                string name = tbUseWayName.Text;
                id = DAO.UseWay.Instance.GetIdUseWaybyname(name);
                if (id == null)
                {
                    id = "";
                }
                return id;
            }
            catch
            {
                return null;
            }
        }
        string CreateID()
        {
            string id = DAO.UseWay.Instance.get_IDMax();
            if (id != null)
            {
                id = id.Remove(0, 2);
                string stt = (Convert.ToInt32(id) + 1).ToString();

                id = "CD";
                for (int i = 0; i < 4 - 2 - stt.Length; i++)
                {
                    id = id + "0";
                }
                id = id + stt;
            }

            return id;
        }
        async void Insertuseway()
        {
            try
            {
                string id = CheckNameUseWay();
                if (id == null)
                {
                    MessageBox.Show("Lỗi kết nối: Không kiểm tra được thông tin cách dùng có trong hệ thống!");
                    return;
                }
                else if (id != "")
                {
                    MessageBox.Show("Thông tin cách dùng đã có trong hệ thống!");
                    return;
                }
                else
                {
                    SqlConnection connection = await Data.OpenConnection();

                    int socachdung = DAO.UseWay.Instance.get_usewaycount();

                    Data.CloseConnection(ref connection);

                    string name = tbUseWayName.Text;
                    
                    if (name == "" )
                    {
                        MessageBox.Show("Bạn cần phải nhập đầy đủ dữ liệu!");
                        return;
                    }
                    else
                    {
                        id = "";

                        if (socachdung > 0)
                        {

                            id = CreateID();

                            if (id == null)
                            {
                                MessageBox.Show("Không thể khỏi tạo mã do lỗi kết nối!");
                                return;
                            }
                            if (id.Length != 4)
                            {
                                MessageBox.Show("Lỗi hệ thống: Mã không hợp quy định!");
                                return;
                            }
                        }
                        else
                        {
                            id = "CD01";

                        }
                        DTO.UseWay useway = new DTO.UseWay(id, name);

                        DAO.UseWay.Instance.InsertUseway(useway);

                        MessageBox.Show("Đã nhập thành công bệnh nhân!");
                        if (insertUseway != null)
                        {
                            insertUseway(this, new Usewayevent(useway));
                        }
                    }
                }
                clear();
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!");
            }
        }
        void clear()
        {
            tbUseWayName.Text = "";
            
        }
        private event EventHandler<Usewayevent> insertUseway;
        public event EventHandler<Usewayevent> InsertUseway
        {
            add { insertUseway += value; }
            remove { insertUseway -= value; }
        }
    }
    public class Usewayevent : EventArgs
    {
        private DTO.UseWay useway;


        public Usewayevent(DTO.UseWay acc)
        {
            this.Useway = acc;
        }

        public DTO.UseWay Useway { get => useway; set => useway = value; }
    }
}
