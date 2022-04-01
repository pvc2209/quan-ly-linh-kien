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
    public class TaiKhoanDAO
    {
        public TaiKhoan CheckLogin(string username, string password)
        {
            
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                try
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
                catch(Exception)
                {
                    return null;
                }
            }
        }
        public DataTable LoadDanhSachTaiKhoan()
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "SELECT tai_khoan.* FROM tai_khoan ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public bool ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO [dbo].[tai_khoan] ([ten_tai_khoan],[mat_khau],[chuc_vu],[ho_ten],[so_dien_thoai],[dia_chi],[email]) VALUES (@ten_tai_khoan,@mat_khau,@chuc_vu,@ho_ten,@so_dien_thoai,@dia_chi,@email)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ten_tai_khoan", taiKhoan.TenTaiKhoan);
                    cmd.Parameters.AddWithValue("@mat_khau", taiKhoan.MatKhau);
                    cmd.Parameters.AddWithValue("@chuc_vu", taiKhoan.ChucVu);
                    cmd.Parameters.AddWithValue("@ho_ten", taiKhoan.HoTen);
                    cmd.Parameters.AddWithValue("@so_dien_thoai", taiKhoan.SoDienThoai);
                    cmd.Parameters.AddWithValue("@dia_chi", taiKhoan.DiaChi);
                    cmd.Parameters.AddWithValue("@email", taiKhoan.Email);
                
                    int result = cmd.ExecuteNonQuery();

                    return result > 0;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool SuaTaiKhoan(TaiKhoan taiKhoan)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE [dbo].[tai_khoan] SET [ten_tai_khoan] = @ten_tai_khoan,[mat_khau] = @mat_khau ,[chuc_vu] = @chuc_vu ,[ho_ten] = @ho_ten, [so_dien_thoai] = @so_dien_thoai,[dia_chi] = @dia_chi,[email] = @email WHERE tai_khoan.ma_tai_khoan = @ma_tai_khoan";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ten_tai_khoan", taiKhoan.TenTaiKhoan);
                    cmd.Parameters.AddWithValue("@mat_khau", taiKhoan.MatKhau);
                    cmd.Parameters.AddWithValue("@chuc_vu", taiKhoan.ChucVu);
                    cmd.Parameters.AddWithValue("@ho_ten", taiKhoan.HoTen);
                    cmd.Parameters.AddWithValue("@so_dien_thoai", taiKhoan.SoDienThoai);
                    cmd.Parameters.AddWithValue("@dia_chi", taiKhoan.DiaChi);
                    cmd.Parameters.AddWithValue("@email", taiKhoan.Email);

                    cmd.Parameters.AddWithValue("@ma_tai_khoan", taiKhoan.MaTaiKhoan);

                    int result = cmd.ExecuteNonQuery();

                    return result > 0;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool XoaTaiKhoan(TaiKhoan taiKhoan)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "DELETE FROM [dbo].[tai_khoan] WHERE tai_khoan.ma_tai_khoan = @ma_tai_khoan";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ma_tai_khoan", taiKhoan.MaTaiKhoan);

                    int result = cmd.ExecuteNonQuery();

                    return result > 0;
                }
                catch
                {
                    return false;
                }
            }
        }

        public DataTable TimKiemTaiKhoan(TaiKhoan taiKhoan)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "SELECT * FROM tai_khoan WHERE ten_tai_khoan LIKE @ten";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ten", "%"+ taiKhoan.TenTaiKhoan +"%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
    }
}
