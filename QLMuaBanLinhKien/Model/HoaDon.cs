using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanLinhKien.Model
{
    public class HoaDon
    {
        public HoaDon(int maHD, string ngayTao, int maNV, int maKH, double thanhTien)
        {
            MaHD = maHD;
            NgayTao = ngayTao;
            MaNV = maNV;
            MaKH = maKH;
            ThanhTien = thanhTien;
        }

        public HoaDon(string ngayTao, int maNV, int maKH)
        {
            NgayTao = ngayTao;
            MaNV = maNV;
            MaKH = maKH;
        }

        public int MaHD { get; set; }
        public string NgayTao { get; set; }
        public int MaNV { get; set; }
        public int MaKH { get; set; }
        public double ThanhTien { get; set; }
        
    }
}
