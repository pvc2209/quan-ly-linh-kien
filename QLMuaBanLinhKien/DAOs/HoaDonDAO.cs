using CuaHangLinhKienCode.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLinhKienCode.DAO
{
    public class HoaDonDAO
    {

        public DataTable getSelectALL_HoaDon()
        {
            string query = "SELECT [ma_hoa_don],[ngay_tao],[thanh_tien],[ma_nhan_vien],KhachHang.ma_khac_hang,KhachHang.ho_ten FROM [dbo].[HoaDon], KhachHang Where HoaDon.ma_khach_hang = KhachHang.ma_khac_hang";
            return DAOProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getSelectAll_ChiTietHoaDon(HoaDon hoaDon)
        {
            string query = $"SELECT  Hang.ma_hang, Hang.ten_hang,Hang.gia_ban ,ChiTietHoaDon.so_luong FROM [dbo].[ChiTietHoaDon], Hang Where ChiTietHoaDon.ma_hang = Hang.ma_hang and ChiTietHoaDon.ma_hoa_don = {hoaDon.MaHoaDon}";
            return DAOProvider.Instance.ExecuteQuery(query); 
        }

        public bool taoHoaDon(HoaDon hoaDon)
        {
            string query = $"INSERT INTO [dbo].[HoaDon]VALUES({hoaDon.MaHoaDon},'{hoaDon.NgayTao}',{hoaDon.ThanhTien},{hoaDon.NhanVien.MaTaiKhoan},{hoaDon.KhachHang.MaKhachHang})";
            DAOProvider.Instance.ExecuteNonQuery(query);


            return true;
        }

        public bool taoChiTietHoaDon(HoaDon hoaDon)
        {
            int i = 0;

            foreach (Hang item in hoaDon.Hangs)
            {
                try
                {
                    string query = $"INSERT INTO[dbo].[ChiTietHoaDon] VALUES({hoaDon.MaHoaDon},'{item.MaHang}',{hoaDon.SoLuong[i]})";
                    DAOProvider.Instance.ExecuteNonQuery(query);
                    i++;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return true;
        }

        public bool xoaHoaDon(HoaDon hoaDon)
        {
            string query = $"DELETE FROM [dbo].[ChiTietHoaDon] WHERE ChiTietHoaDon.ma_hoa_don = {hoaDon.MaHoaDon}";
            DAOProvider.Instance.ExecuteNonQuery(query);

            query = $"DELETE FROM [dbo].[HoaDon] WHERE HoaDon.ma_hoa_don = {hoaDon.MaHoaDon}";
            DAOProvider.Instance.ExecuteNonQuery(query);

            if (DAOProvider.Instance.ExecuteNonQuery(query) > 0)
                return true;
            else
                return false;
        }

        public bool suaHoaDon(HoaDon hoaDon)
        {
            try
            {
                string query = $"UPDATE [dbo].[HoaDon] SET [ngay_tao] = '{hoaDon.NgayTao}' ,[thanh_tien] = {hoaDon.ThanhTien},[ma_nhan_vien] = {hoaDon.NhanVien.MaTaiKhoan},[ma_khach_hang] = {hoaDon.KhachHang.MaKhachHang} WHERE HoaDon.ma_hoa_don = {hoaDon.MaHoaDon}";
                DAOProvider.Instance.ExecuteNonQuery(query);
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public DataTable timKiemHoaDon(HoaDon hoaDon)
        {
            string query = $"SELECT HoaDon.* From HoaDon Where HoaDon.ma_hoa_don = {hoaDon.MaHoaDon}";
            return DAOProvider.Instance.ExecuteQuery(query);
        }
    }
}
