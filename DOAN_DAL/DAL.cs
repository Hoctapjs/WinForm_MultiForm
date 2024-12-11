using System.Data;
using System.Data.SqlClient;
using DOAN_DTO;
using System.IO;
using System.Collections.Generic;

namespace DOAN_DAL
{
    public class DAL
    {
        private string connectionString = "Data Source=DESKTOP-D6O7BPB\\SQLEXPRESS;Initial Catalog=QL_TRASUA1;User ID=sa;Password=123;";

        // get dataload
        public DataTable GetAllSanPham()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM SANPHAM";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public List<SANPHAMDTO> GetListSanPham()
        {
            List<SANPHAMDTO> listsanpham = new List<SANPHAMDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SANPHAM";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    SANPHAMDTO sanpham = new SANPHAMDTO();
                    sanpham.MASP = rdr.GetInt32(0);
                    sanpham.TENSP = rdr.GetString(1);
                    sanpham.GIA = rdr.GetDecimal(2);
                    sanpham.KICHTHUOC = rdr.GetString(3);
                    sanpham.DUONGDAN = rdr.GetString(4);
                    listsanpham.Add(sanpham);
                }

            }

            return listsanpham;
        }

        public int GetKhachHangMoiNhat()
        {
            int makhmoi;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "select Top 1 MAKH from KHACHHANG ORDER BY MAKH DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                makhmoi = int.Parse(cmd.ExecuteScalar().ToString());
            }
            return makhmoi;
        }

        public DataTable GetAllNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM NHANVIEN";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetAllDonHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM DONHANG";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetAllChiTietDonHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT CHITIETDONHANG.*, TENSP FROM CHITIETDONHANG JOIN SANPHAM ON CHITIETDONHANG.MASP = SANPHAM.MASP ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetAllKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM KHACHHANG";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetMaDH_From_DONHANG()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MADH AS MADH FROM DONHANG";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetMaSP_From_SANPHAM()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MASP AS MASP, TENSP AS TENSP FROM SANPHAM";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetMaKH_From_KHACHHANG()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MAKH AS MAKH FROM KHACHHANG";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public List<int> GetListMaKH_From_KHACHHANG()
        {
            List<int> list = new List<int>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MAKH AS MAKH FROM KHACHHANG";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int makh;
                    makh = rdr.GetInt32(0);
                    list.Add(makh);
                }
            }
            return list;
        }

        public List<int> GetListMaDH_From_DONHANG()
        {
            List<int> list = new List<int>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MADH AS MADH FROM DONHANG";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int madh;
                    madh = rdr.GetInt32(0);
                    list.Add(madh);
                }
            }
            return list;
        }

        public DataTable GetAllNV_TEN_QUYEN()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TENNV, QUYEN FROM NHANVIEN";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetAllNgayThangNam()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT FORMAT(NGAYLAP, 'yyyy-MM-dd') AS NgayThangNam FROM DONHANG;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetAllThangNam()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT FORMAT(NGAYLAP, 'MM') AS ThangNam FROM DONHANG;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetAllNam()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT YEAR(NGAYLAP) AS Nam FROM DONHANG GROUP BY YEAR(NGAYLAP)";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public float TongDoanhThuTheoNam(int nam)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $"SELECT SUM(TONGGIA) FROM DONHANG WHERE YEAR(NGAYLAP) = {nam}";
                SqlCommand cmd = new SqlCommand(query, conn);
                float so = 0;
                decimal kq;

                try
                {
                    kq = (decimal)cmd.ExecuteScalar();
                    so = (float)kq;
                }
                catch (Exception)
                {

                    throw;
                }
                return so;
            }
        }

        public float TongDoanhThuTheoThang(int thang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $"SELECT SUM(TONGGIA) AS TONGDOANHTHU FROM DONHANG WHERE MONTH(NGAYLAP) = {thang} AND YEAR(NGAYLAP) = YEAR(GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);
                float so = 0;
                decimal kq;

                try
                {
                    kq = (decimal)cmd.ExecuteScalar();
                    so = (float)kq;
                }
                catch (Exception)
                {

                    throw;
                }
                return so;
            }
        }

        public float TongDoanhThuTheoNgay(string ngay)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $"SELECT SUM(TONGGIA) FROM DONHANG WHERE NGAYLAP = '{ngay}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                float so = 0;
                decimal kq;
                try
                {
                    kq = (decimal)cmd.ExecuteScalar();
                    so = (float)kq;
                }
                catch (Exception)
                {

                    throw;
                }
                return so;
            }
        }

        public int GetSoKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM KHACHHANG";
                SqlCommand cmd = new SqlCommand(query, conn);
                int so = 0;
                try
                {
                    so = (int)cmd.ExecuteScalar();
                }
                catch (Exception)
                {

                    throw;
                }
                return so;
            }
        }

        public int GetSoSanPham()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM SANPHAM";
                SqlCommand cmd = new SqlCommand(query, conn);
                int so = 0;
                try
                {
                    so = (int)cmd.ExecuteScalar();
                }
                catch (Exception)
                {

                    throw;
                }
                return so;
            }
        }

        public int GetSoDonHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM DONHANG";
                SqlCommand cmd = new SqlCommand(query, conn);
                int so = 0;
                try
                {
                    so = (int)cmd.ExecuteScalar();
                }
                catch (Exception)
                {

                    throw;
                }
                return so;
            }
        }

        // Thêm sản phẩm
        public bool ThemSanPham(SANPHAMDTO sp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO SANPHAM (TENSP, GIA, KICHTHUOC, DUONGDAN) VALUES (@TENSP, @GIA, @KICHTHUOC, @DUONGDAN)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TENSP", sp.TENSP);
                cmd.Parameters.AddWithValue("@GIA", sp.GIA);
                cmd.Parameters.AddWithValue("@KICHTHUOC", sp.KICHTHUOC ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DUONGDAN", sp.DUONGDAN);


                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Sửa sản phẩm
        public bool SuaSanPham(SANPHAMDTO sp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE SANPHAM SET TENSP = @TENSP, GIA = @GIA, KICHTHUOC = @KICHTHUOC, DUONGDAN = @DUONGDAN WHERE MASP = @MASP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MASP", sp.MASP);
                cmd.Parameters.AddWithValue("@TENSP", sp.TENSP);
                cmd.Parameters.AddWithValue("@GIA", sp.GIA);
                cmd.Parameters.AddWithValue("@KICHTHUOC", sp.KICHTHUOC ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DUONGDAN", sp.DUONGDAN);


                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa sản phẩm
        public bool XoaSanPham(int maSP)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM SANPHAM WHERE MASP = @MASP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MASP", maSP);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // TẠM XONG SẢN PHẨM

        // BẮT ĐẦU KHÁCH HÀNG
        // Thêm khách hàng
        public bool ThemKhachHang(KHACHHANGDTO kh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO KHACHHANG (TENKH, SODT, DIACHI) VALUES (@TENKH, @SODT, @DIACHI)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TENKH", kh.TENKH);
                cmd.Parameters.AddWithValue("@SODT", kh.SODT);
                cmd.Parameters.AddWithValue("@DIACHI", kh.DIACHI ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool ThemKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO KHACHHANG (TENKH, SODT, DIACHI) VALUES (NULL, NULL, NULL)";
                SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@TENKH", kh.TENKH);
                //cmd.Parameters.AddWithValue("@SODT", kh.SODT);
                //cmd.Parameters.AddWithValue("@DIACHI", kh.DIACHI ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Sửa khách hàng
        public bool SuaKhachHang(KHACHHANGDTO kh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE KHACHHANG SET TENKH = @TENKH, SODT = @SODT, DIACHI = @DIACHI WHERE MAKH = @MAKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAKH", kh.MAKH);
                cmd.Parameters.AddWithValue("@TENKH", kh.TENKH);
                cmd.Parameters.AddWithValue("@SODT", kh.SODT);
                cmd.Parameters.AddWithValue("@DIACHI", kh.DIACHI ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool SuaKhachHang(int makh, string thanhvien)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE KHACHHANG SET THANHVIEN = @THANHVIEN WHERE MAKH = @MAKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAKH", makh);
                cmd.Parameters.AddWithValue("@THANHVIEN", thanhvien);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa khách hàng
        public bool XoaKhachHang(int maKH)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM KHACHHANG WHERE MAKH = @MAKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAKH", maKH);
                try
                {
                    return cmd.ExecuteNonQuery() > 0;

                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
        }

        // TẠM XONG KHÁCH HÀNG

        // BẮT ĐẦU NHÂN VIÊN
        // Thêm nhân viên
        public bool ThemNhanVien(NHANVIENDTO nv)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO NHANVIEN (TENNV, QUYEN, USERNAME, PASSWORD) VALUES (@TENNV, @QUYEN, @USERNAME, @PASSWORD)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TENNV", nv.TENNV);
                cmd.Parameters.AddWithValue("@QUYEN", nv.QUYEN);
                cmd.Parameters.AddWithValue("@USERNAME", nv.USERNAME);
                cmd.Parameters.AddWithValue("@PASSWORD", nv.PASSWORD);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Sửa nhân viên
        public bool SuaNhanVien(NHANVIENDTO nv)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE NHANVIEN SET TENNV = @TENNV, QUYEN = @QUYEN, USERNAME = @USERNAME, PASSWORD = @PASSWORD WHERE MANV = @MANV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MANV", nv.MANV);
                cmd.Parameters.AddWithValue("@TENNV", nv.TENNV);
                cmd.Parameters.AddWithValue("@QUYEN", nv.QUYEN);
                cmd.Parameters.AddWithValue("@USERNAME", nv.USERNAME);
                cmd.Parameters.AddWithValue("@PASSWORD", nv.PASSWORD);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa nhân viên
        public bool XoaNhanVien(int maNV)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM NHANVIEN WHERE MANV = @MANV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MANV", maNV);
                try
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
        }

        // TẠM XONG NHÂN VIÊN

        // BẮT ĐẦU ĐƠN HÀNG
        // Thêm đơn hàng
        public bool ThemDonHang(DONHANGDTO dh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO DONHANG (MAKH, MANV, NGAYLAP, TONGGIA) VALUES (@MAKH, @MANV, GETDATE(), @TONGGIA)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAKH", dh.MAKH);
                cmd.Parameters.AddWithValue("@MANV", dh.MANV);
                cmd.Parameters.AddWithValue("@TONGGIA", dh.TONGGIA);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Sửa đơn hàng
        public bool SuaDonHang(DONHANGDTO dh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE DONHANG SET MAKH = @MAKH, NGAYLAP = GETDATE(), TONGGIA = @TONGGIA, MAKM = @MAKM WHERE MADH = @MADH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MADH", dh.MADH);
                cmd.Parameters.AddWithValue("@MAKH", dh.MAKH);
                cmd.Parameters.AddWithValue("@MAKM", dh.MAKM);
                cmd.Parameters.AddWithValue("@TONGGIA", dh.TONGGIA);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool SuaDonHang(int madonhang, int makm)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE DONHANG SET MAKM = @MAKM WHERE MADH = @MADH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MADH", madonhang);
                cmd.Parameters.AddWithValue("@MAKM", makm);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa đơn hàng
        public bool XoaDonHang(int maDH)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM DONHANG WHERE MADH = @MADH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MADH", maDH);
                try
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
        }

        // TẠM KẾT THÚC ĐƠN HÀNG

        // BẮT ĐẦU CHI TIẾT ĐƠN HÀNG
        // Thêm chi tiết đơn hàng
        public bool ThemChiTietDonHang(CHITIETDONHANGDTO ct)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO CHITIETDONHANG (MADH, MASP, SOLUONG, GIA) VALUES (@MADH, @MASP, @SOLUONG, @GIA)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MADH", ct.MADH);
                    cmd.Parameters.AddWithValue("@MASP", ct.MASP);
                    cmd.Parameters.AddWithValue("@SOLUONG", ct.SOLUONG);
                    cmd.Parameters.AddWithValue("@GIA", ct.GIA);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        // Sửa chi tiết đơn hàng
        public bool SuaChiTietDonHang(CHITIETDONHANGDTO ct)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE CHITIETDONHANG SET SOLUONG = @SOLUONG, GIA = @GIA WHERE MADH = @MADH AND MASP = @MASP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MADH", ct.MADH);
                cmd.Parameters.AddWithValue("@MASP", ct.MASP);
                cmd.Parameters.AddWithValue("@SOLUONG", ct.SOLUONG);
                cmd.Parameters.AddWithValue("@GIA", ct.GIA);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa chi tiết đơn hàng
        public bool XoaChiTietDonHang(int maDH, int maSP)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM CHITIETDONHANG WHERE MADH = @MADH AND MASP = @MASP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MADH", maDH);
                cmd.Parameters.AddWithValue("@MASP", maSP);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // TẠM XONG CHI TIẾT ĐƠN HÀNG

        // ĐẾN VỚI LOGIN
        // Phương thức kiểm tra đăng nhập
        public NHANVIENDTO KiemTraDangNhap(string username, string password)
        {
            NHANVIENDTO nhanVien = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM NHANVIEN WHERE USERNAME = @USERNAME AND PASSWORD = @PASSWORD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@USERNAME", username);
                cmd.Parameters.AddWithValue("@PASSWORD", password);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nhanVien = new NHANVIENDTO
                        {
                            MANV = Convert.ToInt32(reader["MANV"]),
                            TENNV = reader["TENNV"].ToString(),
                            QUYEN = reader["QUYEN"].ToString(),
                            USERNAME = reader["USERNAME"].ToString(),
                            PASSWORD = reader["PASSWORD"].ToString()
                        };
                    }
                }
            }
            return nhanVien;
        }

        public bool DoiMatKhau(string username, string password_new)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE NHANVIEN SET PASSWORD = @PASSWORD WHERE USERNAME = @USERNAME";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@USERNAME", username);
                cmd.Parameters.AddWithValue("@PASSWORD", password_new);
                
                int kq = cmd.ExecuteNonQuery();

                if (kq!= 0)
                {
                    return true;
                }

                //using (SqlDataReader reader = cmd.ExecuteReader())
                //{
                //    if (reader.Read())
                //    {
                //        nhanVien = new NHANVIENDTO
                //        {
                //            MANV = Convert.ToInt32(reader["MANV"]),
                //            TENNV = reader["TENNV"].ToString(),
                //            QUYEN = reader["QUYEN"].ToString(),
                //            USERNAME = reader["USERNAME"].ToString(),
                //            PASSWORD = reader["PASSWORD"].ToString()
                //        };
                //    }
                //}
            }
            return false;
        }
        // tạm xong login

        // BẮT ĐẦU khuyến mãi
        // get all khuyến mãi

        public DataTable GetAllKhuyenMai()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM CHUONGTRINH_KHUYENMAI";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetAll_Ma_KhuyenMai()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DECLARE @KQ INT; SET @KQ = dbo.FUN_LAYMAKHUYENMAI(); SELECT* FROM FUN_LAYMAKM_TABLE(@KQ);";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Thêm khuyến mãi
        public bool ThemKhuyenMai(KHUYENMAIDTO km)
        {
            if (km.Ngaybd == DateTime.MinValue || km.Ngaybd == DateTime.MinValue)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO CHUONGTRINH_KHUYENMAI (TENKM, PHAMTRAM_KM) VALUES (@TENKM, @HESO)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TENKM", km.Tenkm);
                    cmd.Parameters.AddWithValue("@HESO", km.Hesokm);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO CHUONGTRINH_KHUYENMAI (TENKM, NGAYBD, NGAYKT, PHAMTRAM_KM) VALUES (@TENKM, @NGAYBD, @NGAYKT, @HESO)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TENKM", km.Tenkm);
                    cmd.Parameters.AddWithValue("@NGAYBD", km.Ngaybd);
                    cmd.Parameters.AddWithValue("@NGAYKT", km.Ngaykt);
                    cmd.Parameters.AddWithValue("@HESO", km.Hesokm);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            
        }

        // Sửa khuyến mãi
        public bool SuaKhuyenMai(KHUYENMAIDTO km)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE CHUONGTRINH_KHUYENMAI SET TENKM = @TENKM, NGAYBD = @NGAYBD, NGAYKT = @NGAYKT, PHAMTRAM_KM = @HESO WHERE MAKM = @MAKM";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TENKM", km.Tenkm);
                    cmd.Parameters.AddWithValue("@NGAYBD", km.Ngaybd);
                    cmd.Parameters.AddWithValue("@NGAYKT", km.Ngaykt);
                    cmd.Parameters.AddWithValue("@HESO", km.Hesokm);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        // Xóa khuyến mãi
        public bool XoaKhuyenMai(int MAKM)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM CHUONGTRINH_KHUYENMAI WHERE MAKM = @MAKM";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAKM", MAKM);
                try
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
        }

        // bắt đầu đăng ký
        public bool DangKy(string hovaten, string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO NHANVIEN (TENNV, QUYEN, USERNAME, PASSWORD) VALUES (@TENNV, NULL, @USERNAME, @PASSWORD)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TENNV", hovaten);
                cmd.Parameters.AddWithValue("@USERNAME", username);
                cmd.Parameters.AddWithValue("@PASSWORD", password);
                try
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
        }

        // biểu đồ 1 số lượng đơn theo nhân viên
        public DataTable SoLuongDonHangTheoNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT NV.TENNV, COUNT(DH.MANV) AS SoLuongDonHang FROM DONHANG DH JOIN NHANVIEN NV ON DH.MANV = NV.MANV GROUP BY NV.TENNV;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // biểu đồ 2
        public DataTable TongDoanhThuTheoNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT NV.TENNV, SUM(DH.TONGGIA) AS TongDoanhThu FROM DONHANG DH JOIN NHANVIEN NV ON DH.MANV = NV.MANV GROUP BY NV.TENNV;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // biểu đồ 3
        public DataTable SoLuongSanPhamBanDuoc()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MASP, SUM(SOLUONG) AS TongSoLuong FROM CHITIETDONHANG GROUP BY MASP;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // biểu đồ 4
        public DataTable TopSanPhamBanChay()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TOP 10 MASP, SUM(SOLUONG) AS TongSoLuong FROM CHITIETDONHANG GROUP BY MASP ORDER BY TongSoLuong DESC;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

    }
}