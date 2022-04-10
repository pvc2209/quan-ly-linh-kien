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
    class QLTaiKhoanController
    {
        private QLTaiKhoanView _view;
        public QLTaiKhoanController(QLTaiKhoanView view)
        {
            _view = view;
        }
        public void LoadDanhSachTaiKhoan()
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

            DataTable dataTable = taiKhoanDAO.LoadDanhSachTaiKhoan();

            _view.HienThiDanhSachTaiKhoan(dataTable);
        }

        public void ThemTaiKhoan(string tenTaiKhoan,string matKhau,string chucVu,string soDienThoai,string diaChi,string email,string hoTen)
        {
            if (CheckValid(tenTaiKhoan, matKhau, hoTen, soDienThoai, email))
            {
                try
                {
                    TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

                    bool result = taiKhoanDAO.ThemTaiKhoan(new TaiKhoan(tenTaiKhoan, matKhau, chucVu, hoTen, soDienThoai, diaChi, email));

                    if (result)
                    {
                        LoadDanhSachTaiKhoan();
                        _view.ThongBao("Thêm tài khoản thành công!");
                    }
                    else
                    {
                        _view.ThongBao("Thêm tài khoản thất bại!");
                    }
                }
                catch (FormatException)
                {
                    _view.ThongBao("Thông tin không hợp lệ");
                    return;
                }
            }
        }

        public void SuaTaiKhoan(string maTaiKhoan,string tenTaiKhoan, string matKhau, string chucVu, string soDienThoai, string diaChi, string email, string hoTen)
        {
            if (CheckValid(tenTaiKhoan, matKhau, hoTen, soDienThoai, email))
            {
                try
                {
                    int maTK = int.Parse(maTaiKhoan);
                    TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

                    bool result = taiKhoanDAO.SuaTaiKhoan(new TaiKhoan(maTK,tenTaiKhoan, matKhau, chucVu, hoTen, soDienThoai, diaChi, email));

                    if (result)
                    {
                        LoadDanhSachTaiKhoan();
                        _view.ThongBao("Sửa tài khoản thành công!");
                    }
                    else
                    {
                        _view.ThongBao("Sửa tài khoản thất bại!");
                    }
                }
                catch (FormatException)
                {
                    _view.ThongBao("Thông tin không hợp lệ");
                    return;
                }
            }
        }

        public void XoaTaiKhoan(string maTaiKhoan)
        {
            if (maTaiKhoan.Length == 0)
            {
                _view.ThongBao("Mã tài khoản không được để trống");
                return;
            }

            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
            bool result=false;
            try
            {
                int matk = int.Parse(maTaiKhoan);
                result = taiKhoanDAO.XoaTaiKhoan(new TaiKhoan(matk));
            }
            catch { }

            if (result)
            {
                LoadDanhSachTaiKhoan();
                _view.ThongBao("Xóa hàng thành công!");
            }
            else
            {
                _view.ThongBao("Xóa hàng thất bại!");
            }
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private bool CheckValid(string tenTaiKhoan, string matKhau, string hoTen, string soDienThoai, string email)
        {
            if (tenTaiKhoan.Length == 0 || CheckKyTuDacBiet(tenTaiKhoan) == false)
            {
                _view.ThongBao("Tài khoản không hợp lệ");
                return false;
            }

            if (matKhau.Length == 0)
            {
                _view.ThongBao("Mật khẩu không được để trống");
                return false;
            }

            if (hoTen.Length == 0 || CheckKyTuDacBiet(hoTen) == false)
            {
                _view.ThongBao("Họ tên không hợp lệ");
                return false;
            }

            if (soDienThoai.Length != 10 || IsNumber(soDienThoai) == false)
            {
                _view.ThongBao("Số điện thoại không hợp lệ");
                return false;
            }

            if (email.Length == 0 || !email.Contains("@"))
            {
                _view.ThongBao("Email không hợp lệ");
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

        public void TimKiemTaiKhoan(string tenTaiKhoan)
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

            DataTable dataTable = taiKhoanDAO.TimKiemTaiKhoan(new TaiKhoan(tenTaiKhoan));

            _view.HienThiDanhSachTaiKhoan(dataTable);
        }
    }
}
