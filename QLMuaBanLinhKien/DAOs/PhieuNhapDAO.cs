﻿using CuaHangLinhKienCode.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLinhKienCode.DAO
{
    public class PhieuNhapDAO
    {
        string selectALL = " SELECT PhieuNhap.* FROM PhieuNhap";
        
        public DataTable getSelectALL()
        {
            return DAOProvider.Instance.ExecuteQuery(selectALL); 
        } 

        public DataTable getSelectALLChiTietPN(PhieuNhap phieuNhap)
        {
            string selectALLCTPN = $"SELECT Hang.ten_hang,ChiTietPhieuNhap.* FROM [dbo].[ChiTietPhieuNhap], Hang Where [ChiTietPhieuNhap].ma_hang=  Hang.ma_hang And ChiTietPhieuNhap.ma_phieu_nhap = {phieuNhap.MaPhieuNhap} ";
            return DAOProvider.Instance.ExecuteQuery(selectALLCTPN);
        }

        public bool taoPhieuNhap(PhieuNhap phieuNhap)
        {
            try
            {
                string query = $"INSERT INTO [dbo].[PhieuNhap] VALUES ({phieuNhap.MaPhieuNhap}, '{phieuNhap.NgayTao}',{phieuNhap.MaNhanVien.MaTaiKhoan})";
                DAOProvider.Instance.ExecuteNonQuery(query);
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public bool taoChiTietPhieuNhap(PhieuNhap phieuNhap)
        {
            int i = 0;
            foreach (Hang item in phieuNhap.Hangs)
            {
                string query = $"INSERT INTO [dbo].[ChiTietPhieuNhap] VALUES ({phieuNhap.MaPhieuNhap},'{item.MaHang}',{phieuNhap.GiaNhap[i]},{phieuNhap.SoLuong[i]})";
                i++;
                try
                {
                    DAOProvider.Instance.ExecuteNonQuery(query);
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return true;
        }

        public bool xoaPhieuNhap(PhieuNhap phieuNhap)
        {
            string query = $"DELETE FROM [dbo].[ChiTietPhieuNhap] WHERE ma_phieu_nhap = {phieuNhap.MaPhieuNhap}";

            string query2 = $"DELETE FROM[dbo].[PhieuNhap]WHERE ma_phieu_nhap = {phieuNhap.MaPhieuNhap}";

            try
            {
                DAOProvider.Instance.ExecuteNonQuery(query);
            }catch(Exception e)
            {

            }
            
            if (DAOProvider.Instance.ExecuteNonQuery(query2) > 0)
                return false;
            else
                return true;
        }

        public bool suaPhieuNhap(PhieuNhap phieuNhap)
        {
            string query = $"UPDATE [dbo].[PhieuNhap] SET [nga_tao] = '{phieuNhap.NgayTao}',[ma_nhan_vien] = {phieuNhap.MaNhanVien.MaTaiKhoan} WHERE ma_phieu_nhap = {phieuNhap.MaPhieuNhap}";
            DAOProvider.Instance.ExecuteNonQuery(query);

            int i = 0;

            foreach(Hang item in phieuNhap.Hangs)
            {
                query = $"UPDATE [dbo].[ChiTietPhieuNhap] SET [ma_hang] = '{item.MaHang}',[gia_nhap] = {phieuNhap.GiaNhap[i]},[so_luong] = {phieuNhap.SoLuong[i]} WHERE [ma_phieu_nhap] = {phieuNhap.MaPhieuNhap}";
                i++;
                try
                {
                    DAOProvider.Instance.ExecuteNonQuery(query);
                }catch(Exception e)
                {
                    return false;
                }
                
            }

            return true;
        }

        public DataTable timKiemPhieuNhap(PhieuNhap phieuNhap)
        {
            string query = $"SELECT PhieuNhap.* From PhieuNhap WHERE PhieuNhap.ma_phieu_nhap Like '{phieuNhap.MaPhieuNhap}%'";
            return DAOProvider.Instance.ExecuteQuery(query);
        }
    
    }
}
