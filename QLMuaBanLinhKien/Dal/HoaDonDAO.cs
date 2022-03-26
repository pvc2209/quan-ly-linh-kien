using QLMuaBanLinhKien.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanLinhKien.Dal
{
    public class HoaDonDAO
    {
        public DataTable LoadDanhSachHoaDon()
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "SELECT * FROM hoa_don";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
            
        }
        
        public DataTable LoadDanhSachChiTietHoaDon(string maHoaDon)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "SELECT chi_tiet_hoa_don.ma_hang, ten_hang, gia_ban, chi_tiet_hoa_don.so_luong FROM chi_tiet_hoa_don, hang WHERE chi_tiet_hoa_don.ma_hang = hang.ma_hang AND chi_tiet_hoa_don.ma_hoa_don = @maHoaDon";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@maHoaDon", maHoaDon);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
        
        public bool TaoHoaDon(HoaDon hoaDon)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO hoa_don(ngay_tao, ma_nhan_vien, ma_khach_hang, thanh_tien) VALUES(@ngayTao, @maNhanVien, @maKhachHang, @thanhTien)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@ngayTao", hoaDon.NgayTao);
                command.Parameters.AddWithValue("@maNhanVien", hoaDon.MaNV);
                command.Parameters.AddWithValue("@maKhachHang", hoaDon.MaKH);
                
                // Khi tạo hóa đơn thì lúc đó chưa có món hàng nào trong hóa đơn
                // nên thanhTien = 0
                command.Parameters.AddWithValue("@thanhTien", 0);

                try
                {
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception)
                {
                    // Trường hợp mã khách hàng chưa tồn tại
                    return false;
                }
                
            }
        }

        public bool ThemChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO chi_tiet_hoa_don(ma_hoa_don, ma_hang, so_luong) VALUES(@ma_hoa_don, @ma_hang, @so_luong)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ma_hoa_don", chiTietHoaDon.MaHD);
                cmd.Parameters.AddWithValue("@ma_hang", chiTietHoaDon.MaHang);
                cmd.Parameters.AddWithValue("@so_luong", chiTietHoaDon.SoLuong);

                try
                {
                    int result = cmd.ExecuteNonQuery();

                    return result > 0;
                }
                catch (Exception)
                {
                    // Khi mã hàng trong chi tiết phiếu nhập ko tồn tại
                    // => Không thể thêm chi tiết phiếu nhập
                    // => Phải thêm thông tin hàng trước
                    return false;
                }
            }
        }

        public bool TangThanhTien(ChiTietHoaDon chiTietHoaDon, Hang hang)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "UPDATE hoa_don SET thanh_tien = thanh_tien + @gia_ban WHERE ma_hoa_don = @ma_hoa_don";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@gia_ban", hang.GiaBan * chiTietHoaDon.SoLuong);
                cmd.Parameters.AddWithValue("@ma_hoa_don", chiTietHoaDon.MaHD);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
        }

        public bool GiamThanhTien(ChiTietHoaDon chiTietHoaDon, Hang hang)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "UPDATE hoa_don SET thanh_tien = thanh_tien - @gia_ban WHERE ma_hoa_don = @ma_hoa_don";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@gia_ban", hang.GiaBan * chiTietHoaDon.SoLuong);
                cmd.Parameters.AddWithValue("@ma_hoa_don", chiTietHoaDon.MaHD);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
        }

        public bool XoaChiTietHoaDon(int maHoaDon, string maHang)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM chi_tiet_hoa_don WHERE ma_hoa_don = @ma_hoa_don AND ma_hang = @ma_hang";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ma_hoa_don", maHoaDon);
                cmd.Parameters.AddWithValue("@ma_hang", maHang);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
        }

        public bool XoaHoaDon(int maHoaDon)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM hoa_don WHERE ma_hoa_don = @ma_hoa_don";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ma_hoa_don", maHoaDon);

                try
                {
                    int result = cmd.ExecuteNonQuery();

                    return result > 0;
                }
                catch (Exception)
                {
                    // Không thể xóa hóa đơn này vì nó đang được link với chi tiết hóa đơn
                    // Chỉ có thể xóa những hóa đơn rỗng (ko link tới chi tiết hóa đơn nào)
                    return false;
                }
            }
        }

        public DataTable TimKiemHoaDonTheoMa(string maHoaDon)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "SELECT * FROM hoa_don WHERE ma_hoa_don LIKE @ma_hoa_don";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ma_hoa_don", "%" + maHoaDon + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
    }
}
