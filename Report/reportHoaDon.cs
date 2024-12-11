using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Report
{
    public partial class reportHoaDon : Form
    {
        public reportHoaDon()
        {
            InitializeComponent();
        }

        private void reportHoaDon_Load(object sender, EventArgs e)
        {
            string hotenkhachhang = "Trần Văn Tèo";
            string sodt = "0812727532";

            //Tham số đơn (Parameter)
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("HOTENKHACHHANG", hotenkhachhang);
            parameters[1] = new ReportParameter("SODIENTHOAIKHACH", sodt);

            reportViewer1.LocalReport.SetParameters(parameters);

            //DataSource
            var donHangReports = new List<DONHANG_REPORT>
            {
                new DONHANG_REPORT { MADH = 1, MAKH = 101, MANV = 201, NGAYLAP = "2024-12-01", TONGGIA = 1000000, MAKM = 301 },
                new DONHANG_REPORT { MADH = 2, MAKH = 102, MANV = 202, NGAYLAP = "2024-12-02", TONGGIA = 2000000, MAKM = 302 },
                new DONHANG_REPORT { MADH = 3, MAKH = 103, MANV = 203, NGAYLAP = "2024-12-03", TONGGIA = 3000000, MAKM = 303 },
                new DONHANG_REPORT { MADH = 4, MAKH = 104, MANV = 204, NGAYLAP = "2024-12-04", TONGGIA = 4000000, MAKM = 304 },
                new DONHANG_REPORT { MADH = 5, MAKH = 105, MANV = 205, NGAYLAP = "2024-12-05", TONGGIA = 5000000, MAKM = 305 },
            };

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DONHANG", donHangReports));
            this.reportViewer1.RefreshReport();
        }
    }
}
