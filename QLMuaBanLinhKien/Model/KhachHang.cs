using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanLinhKien.Model
{
    public class KhachHang
    {
        public KhachHang(int ma, string hoTen, string diaChi, string sdt, string email)
        {
            Ma = ma;
            HoTen = hoTen;
            DiaChi = diaChi;
            SDT = sdt;
            Email = email;
        }

        public KhachHang(string hoTen, string diaChi, string sdt, string email)
        {
            HoTen = hoTen;
            DiaChi = diaChi;
            SDT = sdt;
            Email = email;
        }

        public int Ma { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
    }
}
