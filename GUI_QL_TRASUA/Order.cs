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
    public partial class Order : Form
    {
        public Order(string username1, string quyen1)
        {
            InitializeComponent();
            username = username1;
            quyen = quyen1;
        }

        string username;
        string quyen;


        int masp1;
        string tensp1;
        decimal gia1;
        int soluong1 = 0;
        decimal tongtien1mon = 0;
        decimal tongtienall = 0;

        List<OrderDTO> listorder = new List<OrderDTO>();



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
                AddProductToMenu(item.TENSP, item.GIA, Image.FromFile(item.DUONGDAN), item.MASP);

            }

            // Thêm một số sản phẩm mẫu vào menu
            //AddProductToMenu("Trà Xanh", 45000, Image.FromFile("D:\\cong nghe net nop Copy 2\\DoAnCongNghe.Net\\GUI_QL_TRASUA\\image\\asset 46.jpeg"));
            //AddProductToMenu("Trà Dâu", 44000, Image.FromFile("D:\\cong nghe net nop Copy 2\\DoAnCongNghe.Net\\GUI_QL_TRASUA\\image\\asset 47.jpeg"));
        }

        private void AddProductToMenu(string name, decimal price, Image image, int masp2)
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

            productPanel.Tag = new OrderDTO
            {
                o_masp = masp2,
                o_tensp = name,
                o_gia = price,
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

            if (clickedPanel != null && clickedPanel.Tag is OrderDTO product)
            {
                if (string.IsNullOrEmpty(tensp1) || product.o_masp == masp1)
                {
                    masp1 = product.o_masp;
                    tensp1 = product.o_tensp;
                    gia1 = product.o_gia;
                    soluong1++;
                    tongtien1mon += product.o_gia;
                    //tongtienall += product.o_gia;
                    txt_tensp.Text = product.o_tensp;
                    txt_gia.Text = product.o_gia.ToString("C2");
                    txt_soluong.Text = soluong1.ToString();
                }
                else
                {
                    MessageBox.Show("Bạn phải chọn xong sản phẩm hiện tại hoặc xóa sản phẩm và chọn sản phẩm khác", "Thông báo");
                }

            }
        }

        private void btn_layduongdan_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                //duongdan1 = filePath;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //tongtienall -= tongtien1mon;
            resetOrderSP();
            clearAllTxt();
        }

        private void resetOrderSP()
        {
            masp1 = 0;
            tensp1 = "";
            gia1 = 0;
            soluong1 = 0;
            //tongtienall -= tongtien1mon;
            tongtien1mon = 0;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            tongtienall += tongtien1mon;
            OrderDTO order = new OrderDTO();
            order.o_masp = masp1;
            order.o_tensp = tensp1;
            order.o_gia = gia1;
            order.o_soluong = soluong1;
            listorder.Add(order);
            MessageBox.Show($"Ghi nhận thành công món: {tensp1}, với số lượng: {soluong1}, thành tiền cho sản phẩm này là: {tongtien1mon}");
            resetOrderSP();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            string dsmon = "";

            foreach (var item in listorder)
            {
                dsmon += item.o_tensp + " : " + item.o_soluong+ "\n";
            }

            MessageBox.Show($"Tổng tiền hóa đơn đã ghi nhận là: {tongtienall}\n" + dsmon, "Xác Nhận");

        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            refreshOrderSP();
        }

        private void refreshOrderSP()
        {
            masp1 = 0;
            tensp1 = "";
            gia1 = 0;
            soluong1 = 0;
            tongtienall = 0;
            tongtien1mon = 0;
            clearAllTxt();
            listorder = new List<OrderDTO>();
        }

        private void clearAllTxt()
        {
            txt_tensp.Clear();
            txt_soluong.Clear();
            txt_gia.Clear();
        }


    }
}
