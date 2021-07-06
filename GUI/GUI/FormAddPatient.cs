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
    public partial class FormAddPatient : Form
    {
        public FormAddPatient()
        {
            InitializeComponent();
            this.pDragBar.MouseDown += (s, e) =>
            {
                BUS.Event.MouseDown_DragBar(this);
            };
            load();
            this.bSave.Click += BSave_Click;
            this.bRefresh.Click += BRefresh_Click; ;
            this.bCancel.Click += BCancel_Click; ;
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BRefresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Insertpatient();

            }
            else
            {
                clear();
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            Insertpatient();
        }

        private void FormAddPatient_Load(object sender, EventArgs e)
        {
            //Form form = this;
            //form.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        void load()
        {
            dtpDate.Value = DateTime.Now;
            cbSex.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbSex.SelectedIndex = 1;
        }
        string GetID_of_oldPaitent()
        {
            try
            {
                string id = "";
                string name = tbName.Text;
                string sex = cbSex.Text;
                DateTime birthday = dtpDate.Value;
                string address = tbAddress.Text;
                id = DAO.Patient.Instance.get_IDoldPatient(name, sex, birthday, address);
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
            string id = DAO.Patient.Instance.get_IDMax();
            if (id != null)
            {
                id = id.Remove(0, 2);
                string stt = (Convert.ToInt32(id) + 1).ToString();

                id = "BN";
                for (int i = 0; i < 7 - 2 - stt.Length; i++)
                {
                    id = id + "0";
                }
                id = id + stt;
            }

            return id;
        }
        async void Insertpatient()
        {
            try
            {
                string id = GetID_of_oldPaitent();
                if (id == null)
                {
                    MessageBox.Show("Lỗi kết nối: Không kiểm tra được thông tin bệnh nhân có trong hệ thống!");
                    return;
                }
                else if (id != "")
                {
                    DAO.NotificationHandler.NotifyWarning("Thông tin bệnh nhân đã có trong hệ thống!");
                    return;
                }
                else
                {
                    SqlConnection connection = await Data.OpenConnection();

                    int soluongbenhnhan = DAO.Patient.Instance.get_patientcount();

                    Data.CloseConnection(ref connection);




                    string name = tbName.Text;
                    string sex = cbSex.Text;
                    DateTime birthday = dtpDate.Value;
                    string address = tbAddress.Text;


                    if (name == "" || sex == null || birthday == null || address == "")
                    {
                        DAO.NotificationHandler.NotifyWarning("Bạn cần phải nhập đầy đủ dữ liệu!");
                        return;
                    }


                    else
                    {
                        id = "";

                        if (soluongbenhnhan > 0)
                        {

                            id = CreateID();

                            if (id == null)
                            {
                                MessageBox.Show("Không thể khỏi tạo mã bệnh nhân do lỗi kết nối!");
                                return;
                            }
                            if (id.Length != 7)
                            {
                                MessageBox.Show("Lỗi hệ thống: Mã bệnh nhân không hợp quy định!");
                                return;
                            }
                        }
                        else
                        {
                            id = "BN00001";

                        }
                        DTO.Patient patient = new DTO.Patient(id, name, sex, birthday, address);

                        DAO.Patient.Instance.InsertPatient(patient);

                        DAO.NotificationHandler.NotifyInfo("Đã nhập thành công bệnh nhân!");
                        if (insertPatient != null)
                        {
                            insertPatient(this, new Patientevent(patient));
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
            tbName.Text = "";
            tbAddress.Text = "";
            dtpDate.Value = DateTime.Now;
            cbSex.SelectedIndex = 1;
        }

        private event EventHandler<Patientevent> insertPatient;
        public event EventHandler<Patientevent> InsertPatient
        {
            add { insertPatient += value; }
            remove { insertPatient -= value; }
        }
    }
    public class Patientevent : EventArgs
    {
        private DTO.Patient patient;


        public Patientevent(DTO.Patient acc)
        {
            this.Patient = acc;
        }

        public DTO.Patient Patient { get => patient; set => patient = value; }
    }
}
