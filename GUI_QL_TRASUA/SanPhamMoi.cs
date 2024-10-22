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
                AddProductToMenu(item.TENSP, item.GIA, Image.FromFile(item.DUONGDAN));

            }

            // Thêm một số sản phẩm mẫu vào menu
            //AddProductToMenu("Trà Xanh", 45000, Image.FromFile("D:\\cong nghe net nop Copy 2\\DoAnCongNghe.Net\\GUI_QL_TRASUA\\image\\asset 46.jpeg"));
            //AddProductToMenu("Trà Dâu", 44000, Image.FromFile("D:\\cong nghe net nop Copy 2\\DoAnCongNghe.Net\\GUI_QL_TRASUA\\image\\asset 47.jpeg"));
        }

        private void AddProductToMenu(string name, decimal price, Image image)
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

            productPanel.Tag = new SANPHAMDTO
            {
                TENSP = name,
                GIA = price,
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
                txt_tensp.Text = product.TENSP;
                txt_gia.Text = product.GIA.ToString("C2");
                //txtTopping.Text = product.KICHTHUOC;
            }
        }
    }
}
