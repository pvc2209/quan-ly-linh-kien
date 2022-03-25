using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanLinhKien.Model
{
    public class ChiTietPhieuNhap
    {
        public ChiTietPhieuNhap(int maPhieuNhap, int maHang, int soLuong, double giaNhap)
        {
            this.MaPhieuNhap = maPhieuNhap;
            this.MaHang = maHang;
            this.SoLuong = soLuong;
            this.GiaNhap = giaNhap;
        }
        
        public int MaPhieuNhap { get; set; }
        public int MaHang { get; set; }
        public int SoLuong { get; set; }
        public double GiaNhap { get; set; }
    }
}
