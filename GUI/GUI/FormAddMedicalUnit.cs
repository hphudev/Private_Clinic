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
    public partial class FormAddMedicalUnit : Form
    {
        public FormAddMedicalUnit()
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
                Insertunit();
            }
            else
            {
                clear();
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            Insertunit();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        string CheckNameMedicalUnit()
        {
            try
            {
                string id = "";
                string name = tbUnit.Text;
                id = DAO.MedicalUnit.Instance.GetIdMedicalUnitbyname(name);
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
            string id = DAO.MedicalUnit.Instance.get_IDMax();
            if (id != null)
            {
                id = id.Remove(0, 3);
                string stt = (Convert.ToInt32(id) + 1).ToString();

                id = "DVT";
                for (int i = 0; i < 5 - 3 - stt.Length; i++)
                {
                    id = id + "0";
                }
                id = id + stt;
            }

            return id;
        }
        async void Insertunit()
        {
            try
            {
                string id = CheckNameMedicalUnit();
                if (id == null)
                {
                    MessageBox.Show("Lỗi kết nối: Không kiểm tra được thông tin đơn vị tính có trong hệ thống!");
                    return;
                }
                else if (id != "")
                {
                    MessageBox.Show("Thông tin đơn vị tính đã có trong hệ thống!");
                    return;
                }
                else
                {
                    SqlConnection connection = await Data.OpenConnection();

                    int sodonvitinh = DAO.MedicalUnit.Instance.get_medicalunitcount();

                    Data.CloseConnection(ref connection);

                    string name = tbUnit.Text;

                    if (name == "")
                    {
                        MessageBox.Show("Bạn cần phải nhập đầy đủ dữ liệu!");
                        return;
                    }
                    else
                    {
                        id = "";

                        if (sodonvitinh > 0)
                        {

                            id = CreateID();

                            if (id == null)
                            {
                                MessageBox.Show("Không thể khỏi tạo mã do lỗi kết nối!");
                                return;
                            }
                            if (id.Length != 5)
                            {
                                MessageBox.Show("Lỗi hệ thống: Mã không hợp quy định!");
                                return;
                            }
                        }
                        else
                        {
                            id = "DVT01";

                        }
                        DTO.MedicalUnit unit = new DTO.MedicalUnit(id, name);

                        DAO.MedicalUnit.Instance.InsertMedicalUnit(unit);

                        MessageBox.Show("Đã nhập thành công bệnh nhân!");
                        if (insertUnit != null)
                        {
                            insertUnit(this, new Unitevent(unit));
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
            tbUnit.Text = "";

        }


        private event EventHandler<Unitevent> insertUnit;
        public event EventHandler<Unitevent> InsertUnit
        {
            add { insertUnit += value; }
            remove { insertUnit -= value; }
        }
    }
    public class Unitevent : EventArgs
    {
        private DTO.MedicalUnit unit;


        public Unitevent(DTO.MedicalUnit acc)
        {
            this.Unit = acc;
        }

        public DTO.MedicalUnit Unit { get => unit; set => unit = value; }
    }
}
