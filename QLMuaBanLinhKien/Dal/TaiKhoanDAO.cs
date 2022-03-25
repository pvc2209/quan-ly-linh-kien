using QLMuaBanLinhKien.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanLinhKien.Dal
{
    public class TaiKhoanDAO
    {
        public TaiKhoan CheckLogin(string username, string password)
        {
            
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();
                string query = $"SELECT * FROM tai_khoan WHERE ten_tai_khoan = @ten_tai_khoan AND mat_khau = @mat_khau";

                SqlCommand cmd = new SqlCommand(query, conn);

                
                cmd.Parameters.AddWithValue("@ten_tai_khoan", username);
                cmd.Parameters.AddWithValue("@mat_khau", password);

                var reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {

                    int maTaiKhoan = (int)reader["ma_tai_khoan"];
                    string tenTaiKhoan = (string)reader["ten_tai_khoan"];
                    string matKhau = (string)reader["mat_khau"];
                    string chucVu = (string)reader["chuc_vu"];
                    string hoTen = (string)reader["ho_ten"];
                    string sdt = (string)reader["so_dien_thoai"];
                    string diaChi = (string)reader["dia_chi"];
                    string email = (string)reader["email"];

                    return new TaiKhoan(maTaiKhoan, tenTaiKhoan, matKhau, chucVu, hoTen, sdt, diaChi, email);
                }

                return null;
            }
        }
    }
}
