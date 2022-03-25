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
                    return false;
                }
            }
        }
    }
}
