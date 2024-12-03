using DOAN_BLL;
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
    public partial class Home_Moi : Form
    {
        public Home_Moi(string username1, string quyen1)
        {
            InitializeComponent();
            username = username1;
            quyen = quyen1;
        }

        public Home_Moi(int manv1, string username1, string quyen1)
        {
            InitializeComponent();
            username = username1;
            quyen = quyen1;
            manv = manv1;
        }

        string username;
        string quyen;
        int manv;

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form3 form3 = new Form3();

            //form3.TopLevel = false;
            //form3.FormBorderStyle = FormBorderStyle.None;
            //form3.Dock = DockStyle.Fill;

            //panel2.Controls.Clear();
            //panel2.Controls.Add(form3);
            //form3.Show();

            NhanVien nhanvien = new NhanVien(username, quyen);
            nhanvien.TopLevel = false;
            nhanvien.FormBorderStyle = FormBorderStyle.None;
            nhanvien.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(nhanvien);
            nhanvien.Show();

        }

        private void Home_Moi_Load(object sender, EventArgs e)
        {
            lbl_username.Text = username;
            lbl_quyen.Text = quyen;

            menuNhanVienToolStripMenuItem.Visible = false;
            menuSanPhamToolStripMenuItem.Visible = false;
            menuThongKeToolStripMenuItem.Visible = false;
            menuKhuyenMaiToolStripMenuItem.Visible = false;
            menuOrderToolStripMenuItem.Visible = false;
            menuCN_NhanVienToolStripMenuItem1.Visible = false;


            if (quyen == "Nhân viên")
            {
                menuOrderToolStripMenuItem.Visible = true;
                menuCN_NhanVienToolStripMenuItem1.Visible = true;
            }

            if (quyen == "Admin")
            {
                menuOrderToolStripMenuItem.Visible = true;
                menuCN_NhanVienToolStripMenuItem1.Visible = true;
                menuNhanVienToolStripMenuItem.Visible = true;
                menuSanPhamToolStripMenuItem.Visible = true;
                menuThongKeToolStripMenuItem.Visible = true;
                menuKhuyenMaiToolStripMenuItem.Visible = true;
            }
        }

        private void menuSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SanPhamMoi sanphammoi = new SanPhamMoi();
            sanphammoi.TopLevel = false;
            sanphammoi.FormBorderStyle = FormBorderStyle.None;
            sanphammoi.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(sanphammoi);
            sanphammoi.Show();
        }

        public void menuOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HienThiFormOrder();
        }

        public void HienThiFormOrder()
        {
            Order order = new Order(manv, username, quyen);
            order.TopLevel = false;
            order.FormBorderStyle = FormBorderStyle.None;
            order.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(order);
            order.Show();
        }

        private void menuXemKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang khach = new KhachHang(username, quyen);
            khach.TopLevel = false;
            khach.FormBorderStyle = FormBorderStyle.None;
            khach.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(khach);
            khach.Show();
        }

        private void menuXemHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonHang donhang = new DonHang(username, quyen, manv);
            donhang.TopLevel = false;
            donhang.FormBorderStyle = FormBorderStyle.None;
            donhang.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(donhang);
            donhang.Show();
        }

        private void menuXemChiTietHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietDonHang chitietdonhang = new ChiTietDonHang(username, quyen);
            chitietdonhang.TopLevel = false;
            chitietdonhang.FormBorderStyle = FormBorderStyle.None;
            chitietdonhang.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(chitietdonhang);
            chitietdonhang.Show();
        }

        private void menuKhuyenMaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhuyenMai khuyenmai = new KhuyenMai(username, quyen);
            khuyenmai.TopLevel = false;
            khuyenmai.FormBorderStyle = FormBorderStyle.None;
            khuyenmai.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(khuyenmai);
            khuyenmai.Show();
        }

        private void menuThongKeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe thongke = new ThongKe();
            thongke.TopLevel = false;
            thongke.FormBorderStyle = FormBorderStyle.None;
            thongke.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(thongke);
            thongke.Show();
        }
    }
}
