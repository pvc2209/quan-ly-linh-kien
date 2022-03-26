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
    public class PhieuNhapDAO
    {
        public DataTable LoadDanhSachPhieuNhap()
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "SELECT * FROM phieu_nhap";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable LoadDanhSachChiTietPhieuNhap(int maPhieuNhap)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "SELECT chi_tiet_phieu_nhap.ma_hang, ten_hang, gia_nhap, chi_tiet_phieu_nhap.so_luong FROM chi_tiet_phieu_nhap, hang " +
                    "WHERE chi_tiet_phieu_nhap.ma_hang = hang.ma_hang AND chi_tiet_phieu_nhap.ma_phieu_nhap = @maPhieuNhap";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public bool TaoPhieuNhap(PhieuNhap phieuNhap)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO phieu_nhap(ngay_tao, ma_nhan_vien) VALUES(@ngay_tao, @ma_nhan_vien)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ngay_tao", phieuNhap.NgayTao);
                cmd.Parameters.AddWithValue("@ma_nhan_vien", phieuNhap.MaNhanVien);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
        }

        public bool ThemChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO chi_tiet_phieu_nhap(ma_phieu_nhap, ma_hang, so_luong, gia_nhap) VALUES(@ma_phieu_nhap, @ma_hang, @so_luong, @gia_nhap)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ma_phieu_nhap", chiTietPhieuNhap.MaPhieuNhap);
                cmd.Parameters.AddWithValue("@ma_hang", chiTietPhieuNhap.MaHang);
                cmd.Parameters.AddWithValue("@so_luong", chiTietPhieuNhap.SoLuong);
                cmd.Parameters.AddWithValue("@gia_nhap", chiTietPhieuNhap.GiaNhap);

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

        public bool XoaChiTietPhieuNhap(int maPhieuNhap, string maHang)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM chi_tiet_phieu_nhap WHERE ma_phieu_nhap = @ma_phieu_nhap AND ma_hang = @ma_hang";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ma_phieu_nhap", maPhieuNhap);
                cmd.Parameters.AddWithValue("@ma_hang", maHang);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
        }


        public bool XoaPhieuNhap(int maPhieuNhap)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM phieu_nhap WHERE ma_phieu_nhap = @ma_phieu_nhap";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ma_phieu_nhap", maPhieuNhap);

                try
                {
                    int result = cmd.ExecuteNonQuery();

                    return result > 0;
                }
                catch (Exception)
                {
                    // Không thể xóa phiếu nhập này vì nó đang được link với chi tiết phiếu nhập
                    // Chỉ có thể xóa những phiếu nhập rỗng (ko link tới chi tiết phiếu nhập nào)
                    return false;
                }
            }
        }

        public DataTable TimKiemPhieuNhapTheoMa(string maPhieuNhap)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "SELECT * FROM phieu_nhap WHERE ma_phieu_nhap LIKE @ma_phieu_nhap";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ma_phieu_nhap", "%" + maPhieuNhap + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
    }
}
