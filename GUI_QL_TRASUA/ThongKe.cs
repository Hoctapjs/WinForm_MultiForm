using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DOAN_BLL;

namespace GUI_QL_TRASUA
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            DataTable soluongdon = bll.SoLuongDonHangTheoNhanVien();
            DataTable tongdanhthu = bll.TongDoanhThuTheoNhanVien();
            DataTable sospbanduoc = bll.SoLuongSanPhamBanDuoc();
            DataTable topsanphambanchay = bll.TopSanPhamBanChay();


            BindDataToChart1(soluongdon);
            BindDataToChart2(tongdanhthu);
            BindDataToChart3(sospbanduoc);
            BindDataToChart4(topsanphambanchay);

        }

        private void BindDataToChart1(DataTable dataTable)
        {
            // Xóa các series cũ nếu có
            chart1.Series.Clear();
            chart1.Titles.Clear(); // Xóa các tiêu đề cũ nếu có
            chart1.Titles.Add("Thống kê số lượng đơn hàng theo nhân viên");


            // Tạo một series mới
            Series series = new Series("Số lượng đơn hàng bán được");
            series.ChartType = SeriesChartType.Pie;
            series.XValueMember = "TENNV";         // Trục X là cột 'Category'
            series.YValueMembers = "SoLuongDonHang";           // Trục Y là cột 'Value'
            series.IsValueShownAsLabel = true;        // Hiển thị giá trị trên cột

            // Gán dữ liệu từ DataTable
            chart1.DataSource = dataTable;
            chart1.Series.Add(series);

            // Đảm bảo khoảng cách giữa các cột trên trục X
            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.Interval = 1;             // Đặt khoảng cách giữa các điểm trên trục X
            chartArea.AxisX.IsMarginVisible = true;   // Hiển thị khoảng cách giữa các cột
            chartArea.AxisX.Title = "TENNV";       // Tiêu đề trục X
            chartArea.AxisY.Title = "SoLuongDonHang";
            chartArea.AxisX.LabelStyle.Angle = -45; // Xoay nhãn X nếu nhãn quá dài
            chartArea.AxisX.Interval = 1; // Khoảng cách giữa các điểm
                                          // Tiêu đề trục Y

            // Cấu hình chiều rộng các cột để không bị chồng
            series["PointWidth"] = "0.2";             // Thu nhỏ chiều rộng của cột (giá trị 0 - 1)

            //MessageBox.Show($"ChartType: {series.ChartType}");
            //MessageBox.Show($"XValueMember: {series.XValueMember}");
            //MessageBox.Show($"YValueMembers: {series.YValueMembers}");
            //MessageBox.Show($"PointWidth: {series["PointWidth"]}");


            // Vẽ lại biểu đồ
            chart1.DataBind();
        }

        private void BindDataToChart2(DataTable dataTable)
        {
            // Xóa các series cũ nếu có
            chart2.Series.Clear();
            chart2.Titles.Clear(); // Xóa các tiêu đề cũ nếu có
            chart2.Titles.Add("Thống kê tổng doanh thu theo nhân viên");


            // Tạo một series mới
            Series series = new Series("Doanh thu của mỗi nhân viên");
            series.ChartType = SeriesChartType.Pie;
            series.XValueMember = "TENNV";         // Trục X là cột 'Category'
            series.YValueMembers = "TongDoanhThu";           // Trục Y là cột 'Value'
            series.IsValueShownAsLabel = true;        // Hiển thị giá trị trên cột

            // Gán dữ liệu từ DataTable
            chart2.DataSource = dataTable;
            chart2.Series.Add(series);

            // Đảm bảo khoảng cách giữa các cột trên trục X
            var chartArea = chart2.ChartAreas[0];
            chartArea.AxisX.Interval = 1;             // Đặt khoảng cách giữa các điểm trên trục X
            chartArea.AxisX.IsMarginVisible = true;   // Hiển thị khoảng cách giữa các cột
            chartArea.AxisX.Title = "TENNV";       // Tiêu đề trục X
            chartArea.AxisY.Title = "TongDoanhThu";
            chartArea.AxisX.LabelStyle.Angle = -45; // Xoay nhãn X nếu nhãn quá dài
            chartArea.AxisX.Interval = 1; // Khoảng cách giữa các điểm
                                          // Tiêu đề trục Y

            // Cấu hình chiều rộng các cột để không bị chồng
            series["PointWidth"] = "0.2";             // Thu nhỏ chiều rộng của cột (giá trị 0 - 1)

            //MessageBox.Show($"ChartType: {series.ChartType}");
            //MessageBox.Show($"XValueMember: {series.XValueMember}");
            //MessageBox.Show($"YValueMembers: {series.YValueMembers}");
            //MessageBox.Show($"PointWidth: {series["PointWidth"]}");


            // Vẽ lại biểu đồ
            chart2.DataBind();
        }

        private void BindDataToChart3(DataTable dataTable)
        {
            // Xóa các series cũ nếu có
            chart3.Series.Clear();
            chart3.Titles.Clear(); // Xóa các tiêu đề cũ nếu có
            chart3.Titles.Add("Số lượng sản phẩm bán được của mỗi sản phẩm");


            // Tạo một series mới
            Series series = new Series("Số lượng bán được của sản phẩm");
            series.ChartType = SeriesChartType.Pie;
            series.XValueMember = "MASP";         // Trục X là cột 'Category'
            series.YValueMembers = "TongSoLuong";           // Trục Y là cột 'Value'
            series.IsValueShownAsLabel = true;        // Hiển thị giá trị trên cột

            // Gán dữ liệu từ DataTable
            chart3.DataSource = dataTable;
            chart3.Series.Add(series);

            // Đảm bảo khoảng cách giữa các cột trên trục X
            var chartArea = chart3.ChartAreas[0];
            chartArea.AxisX.Interval = 1;             // Đặt khoảng cách giữa các điểm trên trục X
            chartArea.AxisX.IsMarginVisible = true;   // Hiển thị khoảng cách giữa các cột
            chartArea.AxisX.Title = "MASP";       // Tiêu đề trục X
            chartArea.AxisY.Title = "TongSoLuong";
            chartArea.AxisX.LabelStyle.Angle = -45; // Xoay nhãn X nếu nhãn quá dài
            chartArea.AxisX.Interval = 1; // Khoảng cách giữa các điểm
                                          // Tiêu đề trục Y

            // Cấu hình chiều rộng các cột để không bị chồng
            series["PointWidth"] = "0.2";             // Thu nhỏ chiều rộng của cột (giá trị 0 - 1)

            //MessageBox.Show($"ChartType: {series.ChartType}");
            //MessageBox.Show($"XValueMember: {series.XValueMember}");
            //MessageBox.Show($"YValueMembers: {series.YValueMembers}");
            //MessageBox.Show($"PointWidth: {series["PointWidth"]}");


            // Vẽ lại biểu đồ
            chart3.DataBind();
        }

        private void BindDataToChart4(DataTable dataTable)
        {
            // Xóa các series cũ nếu có
            chart4.Series.Clear();
            chart4.Titles.Clear(); // Xóa các tiêu đề cũ nếu có
            chart4.Titles.Add("Top sản phẩm bán chạy của quán");


            // Tạo một series mới
            Series series = new Series("Số lượng sản phẩm bán được");
            series.ChartType = SeriesChartType.Pie;
            series.XValueMember = "MASP";         // Trục X là cột 'Category'
            series.YValueMembers = "TongSoLuong";           // Trục Y là cột 'Value'
            series.IsValueShownAsLabel = true;        // Hiển thị giá trị trên cột

            // Gán dữ liệu từ DataTable
            chart4.DataSource = dataTable;
            chart4.Series.Add(series);

            // Đảm bảo khoảng cách giữa các cột trên trục X
            var chartArea = chart4.ChartAreas[0];
            chartArea.AxisX.Interval = 1;             // Đặt khoảng cách giữa các điểm trên trục X
            chartArea.AxisX.IsMarginVisible = true;   // Hiển thị khoảng cách giữa các cột
            chartArea.AxisX.Title = "MASP";       // Tiêu đề trục X
            chartArea.AxisY.Title = "TongSoLuong";
            chartArea.AxisX.LabelStyle.Angle = -45; // Xoay nhãn X nếu nhãn quá dài
            chartArea.AxisX.Interval = 1; // Khoảng cách giữa các điểm
                                          // Tiêu đề trục Y

            // Cấu hình chiều rộng các cột để không bị chồng
            series["PointWidth"] = "0.2";             // Thu nhỏ chiều rộng của cột (giá trị 0 - 1)

            //MessageBox.Show($"ChartType: {series.ChartType}");
            //MessageBox.Show($"XValueMember: {series.XValueMember}");
            //MessageBox.Show($"YValueMembers: {series.YValueMembers}");
            //MessageBox.Show($"PointWidth: {series["PointWidth"]}");


            // Vẽ lại biểu đồ
            chart4.DataBind();
        }
    }
}
