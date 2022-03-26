using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanLinhKien.Dal
{
    public class ThongKeDAO
    {
        public DataTable tkTheoThang(string nam)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "SELECT MONTH(ngay_tao) AS 'Tháng',Year(ngay_tao) AS 'Năm', SUM(thanh_tien) AS 'Doanh thu' FROM hoa_don Where Year(ngay_tao) = @nam GROUP BY MONTH(ngay_tao),Year (ngay_tao)";
                SqlCommand cmd = new SqlCommand(query,conn);

                cmd.Parameters.AddWithValue("@nam", int.Parse(nam));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable tkTongTienNhapTheoThang(string nam)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                string query = "SELECT MONTH(ngay_tao) AS 'Tháng',Year(ngay_tao) AS 'Năm', SUM(gia_nhap*so_luong) AS 'Doanh thu' FROM chi_tiet_phieu_nhap, phieu_nhap Where Year(phieu_nhap.ngay_tao) = @nam and phieu_nhap.ma_phieu_nhap = chi_tiet_phieu_nhap.ma_phieu_nhap GROUP BY MONTH(ngay_tao),Year(ngay_tao)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nam", int.Parse(nam));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
