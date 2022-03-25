using QLMuaBanLinhKien.Dal;
using QLMuaBanLinhKien.Model;
using QLMuaBanLinhKien.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanLinhKien.Controller
{
    public class QLKhachHangController
    {
        private QLKhachHangView _view;

        public QLKhachHangController(QLKhachHangView view)
        {
            _view = view;
        }
        
        public void LoadDanhSachKhachHang()
        {
            KhachHangDAO khachHangDAO = new KhachHangDAO();

            DataTable dataTable = khachHangDAO.LoadDanhSachKhachHang();

            _view.HienThiDanhSachKhachHang(dataTable);
        }
        
        public void ThemKhachHang(string hoTen, string diaChi, string soDienThoai, string email)
        {
            if (CheckValid(hoTen, diaChi, soDienThoai, email))
            {
                KhachHangDAO khachHangDAO = new KhachHangDAO();

                bool result = khachHangDAO.ThemKhachHang(new KhachHang(hoTen, diaChi, soDienThoai, email));

                if (result)
                {
                    LoadDanhSachKhachHang();
                    _view.ThongBao("Thêm khách hàng thành công!");
                }
                else
                {
                    _view.ThongBao("Thêm khách hàng thất bại!");
                }
            }
        }

        public void SuaKhachHang(string maKhachHang, string hoTen, string diaChi, string soDienThoai, string email)
        {
            if (CheckValid(hoTen, diaChi, soDienThoai, email))
            {
                try
                {
                    int ma = int.Parse(maKhachHang);

                    KhachHangDAO khachHangDAO = new KhachHangDAO();

                    bool result = khachHangDAO.SuaKhachHang(new KhachHang(ma, hoTen, diaChi, soDienThoai, email));

                    if (result)
                    {
                        LoadDanhSachKhachHang();
                        _view.ThongBao("Sửa khách hàng thành công!");
                    }
                    else
                    {
                        _view.ThongBao("Sửa khách hàng thất bại!");
                    }
                }
                catch (FormatException)
                {
                    _view.ThongBao("Mã khách hàng không hợp lệ!");
                    return;
                }
            }
        }

        public void XoaKhachHang(string maKhachHang)
        {
            try
            {
                int ma = int.Parse(maKhachHang);

                KhachHangDAO khachHangDAO = new KhachHangDAO();

                bool result = khachHangDAO.XoaKhachHang(ma);

                if (result)
                {
                    LoadDanhSachKhachHang();
                    _view.ThongBao("Xóa khách hàng thành công!");
                }
                else
                {
                    _view.ThongBao("Xóa khách hàng thất bại!");
                }
            }
            catch (FormatException)
            {
                _view.ThongBao("Mã khách hàng không hợp lệ!");
                return;
            }
        }
        
        public void TimKiemKhachHang(string soDienThoai)
        {
            KhachHangDAO khachHangDAO = new KhachHangDAO();

            DataTable dataTable = khachHangDAO.TimKiemKhachHang(soDienThoai);

            _view.HienThiDanhSachKhachHang(dataTable);
        }

        private bool CheckValid(string hoTen, string diaChi, string soDienThoai, string email)
        {
            if (hoTen.Length == 0)
            {
                _view.ThongBao("Tên khách hàng không được để trống");
                return false;
            }

            if (diaChi.Length == 0)
            {
                _view.ThongBao("Địa chỉ không được để trống");
                return false;
            }

            if (soDienThoai.Length == 0)
            {
                _view.ThongBao("Số điện thoại không được để trống");
                return false;
            }

            if (email.Length == 0)
            {
                _view.ThongBao("Email không được để trống");
                return false;
            }

            if (soDienThoai.Length != 10)
            {
                _view.ThongBao("Số điện thoại phải có 10 số");
                return false;
            }

            if (email.Length > 0)
            {
                if (!email.Contains("@"))
                {
                    _view.ThongBao("Email không hợp lệ");
                    return false;
                }
            }

            return true;
        }
    }
}
