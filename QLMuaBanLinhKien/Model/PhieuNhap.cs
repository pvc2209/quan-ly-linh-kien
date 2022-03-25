using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanLinhKien.Model
{
    public class PhieuNhap
    {
        public PhieuNhap(int maPhieuNhap, string ngayTao, int maNhanVien)
        {
            this.MaPhieuNhap = maPhieuNhap;
            this.NgayTao = ngayTao;
            this.MaNhanVien = maNhanVien;
        }

        public PhieuNhap(string ngayTao, int maNhanVien)
        {
            this.NgayTao = ngayTao;
            this.MaNhanVien = maNhanVien;
        }

        public int MaPhieuNhap { get; set; }
        public string NgayTao { get; set; }
        public int MaNhanVien { get; set; }
    }
}
