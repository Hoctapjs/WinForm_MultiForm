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

namespace GUI_QL_TRASUA
{
    public partial class KhuyenMai : Form
    {
        public KhuyenMai()
        {
            InitializeComponent();

            //btn_them.Text = "Thêm";
            //btn_them.Image = Image.FromFile("icon/add.png");
            //btn_them.TextImageRelation = TextImageRelation.ImageBeforeText;

            //btn_xoa.Text = "Xóa";
            //btn_xoa.Image = Image.FromFile("icon/remove.png");
            //btn_xoa.TextImageRelation = TextImageRelation.ImageBeforeText;

            //btn_sua.Text = "Sửa";
            //btn_sua.Image = Image.FromFile("icon/update.png");
            //btn_sua.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        public KhuyenMai(string username1, string quyen1)
        {
            InitializeComponent();
            username = username1;
            quyen = quyen1;
        }

        string username;
        string quyen;

        private void LoadKhuyenMai()
        {
            BLL bll = new BLL();
            dataGridView_KhuyenMai.DataSource = bll.GetAllKhuyenMai();
            //lbl_username.Text = username;

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            KhuyenMai km = this;
            km.Hide();
            Home home = new Home(username, quyen);
            home.ShowDialog();
            km.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            if (string.IsNullOrEmpty(txt_ngaybd.Text) || string.IsNullOrEmpty(txt_ngaykt.Text))
            {
                KHUYENMAIDTO km = new KHUYENMAIDTO
                {
                    Tenkm = txt_tenkm.Text,
                    Hesokm = float.Parse(txt_heso.Text)
                };

                bool isSuccess = bll.ThemKhuyenMai(km);
                if (isSuccess)
                {
                    MessageBox.Show("Thành công");
                    LoadKhuyenMai();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            else
            {
                KHUYENMAIDTO km = new KHUYENMAIDTO
                {
                    Tenkm = txt_tenkm.Text,
                    Ngaybd = DateTime.Parse(txt_ngaybd.Text),
                    Ngaykt = DateTime.Parse(txt_ngaykt.Text),
                    Hesokm = float.Parse(txt_heso.Text)
                };

                bool isSuccess = bll.ThemKhuyenMai(km);
                if (isSuccess)
                {
                    MessageBox.Show("Thành công");
                    LoadKhuyenMai();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }

            
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            int makm = Convert.ToInt32(txt_makm.Text);
            bool isSuccess = bll.XoaKhuyenMai(makm);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadKhuyenMai();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            KHUYENMAIDTO km = new KHUYENMAIDTO
            {
                Makm = int.Parse(txt_makm.Text),
                Tenkm = txt_tenkm.Text,
                Ngaybd = DateTime.Parse(txt_ngaybd.Text),
                Ngaykt = DateTime.Parse(txt_ngaykt.Text),
                Hesokm = float.Parse(txt_heso.Text)
            };
            bool isSuccess = bll.SuaKhuyenMai(km);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadKhuyenMai();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void dataGridView_KhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_KhuyenMai.Rows[e.RowIndex];

                txt_makm.Text = row.Cells[0].Value.ToString();
                txt_tenkm.Text = row.Cells[1].Value.ToString();
                txt_ngaybd.Text = row.Cells[2].Value.ToString();
                txt_ngaykt.Text = row.Cells[3].Value.ToString();
                txt_heso.Text = row.Cells[4].Value.ToString();

            }
        }

        private void dataGridView_KhuyenMai_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_KhuyenMai.Rows[e.RowIndex];

                txt_makm.Text = row.Cells[0].Value.ToString();
                txt_tenkm.Text = row.Cells[1].Value.ToString();
                txt_ngaybd.Text = row.Cells[2].Value.ToString();
                txt_ngaykt.Text = row.Cells[3].Value.ToString();
                txt_heso.Text = row.Cells[4].Value.ToString();

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

        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            LoadKhuyenMai();
        }
    }
}
