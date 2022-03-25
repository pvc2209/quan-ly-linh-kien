using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanLinhKien.Model
{
    public class Hang
    {
        public Hang(string maHang, string tenHang, double giaBan, int soLuong)
        {
            this.MaHang = maHang;
            this.TenHang = tenHang;
            this.GiaBan = giaBan;
            this.SoLuong = soLuong;
        }

        public Hang(string maHang, string tenHang, double giaBan)
        {
            this.MaHang = maHang;
            this.TenHang = tenHang;
            this.GiaBan = giaBan;
            this.SoLuong = 0;
        }

        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public double GiaBan { get; set; }
        public int SoLuong { get; set; }
    }
}
