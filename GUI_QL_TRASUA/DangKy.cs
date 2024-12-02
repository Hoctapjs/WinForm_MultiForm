using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOAN_BLL;
using DOAN_DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI_QL_TRASUA
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string re_password = txt_repassword.Text;
            string tennhanvien = txt_tennhanvien.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username không được để trống", "Lưu ý");
                txt_username.Clear();
                txt_username.Focus();
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("password không được để trống", "Lưu ý");
                txt_password.Clear();
                txt_password.Focus();
            }

            if (string.IsNullOrEmpty(re_password))
            {
                MessageBox.Show("re_password không được để trống", "Lưu ý");
                txt_repassword.Clear();
                txt_repassword.Focus();
            }

            if (string.IsNullOrEmpty(tennhanvien))
            {
                MessageBox.Show("Tên nhân viên không được để trống", "Lưu ý");
                txt_tennhanvien.Clear();
                txt_tennhanvien.Focus();
            }

            if (password != re_password)
            {
                MessageBox.Show("Mật khẩu không khớp, Hãy nhập lại", "Lưu ý");
                clearalltxt();
            }

            BLL bll = new BLL();
            bool ketqua = bll.DangKy(tennhanvien, username, password);

            if (ketqua)
            {
                MessageBox.Show("Bạn đã đăng ký thành công", "Thông báo");
                MessageBox.Show("Hãy quay về trang đăng nhập để đăng nhập", "Thông báo");
            }
            else
            {
                MessageBox.Show("Bạn đã đăng ký thất bại", "Thông báo");
            }
        }

        private void clearalltxt()
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_repassword.Clear();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            DangKy dangky = this;
            dangky.Hide();
            Login login = new Login();
            login.ShowDialog();
            dangky.Close();
        }
    }
}
