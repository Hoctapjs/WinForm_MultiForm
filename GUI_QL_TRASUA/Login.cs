using DOAN_BLL;
using DOAN_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI_QL_TRASUA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool dangnhap = false;
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (username.Length > 30)
            {
                MessageBox.Show("Đã nhập quá 30 ký tự, Xin hãy nhập lại");
                txt_username.Clear();
                txt_username.Focus();
                return;
            }

            if (password.Length > 30)
            {
                MessageBox.Show("Đã nhập quá 30 ký tự, Xin hãy nhập lại");
                txt_username.Clear();
                txt_username.Focus();
                return;
            }

            BLL bll = new BLL();
            NHANVIENDTO nhanVien = bll.KiemTraDangNhap(username, password);

            if (nhanVien != null)
            {
                dangnhap = true;
            }
            else
            {
                MessageBox.Show("Thông Tin Không Đúng, Đăng Nhập Lại Nhé");
                return;
            }

            username = nhanVien.USERNAME;
            string quyen = nhanVien.QUYEN;
            int ma = nhanVien.MANV;

            if (dangnhap)
            {
                MessageBox.Show("Đăng Nhập Thành Công");
                Login login = this;
                login.Hide();
                Home_Moi homemoi = new Home_Moi(ma, username, quyen);
                homemoi.ShowDialog();
                login.Close();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại");
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            Login login = this;
            login.Hide();
            DangKy dangky = new DangKy();
            dangky.ShowDialog();
            login.Close();
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            Login login = this;
            login.Hide();
            DatLaiMatKhau repass = new DatLaiMatKhau();
            repass.ShowDialog();
            login.Close();
        }
    }
}
;