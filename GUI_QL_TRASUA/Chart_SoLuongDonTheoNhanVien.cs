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
    public partial class Chart_SoLuongDonTheoNhanVien : Form
    {
        public Chart_SoLuongDonTheoNhanVien()
        {
            InitializeComponent();
        }

        private void Chart_SoLuongDonTheoNhanVien_Load(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            DataTable soluongdon = bll.SoLuongDonHangTheoNhanVien();

            BindDataToChart(soluongdon);
        }

        private void BindDataToChart(DataTable dataTable)
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
    }
}
