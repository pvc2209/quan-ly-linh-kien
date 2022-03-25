using QLMuaBanLinhKien.Dal;
using QLMuaBanLinhKien.Model;
using QLMuaBanLinhKien.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanLinhKien.Controller
{
    public class DangNhapController
    {
        private DangNhapView _view;

        public DangNhapController(DangNhapView view)
        {
            _view = view;
        }

        public void DangNhap(string tenTaiKhoan, string matKhau)
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

            TaiKhoan taiKhoan = taiKhoanDAO.CheckLogin(tenTaiKhoan, matKhau);

            if (taiKhoan != null)
            {
                string chucVu = taiKhoan.ChucVu;
                
                if (chucVu.Equals("Quản Lý"))
                {
                    QuanLyView quanLyView = new QuanLyView(taiKhoan);
                    
                    _view.Hide();
                    
                    quanLyView.Closed += (sender, e) => _view.Show();
                    quanLyView.Show();
                }
                else if (chucVu.Equals("Nhân Viên"))
                {
                    NhanVienView nhanVienView = new NhanVienView(taiKhoan);

                    _view.Hide();
                    
                    nhanVienView.Closed += (sender, e) => _view.Show();
                    nhanVienView.Show();
                }
            }
            else
            {
                _view.showMessage("Đăng nhập thất bại");
            }
        }
    }
}
