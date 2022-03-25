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
    public class KhachHangDAO
    {
        public DataTable LoadDanhSachKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(Configs.ConnectionString))
            {
                conn.Open();

                string query = "SELECT * FROM khach_hang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable); // Lúc này câu query mới được thực thi để lấy dữ liệu về

                return dataTable;
            }
        }

        public bool ThemKhachHang(KhachHang khachHang)
        {
            using (SqlConnection conn = new SqlConnection(Configs.ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO khach_hang(ho_ten, dia_chi, so_dien_thoai, email) VALUES(@ho_ten, @dia_chi, @so_dien_thoai, @email)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ho_ten", khachHang.HoTen);
                cmd.Parameters.AddWithValue("@dia_chi", khachHang.DiaChi);
                cmd.Parameters.AddWithValue("@so_dien_thoai", khachHang.SDT);
                cmd.Parameters.AddWithValue("@email", khachHang.Email);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
        }

        public bool SuaKhachHang(KhachHang khachHang)
        {
            using (SqlConnection conn = new SqlConnection(Configs.ConnectionString))
            {
                conn.Open();

                string query = "UPDATE khach_hang SET ho_ten = @ho_ten, dia_chi = @dia_chi, so_dien_thoai = @so_dien_thoai, email = @email WHERE ma_khach_hang = @ma_khach_hang";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ho_ten", khachHang.HoTen);
                cmd.Parameters.AddWithValue("@dia_chi", khachHang.DiaChi);
                cmd.Parameters.AddWithValue("@so_dien_thoai", khachHang.SDT);
                cmd.Parameters.AddWithValue("@email", khachHang.Email);
                cmd.Parameters.AddWithValue("@ma_khach_hang", khachHang.Ma);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
        }

        public bool XoaKhachHang(int ma)
        {
            using (SqlConnection conn = new SqlConnection(Configs.ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM khach_hang WHERE ma_khach_hang = @ma_khach_hang";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ma_khach_hang", ma);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
        }

        public DataTable TimKiemKhachHang(string soDienThoai)
        {
            using (SqlConnection conn = new SqlConnection(Configs.ConnectionString))
            {
                conn.Open();

                string query = "SELECT * FROM khach_hang WHERE so_dien_thoai LIKE @so_dien_thoai";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@so_dien_thoai", "%" + soDienThoai + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
    }
}
