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
    public class QLBanHangController
    {
        private QLBanHangView _view;

        public QLBanHangController(QLBanHangView view)
        {
            _view = view;
        }
        
        public void LoadDanhSachHoaDon()
        {
            HoaDonDAO hoaDonDAO = new HoaDonDAO();

            DataTable dataTable = hoaDonDAO.LoadDanhSachHoaDon();

            _view.HienThiDanhSachHoaDon(dataTable);
        }

        public void LoadDanhSachHangCuaHoaDon(string maHoaDon)
        {
            HoaDonDAO hoaDonDAO = new HoaDonDAO();

            DataTable dataTable = hoaDonDAO.LoadDanhSachChiTietHoaDon(maHoaDon);

            _view.HienThiDanhSachHangCuaHoaDon(dataTable);
        }
        
        public void TaoHoaDon(string ngayTao, int maNhanVien, string maKhachHang)
        {
            try
            {
                int maKH = int.Parse(maKhachHang);

                HoaDonDAO hoaDonDAO = new HoaDonDAO();

                bool result = hoaDonDAO.TaoHoaDon(new HoaDon(ngayTao, maNhanVien, maKH));

                if (result)
                {
                    LoadDanhSachHoaDon();
                    _view.ThongBao("Tạo hóa đơn thành công");
                }
                else
                {
                    _view.ThongBao("Tạo hóa đơn thất bại");
                }
            }
            catch (FormatException)
            {
                _view.ThongBao("Mã khách hàng không hợp lệ");
                return;
            }
        }

        public void ThemHangVaoHoaDon(string maHoaDon, string maHang, string soLuong)
        {
            try
            {
                int maHD = int.Parse(maHoaDon);
                int sl = int.Parse(soLuong);


                HangDAO hangDAO = new HangDAO();
                bool result = hangDAO.GiamSoLuongHang(maHang, sl);

                if (result)
                {
                    HoaDonDAO hoaDonDAO = new HoaDonDAO();
                    bool result2 = hoaDonDAO.ThemChiTietHoaDon(new ChiTietHoaDon(maHD, maHang, sl));

                    if (result2)
                    {
                        LoadDanhSachHangCuaHoaDon(maHoaDon);

                        hoaDonDAO.TangThanhTien(new ChiTietHoaDon(maHD, maHang, sl), hangDAO.TimHangTheoMaHang(maHang));

                        LoadDanhSachHoaDon();

                        _view.ThongBao("Thêm hàng vào hóa đơn thành công");
                    }
                    else
                    {
                        _view.ThongBao("Thêm hàng vào hóa đơn thất bại hoặc hàng đã có trong hóa đơn");
                    }
                }
                else
                {
                    _view.ThongBao("Hàng không tồn tại hoặc số lượng hàng không đủ");
                }
                
            }
            catch (FormatException)
            {
                _view.ThongBao("Mã hàng hoặc số lượng không hợp lệ");
                return;
            }
        }

        public void XoaHangKhoiHoaDon(string maHoaDon, string maHang, string soLuong)
        {
            try
            {
                int maHD = int.Parse(maHoaDon);
                int sl = int.Parse(soLuong);

                HangDAO hangDAO = new HangDAO();
                bool result = hangDAO.TangSoLuongHang(maHang, sl);

                if (result)
                {

                    HoaDonDAO hoaDonDAO = new HoaDonDAO();
                    bool result2 = hoaDonDAO.XoaChiTietHoaDon(maHD, maHang);

                    if (result2)
                    {
                        LoadDanhSachHangCuaHoaDon(maHoaDon);

                        hoaDonDAO.GiamThanhTien(new ChiTietHoaDon(maHD, maHang, sl), hangDAO.TimHangTheoMaHang(maHang));

                        LoadDanhSachHoaDon();

                        _view.ThongBao("Xóa hàng khỏi hóa đơn thành công");
                    }
                    else
                    {
                        _view.ThongBao("Xóa hàng khỏi hóa đơn thất bại");
                    }
                }
            }
            catch (FormatException)
            {
                _view.ThongBao("Thông tin hàng không hợp lệ");
                return;
            }
        }

        public void XoaHoaDon(string maHoaDon)
        {

            try
            {
                int maHD = int.Parse(maHoaDon);

                HoaDonDAO hoaDonDAO = new HoaDonDAO();

                bool result = hoaDonDAO.XoaHoaDon(maHD);

                if (result)
                {
                    LoadDanhSachHoaDon();
                    _view.ThongBao("Xóa hóa đơn thành công");
                }
                else
                {
                    _view.ThongBao("Xóa hóa đơn thất bại");
                }
            }
            catch (FormatException)
            {
                _view.ThongBao("Mã hóa đơn không hợp lệ");
            }

        }

        public void TimKiemHoaDonTheoMa(string maHoaDon)
        {
            HoaDonDAO hoaDonDAO = new HoaDonDAO();

            DataTable dataTable = hoaDonDAO.TimKiemHoaDonTheoMa(maHoaDon);

            _view.HienThiDanhSachHoaDon(dataTable);
        }
    }
}
