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
    public partial class DonHang : Form
    {
        public DonHang(string username1, string quyen1, int manv1)
        {
            InitializeComponent();
            username = username1;
            quyen = quyen1;
            manv = manv1;
            LoadDonHang();
        }

        string username;
        string quyen;
        int makh;
        int manv;

        private void LoadDonHang()
        {
            BLL bll = new BLL();
            dataGridView_DonHang.DataSource = bll.GetAllDonHang();
            //lbl_username.Text = username;
            cbo_makh.DataSource = bll.GetMaKH_From_KHACHHANG();
            cbo_makh.DisplayMember = "MAKH";
            cbo_makh.ValueMember = "MAKH";

            DataTable khuyenmai_ma_ten = bll.GetAll_Ma_KhuyenMai();
            cbo_makhuyenmai.DataSource = khuyenmai_ma_ten;
            cbo_makhuyenmai.DisplayMember = "TENKM";
            cbo_makhuyenmai.ValueMember = "MAKM";

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DonHang dh = this;
            dh.Hide();
            Home home = new Home(username, quyen);
            home.ShowDialog();
            dh.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            //bool isSuccess = bll.ThemKhachHang();



            txt_makh.Text = bll.GetKhachHangMoiNhat().ToString();
            makh = bll.GetKhachHangMoiNhat();

            DONHANGDTO dh = new DONHANGDTO
            {
                MAKH = makh,
                NGAYLAP = (txt_ngaylap.Text),
                TONGGIA = 0,
                MANV = manv
            };
            bool isSuccess1 = bll.ThemDonHang(dh);
            if (isSuccess1)
            {
                MessageBox.Show("Thành công");
                LoadDonHang();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            int maDH = Convert.ToInt32(txt_madh.Text);
            bool isSuccess = bll.XoaDonHang(maDH);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadDonHang();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            DONHANGDTO dh = new DONHANGDTO
            {
                MADH = Convert.ToInt32(txt_madh.Text),
                MAKH = Convert.ToInt32(cbo_makh.SelectedValue.ToString()),
                MAKM = Convert.ToInt32(cbo_makhuyenmai.SelectedValue.ToString()),
                NGAYLAP = (txt_ngaylap.Text),
                TONGGIA = 0
            };
            bool isSuccess = bll.SuaDonHang(dh);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadDonHang();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }

        }

        private void dataGridView_DonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView_DonHang.Rows[e.RowIndex];

                    txt_madh.Text = row.Cells[0].Value.ToString();
                    txt_makh.Text = row.Cells[1].Value.ToString();

                    txt_ngaylap.Text = row.Cells[3].Value.ToString();
                    txt_tonggia.Text = row.Cells[4].Value.ToString();
                    string makh = row.Cells[1].Value.ToString();
                    if (!string.IsNullOrEmpty(makh))
                    {
                        //cbo_makh.Text = makh;
                        cbo_makh.SelectedValue = makh;
                    }
                    else
                    {
                        cbo_makh.Text = "Không có";
                    }
                    string makm = row.Cells[5].Value.ToString();
                    if (!string.IsNullOrEmpty(makm))
                    {
                        //cbo_makhuyenmai.Text = makm;
                        cbo_makhuyenmai.SelectedValue = makm;
                    }
                    else
                    {
                        cbo_makhuyenmai.Text = "Không có";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


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
