using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanLinhKien.Model
{
    public class TaiKhoan
    {
        public TaiKhoan() { }

        public TaiKhoan(int maTaiKhoan, string tenTaiKhoan, string matKhau, string chucVu, string hoTen, string soDienThoai, string diaChi, string email)
        {
            this.MaTaiKhoan = maTaiKhoan;
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
            this.ChucVu = chucVu;
            this.HoTen = hoTen;
            this.SoDienThoai = soDienThoai;
            this.DiaChi = diaChi;
            this.Email = email;
        }

        public int MaTaiKhoan { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string ChucVu { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
    }
}
