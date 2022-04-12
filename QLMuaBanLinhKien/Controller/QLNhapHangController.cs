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
    public class QLNhapHangController
    {
        private QLNhapHangView _view;

        public QLNhapHangController(QLNhapHangView view)
        {
            _view = view;
        }

        public void LoadDanhSachPhieuNhap()
        {
            PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();

            DataTable dataTable = phieuNhapDAO.LoadDanhSachPhieuNhap();

            _view.HienThiDanhSachPhieuNhap(dataTable);
        }
        
        public void LoadDanhSachHangCuaPhieuNhap(string maPhieuNhap)
        {
            PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();

            int ma = int.Parse(maPhieuNhap);

            DataTable dataTable = phieuNhapDAO.LoadDanhSachChiTietPhieuNhap(ma);

            _view.HienThiDanhSachHangCuaPhieuNhap(dataTable);
        }

        public void TaoPhieuNhap(string ngayTao, int maNhanVien)
        {
            PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();

            bool result = phieuNhapDAO.TaoPhieuNhap(new PhieuNhap(ngayTao, maNhanVien));

            if (result)
            {
                LoadDanhSachPhieuNhap();
                _view.ThongBao("Tạo phiếu nhập thành công");
            }
            else
            {
                _view.ThongBao("Mã khách hàng không tồn tại");
            }
        }

        public void XoaPhieuNhap(string maPhieuNhap)
        {
            
            try
            {
                int ma = int.Parse(maPhieuNhap);

                PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();

                bool result = phieuNhapDAO.XoaPhieuNhap(ma);

                if (result)
                {
                    LoadDanhSachPhieuNhap();
                    _view.ThongBao("Xóa phiếu nhập thành công");
                }
                else
                {
                    _view.ThongBao("Xóa phiếu nhập thất bại");
                }
            }
            catch (FormatException)
            {
                _view.ThongBao("Mã phiếu nhập không hợp lệ");
            }

        }

        public void ThemHangVaoPhieuNhap(string maPhieuNhap, string maHang, string soLuong, string giaNhap)
        {
            try
            {
                int maPN = int.Parse(maPhieuNhap);
                int sl = int.Parse(soLuong);
                double giaN = double.Parse(giaNhap);

                HangDAO hangDAO = new HangDAO();

                bool result = hangDAO.TangSoLuongHang(maHang, sl);

                if (result)
                {
                    PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();

                    bool result2 = phieuNhapDAO.ThemChiTietPhieuNhap(new ChiTietPhieuNhap(maPN, maHang, sl, giaN));

                    if (result2)
                    {
                        LoadDanhSachHangCuaPhieuNhap(maPhieuNhap);

                        _view.ThongBao("Thêm hàng vào phiếu nhập thành công");
                    }
                    else
                    {
                        _view.ThongBao("Thêm hàng vào phiếu nhập thất bại hoặc đã có trong phiếu nhập");
                    }
                }
                else
                {
                    _view.ThongBao("Mặt hàng không tồn tại");
                }
            }
            catch (FormatException)
            {
                _view.ThongBao("Định dạng không hợp lệ");
                return;
            }
        }

        public void XoaHangKhoiPhieuNhap(string maPhieuNhap, string maHang, string soLuong)
        {
            try
            {
                int maPN = int.Parse(maPhieuNhap);
                int sl = int.Parse(soLuong);

                HangDAO hangDAO = new HangDAO();
                bool result = hangDAO.GiamSoLuongHang(maHang, sl);

                if (result)
                {
                    PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();
                    bool result2 = phieuNhapDAO.XoaChiTietPhieuNhap(maPN, maHang);

                    if (result2)
                    {
                        LoadDanhSachHangCuaPhieuNhap(maPhieuNhap);
                        _view.ThongBao("Xóa hàng khỏi phiếu nhập thành công");
                    }
                    else
                    {
                        _view.ThongBao("Xóa hàng khỏi phiếu nhập thất bại");
                    }
                } 
                else
                {
                    _view.ThongBao("Hàng không tồn tại hoặc số lượng hàng không đủ");
                }
            }
            catch (FormatException)
            {
                _view.ThongBao("Thông tin hàng không hợp lệ");
                return;
            }
        }

        public void TimKiemPhieuNhapTheoMa(string maPhieuNhap)
        {
            PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();

            DataTable dataTable = phieuNhapDAO.TimKiemPhieuNhapTheoMa(maPhieuNhap);

            _view.HienThiDanhSachPhieuNhap(dataTable);
        }
    }
}
