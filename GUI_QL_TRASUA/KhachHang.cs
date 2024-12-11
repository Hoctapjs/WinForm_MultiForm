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
    public partial class KhachHang : Form
    {
        public KhachHang(string username1, string quyen1)
        {
            InitializeComponent();
            username = username1;
            quyen = quyen1;
            LoadKhachHang();
        }

        string username;
        string quyen;
        int makh;

        private void LoadKhachHang()
        {
            BLL bll = new BLL();
            dataGridView_KhachHang.DataSource = bll.GetAllKhachHang();
            //lbl_username.Text = username;

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            KhachHang khach = this;
            khach.Hide();
            Home home = new Home(username, quyen);
            home.ShowDialog();
            khach.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            string tenkh = txt_tenkh.Text;
            string sodt = txt_sodt.Text;
            string diachi = txt_diachi.Text;

            bool isNumeric = sodt.All(char.IsDigit);
            bool kt_len = false;

            if (sodt.Length == 10)
            {
                kt_len = true;
            }

            if (isNumeric == true && kt_len == true)
            {
                KHACHHANGDTO kh = new KHACHHANGDTO
                {
                    TENKH = txt_tenkh.Text,
                    SODT = txt_sodt.Text,
                    DIACHI = txt_diachi.Text
                };
                bool isSuccess = bll.ThemKhachHang(kh);
                if (isSuccess)
                {
                    MessageBox.Show("Thành công");
                    LoadKhachHang();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            else
            {
                if (isNumeric == false)
                {
                    MessageBox.Show("Số điện thoại không được là ký tự chữ,");
                }
                else
                {
                    MessageBox.Show("Số điện thoại có độ dài là 10");
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            int maKH = Convert.ToInt32(txt_makh.Text);
            bool isSuccess = bll.XoaKhachHang(maKH);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadKhachHang();
            }
            else
            {
                MessageBox.Show("Không thể xóa người dùng đã có đơn");
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            string tenkh = txt_tenkh.Text;
            string sodt = txt_sodt.Text;
            string diachi = txt_diachi.Text;

            bool isNumeric = sodt.All(char.IsDigit);
            bool kt_len = false;

            if (sodt.Length == 10)
            {
                kt_len = true;
            }

            if (isNumeric == true && kt_len == true)
            {
                KHACHHANGDTO kh1 = new KHACHHANGDTO
                {
                    MAKH = Convert.ToInt32(txt_makh.Text),
                    TENKH = txt_tenkh.Text,
                    SODT = txt_sodt.Text,
                    DIACHI = txt_diachi.Text
                };
                bool isSuccess1 = bll.SuaKhachHang(kh1);
                if (isSuccess1)
                {
                    MessageBox.Show("Thành công");
                    LoadKhachHang();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            else
            {
                if (isNumeric == false)
                {
                    MessageBox.Show("Số điện thoại không được là ký tự chữ,");
                }
                else
                {
                    MessageBox.Show("Số điện thoại có độ dài là 10");
                }
            }
        }

        private void dataGridView_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_KhachHang.Rows[e.RowIndex];

                txt_makh.Text = row.Cells[0].Value.ToString();
                txt_tenkh.Text = row.Cells[1].Value.ToString();
                txt_sodt.Text = row.Cells[2].Value.ToString();
                txt_diachi.Text = row.Cells[3].Value.ToString();

            }
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {

        }
    }
}
