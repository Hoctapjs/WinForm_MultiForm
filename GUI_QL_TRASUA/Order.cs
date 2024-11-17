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

        public Order(int manv1, string username1, string quyen1)
        {
            InitializeComponent();
            username = username1;
            quyen = quyen1;
            manv = manv1;
        }

        string username;
        string quyen;
        int manv;


        int masp1;
        string tensp1;
        decimal gia1;
        int soluong1 = 0;
        decimal tongtien1mon = 0;
        decimal tongtienall = 0;

        int makh_moi;
        int madh_moi;


        List<OrderDTO> listorder = new List<OrderDTO>();



        private void SanPhamMoi_Load(object sender, EventArgs e)
        {
            // khởi tạo lớp bll và các list cần thiết
            List<int> listmakh = new List<int>();
            List<int> listmadh = new List<int>();
            List<SANPHAMDTO> listsanpham = new List<SANPHAMDTO>();
            BLL bll = new BLL();

            cbo_thanhvien.Items.Add("Có");
            cbo_thanhvien.Items.Add("Không");
            //cbo_thanhvien.SelectedIndex = 1;


            // tạo một khách hàng mới
            KHACHHANGDTO kh = new KHACHHANGDTO
            {
                TENKH = "null",
                SODT = "null",
                DIACHI = "null",
            };

            // thêm khách hàng mới vào db
            bool isSuccesskh = bll.ThemKhachHang(kh);

            // lấy list khách hàng đang có, chuẩn bị lấy khách mới nhất
            listmakh = bll.GetListMaKH_From_KHACHHANG();

            // tìm ra khách hàng mới nhất bằng cách so sánh thứ tự của mã khách (thứ tự max)
            makh_moi = listmakh[0];
            foreach (var item in listmakh)
            {
                if (item > makh_moi)
                {
                    makh_moi = item;
                }
            }


            // tạo một đơn hàng mới, với mã khách là mã của khách mới nhất vừa lấy
            DONHANGDTO dh = new DONHANGDTO
            {
                MAKH = makh_moi,
                MANV = manv,
                NGAYLAP = "",
                TONGGIA = 0,
            };

            // truyền xuống bll để thêm đơn hàng
            bool isSuccessdh = bll.ThemDonHang(dh);

            // lấy list đơn hàng mới nhất, bao gồm đơn vừa thêm, chuẩn bị cho việc lấy đơn mới nhất
            listmadh = bll.GetListMaDH_From_DONHANG();

            // chạy vòng lặp tìm ra đơn hàng mới nhất trong list lấy được
            madh_moi = listmadh[0];
            foreach (var item in listmadh)
            {
                if (item > madh_moi)
                {
                    madh_moi = item;
                }
            }



            // truyền xuống bll lấy list sản phẩm
            listsanpham = bll.GetListSanPham();

            DataTable khuyenmai_ma_ten = bll.GetAll_Ma_KhuyenMai();

            cbo_khuyenmai.DataSource = khuyenmai_ma_ten;
            cbo_khuyenmai.DisplayMember = "TENKM";
            cbo_khuyenmai.ValueMember = "MAKM";

            // truyền list sản phẩm vừa lấy được vào hàm load sản phẩm
            LoadProducts(listsanpham);
        }

        private void LoadProducts(List<SANPHAMDTO> listsanpham)
        {
            // nhận list sản phẩm được truyền vào

            // với từng sản phẩm trong list thì truyền thông tin của sản phẩm đó vào hàm thêm sản phẩm vào menu

            foreach (SANPHAMDTO item in listsanpham)
            {
                AddProductToMenu(item.TENSP, item.GIA, Image.FromFile(item.DUONGDAN), item.MASP);

            }

            // Thêm một số sản phẩm mẫu vào menu
            //AddProductToMenu("Trà Xanh", 45000, Image.FromFile("D:\\cong nghe net nop Copy 2\\DoAnCongNghe.Net\\GUI_QL_TRASUA\\image\\asset 46.jpeg"));
            //AddProductToMenu("Trà Dâu", 44000, Image.FromFile("D:\\cong nghe net nop Copy 2\\DoAnCongNghe.Net\\GUI_QL_TRASUA\\image\\asset 47.jpeg"));
        }


        // phương thức load sản phẩm lên menu, nhận tham số là tên, giá, hình ảnh, mã sản phẩm
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
                    txt_gia.Text = product.o_gia.ToString();
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
            BLL bll = new BLL();
            int makhuyenmai = int.Parse(cbo_khuyenmai.SelectedValue.ToString());
            string thanhvien = cbo_thanhvien.SelectedItem.ToString();

            
            // sửa đơn hàng bằng cách cập nhật mã khuyến mãi của đơn
            bool isSuccess = bll.SuaDonHang(madh_moi, makhuyenmai);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại thêm khuyến mãi vào đơn hàng");
            }

            // sửa khách hàng bằng cách thêm thành viên
            bool isSuccess2 = bll.SuaKhachHang(makh_moi, thanhvien);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại thêm thành viên cho khách hàng");
            }




            string dsmon = "";
            foreach (var item in listorder)
            {
                dsmon += item.o_tensp + " : " + item.o_soluong + "\n";
                CHITIETDONHANGDTO ct = new CHITIETDONHANGDTO
                {
                    MADH = madh_moi,
                    MASP = item.o_masp,
                    SOLUONG = item.o_soluong,
                    GIA = 0
                };
                bool isSuccess1 = bll.ThemChiTietDonHang(ct);
            }

            MessageBox.Show($"Tổng tiền hóa đơn đã ghi nhận là: {tongtienall}\n" + dsmon, "Xác Nhận");
            // khi khởi động form order thì sẽ tạo mới 1 khách, lưu trữ mã khách, lấy mã khách đó tạo mới 1 đơn
            // lưu trữ mã khách, mã đơn để chuẩn bị tạo chi tiết đơn hàng từ listorder
            // có 2 chức năng là làm mới đơn (đã làm) và xóa đơn

            // nếu làm mới đơn thì gọi lệnh tạo người dùng mới và đơn của người dùng mới đó

            // nếu xóa đơn, thì sẽ dùng mã khách và mã đơn đã lưu trữ và xóa chúng trong cơ sở dữ liệu

            // nếu thanh toán thì sẽ thực hiện:
            // dùng listorder có được, duyệt qua các phần tử trong nó,
            // sau khi duyệt qua 1 phần tử, truyền phần tử đó vào câu lệnh thêm bll, từ bll truyền vào câu lệnh thêm dal
            // truyền vào dal để tạo chi tiết hóa đơn

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

        private void btn_xoadon_Click(object sender, EventArgs e)
        {
            XoaDonVaKhach();
        }

        private void XoaDonVaKhach()
        {
            BLL bll = new BLL();
            bool isSuccess2 = bll.XoaDonHang(madh_moi);
            bool isSuccess1 = bll.XoaKhachHang(makh_moi);
        }
    }
}
