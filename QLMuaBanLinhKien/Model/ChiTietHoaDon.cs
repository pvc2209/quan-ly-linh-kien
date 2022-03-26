using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanLinhKien.Model
{
    public class ChiTietHoaDon
    {
        public ChiTietHoaDon(int maHD, string maHang, int soLuong)
        {
            this.MaHD = maHD;
            this.MaHang = maHang;
            this.SoLuong = soLuong;
        }
        
        public int MaHD { get; set; }
        public string MaHang { get; set; }
        public int SoLuong { get; set; }
    }
}
