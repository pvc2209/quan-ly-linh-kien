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
    public class QLHangController
    {
        private QLHangView _view;

        public QLHangController(QLHangView view)
        {
            _view = view;
        }
        
        public void LoadDanhSachHang()
        {
            HangDAO hangDAO = new HangDAO();

            DataTable dataTable = hangDAO.LoadDanhSachMatHang();

            _view.HienThiDanhSachHang(dataTable);
        }

        public void ThemHang(string maHang, string tenHang, string giaBan)
        {
            if (CheckValid(maHang, tenHang))
            {
                try
                {
                    double gia = Double.Parse(giaBan);

                    HangDAO hangDAO = new HangDAO();

                    bool result = hangDAO.ThemHang(new Hang(maHang, tenHang, gia));

                    if (result)
                    {
                        LoadDanhSachHang();
                        _view.ThongBao("Thêm hàng thành công!");
                    }
                    else
                    {
                        _view.ThongBao("Thêm hàng thất bại!");
                    }
                }
                catch (FormatException)
                {
                    _view.ThongBao("Giá bán không hợp lệ");
                    return;
                }
            }
        }

        public void SuaHang(string maHang, string tenHang, string giaBan)
        {
            if (CheckValid(maHang, tenHang))
            {
                try
                {
                    double gia = Double.Parse(giaBan);

                    HangDAO hangDAO = new HangDAO();

                    bool result = hangDAO.SuaHang(new Hang(maHang, tenHang, gia));

                    if (result)
                    {
                        LoadDanhSachHang();
                        _view.ThongBao("Sửa hàng thành công!");
                    }
                    else
                    {
                        _view.ThongBao("Sửa hàng thất bại!");
                    }
                }
                catch (FormatException)
                {
                    _view.ThongBao("Giá bán không hợp lệ");
                    return;
                }
            }
        }

        public void XoaHang(string maHang)
        {
            if (maHang.Length == 0)
            {
                _view.ThongBao("Mã hàng không được để trống");
                return;
            }

            HangDAO hangDAO = new HangDAO();

            bool result = hangDAO.XoaHang(maHang);

            if (result)
            {
                LoadDanhSachHang();
                _view.ThongBao("Xóa hàng thành công!");
            }
            else
            {
                _view.ThongBao("Xóa hàng thất bại!");
            }
        }

        private bool CheckValid(string maHang, string tenHang)
        {
            if (maHang.Length == 0)
            {
                _view.ThongBao("Mã hàng không được để trống");
                return false;
            }

            if (tenHang.Length == 0 || CheckKyTuDacBiet(tenHang) == false)
            {
                _view.ThongBao("Tên hàng không hợp lệ");
                return false;
            }

            return true;
        }

        private bool CheckKyTuDacBiet(string text)
        {
            List<string> listKyTuDacBiet = new List<string>()
            {
                "!",
                "@",
                "#",
                "%",
                "^",
                "&",
                "*",
                "(",
                ")",
                "_",
                "+",
                "-",
                "=",
                "[",
                "]",
                "{",
                "}",
            };

            for (int i = 0; i < listKyTuDacBiet.Count; ++i)
            {
                if (text.Contains(listKyTuDacBiet[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public void TimKiemHangTheoMa(string maHang)
        {
            HangDAO hangDAO = new HangDAO();

            DataTable dataTable = hangDAO.TimKiemHangTheoMa(maHang);

            _view.HienThiDanhSachHang(dataTable);
        }

        public void TimKiemHangTheoTen(string tenHang)
        {
            HangDAO hangDAO = new HangDAO();

            DataTable dataTable = hangDAO.TimKiemHangTheoTen(tenHang);

            _view.HienThiDanhSachHang(dataTable);
        }
    }
}
