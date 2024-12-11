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
    public partial class SanPhamMoi : Form
    {
        public SanPhamMoi()
        {
            InitializeComponent();
        }

        int masp1;
        string tensp1;
        decimal gia1;
        string duongdan1;
        //int soluong1;

        private void SanPhamMoi_Load(object sender, EventArgs e)
        {
            List<SANPHAMDTO> listsanpham = new List<SANPHAMDTO>();
            BLL bll = new BLL();
            listsanpham = bll.GetListSanPham();
            LoadProducts(listsanpham);
        }

        private void LoadProducts(List<SANPHAMDTO> listsanpham)
        {
            foreach (SANPHAMDTO item in listsanpham)
            {
                if (string.IsNullOrEmpty(item.DUONGDAN))
                {

                }
                else
                {
                    AddProductToMenu(item.MASP, item.TENSP, item.GIA, Image.FromFile(item.DUONGDAN), item.DUONGDAN, item.KICHTHUOC);
                }

            }

            // Thêm một số sản phẩm mẫu vào menu
            //AddProductToMenu("Trà Xanh", 45000, Image.FromFile("D:\\cong nghe net nop Copy 2\\DoAnCongNghe.Net\\GUI_QL_TRASUA\\image\\asset 46.jpeg"));
            //AddProductToMenu("Trà Dâu", 44000, Image.FromFile("D:\\cong nghe net nop Copy 2\\DoAnCongNghe.Net\\GUI_QL_TRASUA\\image\\asset 47.jpeg"));
        }

        private void AddProductToMenu(int ma, string name, decimal price, Image image, string path, string size)
        {
            // Tạo một Panel chứa các thông tin của sản phẩm
            Panel productPanel = new Panel();
            productPanel.Size = new Size(200, 300); // Kích thước của panel sản phẩm

            // Tạo PictureBox để hiển thị hình ảnh sản phẩm
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(200, 200); // Kích thước của hình ảnh sản phẩm
            pictureBox.Dock = DockStyle.Top;

            // Tạo Label để hiển thị tên sản phẩm
            Label nameLabel = new Label();
            nameLabel.Text = name;
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            nameLabel.Dock = DockStyle.Top;
            nameLabel.Height = 40; // Chiều cao cho Label tên sản phẩm

            // Tạo Label để hiển thị giá sản phẩm
            Label priceLabel = new Label();
            priceLabel.Text = "Giá: " + price.ToString() + " VND";
            priceLabel.TextAlign = ContentAlignment.MiddleCenter;
            priceLabel.Dock = DockStyle.Top;
            priceLabel.Height = 30; // Chiều cao cho Label giá sản phẩm

            //tensp1 = name;
            //gia1 = price;
            //duongdan1 = "";

            productPanel.Tag = new SANPHAMDTO
            {
                MASP = ma,
                TENSP = name,
                GIA = price,
                DUONGDAN = path,
                KICHTHUOC = size,
            };

            // Thêm sự kiện Click cho Panel và các Control bên trong
            productPanel.Click += ProductPanel_Click;
            pictureBox.Click += ProductPanel_Click;  // Để khi click vào ảnh cũng nhận được sự kiện
            nameLabel.Click += ProductPanel_Click;  // Để khi click vào tên cũng nhận được sự kiện
            priceLabel.Click += ProductPanel_Click;  // Để khi click vào giá cũng nhận được sự kiện




            // Thêm các điều khiển vào Panel sản phẩm
            productPanel.Controls.Add(priceLabel);
            productPanel.Controls.Add(nameLabel);
            productPanel.Controls.Add(pictureBox);

            // Thêm Panel sản phẩm vào FlowLayoutPanel
            flowLayoutPanel1.Controls.Add(productPanel);
        }

        // Sự kiện Click của Panel sản phẩm
        private void ProductPanel_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ Panel hoặc Control được click
            Panel clickedPanel = sender as Panel ?? ((Control)sender).Parent as Panel;

            if (clickedPanel != null && clickedPanel.Tag is SANPHAMDTO product)
            {
                // Hiển thị thông tin vào các TextBox
                txt_masp.Text = product.MASP.ToString();
                txt_tensp.Text = product.TENSP;
                txt_gia.Text = product.GIA.ToString();
                duongdan1 = product.DUONGDAN.ToString();
                if (product.KICHTHUOC == "Lớn")
                {
                    cbo_kichthuoc.SelectedItem = "Lớn";
                }
                if (product.KICHTHUOC == "Vừa")
                {
                    cbo_kichthuoc.SelectedItem = "Vừa";
                }
                if (product.KICHTHUOC == "Nhỏ")
                {
                    cbo_kichthuoc.SelectedItem = "Nhỏ";
                }
                //txtTopping.Text = product.KICHTHUOC;
            }
        }

        private void btn_layduongdan_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                duongdan1 = filePath;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                decimal gia = Convert.ToDecimal(txt_gia.Text);
                if (gia <= 0)
                {
                    MessageBox.Show("Giá không thể bé hơn hoặc bằng 0");
                    txt_gia.Clear();
                    txt_gia.Focus();
                    return;
                }

                BLL bll = new BLL();
                SANPHAMDTO sp = new SANPHAMDTO
                {
                    TENSP = txt_tensp.Text,
                    GIA = Convert.ToDecimal(txt_gia.Text),
                    KICHTHUOC = cbo_kichthuoc.SelectedItem.ToString(),
                    DUONGDAN = duongdan1
                };
                bool isSuccess = bll.ThemSanPham(sp);
                if (isSuccess)
                {
                    MessageBox.Show("Thành công");
                    flowLayoutPanel1.Controls.Clear();
                    List<SANPHAMDTO> listsanpham1 = new List<SANPHAMDTO>();
                    BLL bll1 = new BLL();
                    listsanpham1 = bll1.GetListSanPham();
                    LoadProducts(listsanpham1);
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có Thông tin đã nhập sai");
                return;
            }


            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            int maSP = Convert.ToInt32(txt_masp.Text);
            bool isSuccess = bll.XoaSanPham(maSP);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                flowLayoutPanel1.Controls.Clear();
                List<SANPHAMDTO> listsanpham1 = new List<SANPHAMDTO>();
                BLL bll1 = new BLL();
                listsanpham1 = bll1.GetListSanPham();
                LoadProducts(listsanpham1);

            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string masp_s = txt_masp.Text;
                bool isNumeric = masp_s.All(char.IsDigit);
                if (isNumeric)
                {
                    BLL bll = new BLL();
                    SANPHAMDTO sp = new SANPHAMDTO
                    {
                        MASP = Convert.ToInt32(txt_masp.Text),
                        TENSP = txt_tensp.Text,
                        GIA = Convert.ToDecimal(txt_gia.Text),
                        KICHTHUOC = cbo_kichthuoc.SelectedItem.ToString(),
                        DUONGDAN = duongdan1
                    };
                    bool isSuccess = bll.SuaSanPham(sp);
                    if (isSuccess)
                    {
                        MessageBox.Show("Thành công");
                        flowLayoutPanel1.Controls.Clear();
                        List<SANPHAMDTO> listsanpham1 = new List<SANPHAMDTO>();
                        BLL bll1 = new BLL();
                        listsanpham1 = bll1.GetListSanPham();
                        LoadProducts(listsanpham1);

                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Mã Sản Phẩm phải là số");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có Thông Tin Nhập Sai");
                return;
            }
        }
    }
}
