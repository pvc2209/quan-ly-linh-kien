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
    public class HangDAO
    {
        public DataTable LoadDanhSachMatHang()
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "SELECT * FROM hang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public bool ThemHang(Hang hang)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO hang VALUES(@MaHang, @TenHang, @GiaBan, @SoLuong)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHang", hang.MaHang);
                cmd.Parameters.AddWithValue("@TenHang", hang.TenHang);
                cmd.Parameters.AddWithValue("@GiaBan", hang.GiaBan);

                // Khi thêm mới thông tin hàng thì số lượng luôn là 0
                cmd.Parameters.AddWithValue("@SoLuong", 0);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
        
        public bool SuaHang(Hang hang)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "UPDATE hang SET ten_hang = @TenHang, gia_ban = @GiaBan, so_luong = @SoLuong WHERE ma_hang = @MaHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHang", hang.MaHang);
                cmd.Parameters.AddWithValue("@TenHang", hang.TenHang);
                cmd.Parameters.AddWithValue("@GiaBan", hang.GiaBan);
                cmd.Parameters.AddWithValue("@SoLuong", hang.SoLuong);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool XoaHang(string maHang)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM hang WHERE ma_hang = @MaHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHang", maHang);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
        
        public DataTable TimKiemHangTheoTen(string tenHang)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "SELECT * FROM hang WHERE ten_hang LIKE @TenHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenHang", "%" + tenHang + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable TimKiemHangTheoMa(string maHang)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "SELECT * FROM hang WHERE ma_hang LIKE @MaHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHang", "%" + maHang + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
    }
}
