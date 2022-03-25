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
        
        public void LoadDanhSachChiTietPhieuNhap(string maPhieuNhap)
        {
            PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();

            int ma = int.Parse(maPhieuNhap);

            DataTable dataTable = phieuNhapDAO.LoadDanhSachChiTietPhieuNhap(ma);

            _view.HienThiDanhSachChiTietPhieuNhap(dataTable);
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
                _view.ThongBao("Tạo phiếu nhập thất bại");
            }
        }

        public void ThemChiTietPhieuNhap(string maPhieuNhap, string maHang, string soLuong, string giaNhap)
        {
            try
            {
                int maPN = int.Parse(maPhieuNhap);
                int maH = int.Parse(maHang);
                int sl = int.Parse(soLuong);
                double giaN = double.Parse(giaNhap);

                PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();

                bool result = phieuNhapDAO.ThemChiTietPhieuNhap(new ChiTietPhieuNhap(maPN, maH, sl, giaN));

                if (result)
                {
                    LoadDanhSachChiTietPhieuNhap(maPhieuNhap);

                    // TODO: Tăng số lượng của món hàng đó lên

                    _view.ThongBao("Thêm hàng vào phiếu nhập thành công");
                }
                else
                {
                    _view.ThongBao("Mặt hàng không tồn tại");
                }
            }
            catch (FormatException)
            {
                _view.ThongBao("Thông tin không hợp lệ");
                return;
            }
        }
    }
}
