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
using DOAN_DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI_QL_TRASUA
{
    public partial class DatLaiMatKhau : Form
    {
        public DatLaiMatKhau()
        {
            InitializeComponent();
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            string tennguoidung = txt_tennguoidung.Text;
            string matkhaucu = txt_matkhaucu.Text;
            string matkhaumoi = txt_matkhaumoi.Text;

            if (tennguoidung.Length > 30)
            {
                MessageBox.Show("Đã nhập quá 30 ký tự, Xin hãy nhập lại");
                txt_tennguoidung.Clear();
                txt_tennguoidung.Focus();
                return;
            }

            if (matkhaucu.Length > 30)
            {
                MessageBox.Show("Đã nhập quá 30 ký tự, Xin hãy nhập lại");
                txt_matkhaucu.Clear();
                txt_matkhaucu.Focus();
                return;
            }

            if (matkhaumoi.Length > 30)
            {
                MessageBox.Show("Đã nhập quá 30 ký tự, Xin hãy nhập lại");
                txt_matkhaumoi.Clear();
                txt_matkhaumoi.Focus();
                return;
            }

            bool dangnhap = false;

            BLL bll = new BLL();
            NHANVIENDTO nhanVien = bll.KiemTraDangNhap(tennguoidung, matkhaucu);

            if (nhanVien != null)
            {
                dangnhap = true;
            }
            else
            {
                MessageBox.Show("Thông Tin Không Đúng, Đăng Nhập Lại Nhé");
                return;
            }

            tennguoidung = nhanVien.USERNAME;

            BLL bll1 = new BLL();
            bool KQ = bll.DoiMatKhau(tennguoidung, matkhaumoi);

            if (KQ)
            {
                MessageBox.Show("Đổi Mật Khẩu Thành Công");
            }
            else
            {
                MessageBox.Show("Đổi Mật Khẩu Không Thành Công");
                return;
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            DatLaiMatKhau repass = this;
            repass.Hide();
            Login login = new Login();
            login.ShowDialog();
            repass.Close();
        }
    }
}
