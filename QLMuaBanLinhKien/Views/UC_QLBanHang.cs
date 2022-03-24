using CuaHangLinhKienCode.DAO;
using CuaHangLinhKienCode.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanLinhKien.Views
{
    public partial class UC_QLBanHang : UserControl
    {
        HoaDonDAO DAO_HD;
        HangDAO DAO_Hang;
        HoaDon hd;
        double tongTien;
        public UC_QLBanHang()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = DAO_HD.timKiemHoaDon(new HoaDon(int.Parse(edtTimKiem.Text)));
        }

        private void UC_QLBanHang_Load(object sender, EventArgs e)
        {
            DAO_HD = new HoaDonDAO();
            DAO_Hang = new HangDAO();
            hd = null;
            edtThanhTien.Text = "0.0";
            dgvHoaDon.DataSource = DAO_HD.getSelectALL_HoaDon();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHoaDon.Rows[e.RowIndex].Cells[1].Value != null)
            {
                dgvHoaDon.CurrentRow.Selected = true;
                edtMaKhachHang.Text = dgvHoaDon.Rows[e.RowIndex].Cells["ma_khac_hang"].FormattedValue.ToString();
                edtMaHoaDon.Text = dgvHoaDon.Rows[e.RowIndex].Cells["ma_hoa_don"].FormattedValue.ToString();
                edtNgayTao.Text = dgvHoaDon.Rows[e.RowIndex].Cells["ngay_tao"].FormattedValue.ToString();
                edtNhanVien.Text = dgvHoaDon.Rows[e.RowIndex].Cells["ma_nhan_vien"].FormattedValue.ToString();
                edtThanhTien.Text = dgvHoaDon.Rows[e.RowIndex].Cells["thanh_tien"].FormattedValue.ToString();

                dgvChiTietHoaDon.DataSource = DAO_HD.getSelectAll_ChiTietHoaDon(getHoaDon());
            }
        }

        private HoaDon getHoaDon()
        {
            hd = new HoaDon(int.Parse(edtMaHoaDon.Text), edtNgayTao.Text, edtThanhTien.Text, new TaiKhoan(int.Parse(edtNhanVien.Text)), new KhachHang(int.Parse(edtMaKhachHang.Text)));
            return hd;
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            if(hd == null)
            {
                getHoaDon();
                DAO_HD.taoHoaDon(hd);
            }    
            
            List<Hang> ls = new List<Hang>() { new Hang((edtMaHang.Text)) };
            List<int> sl = new List<int>() {  int.Parse(edtSoLuong.Text)};

            hd.Hangs = ls;
            hd.SoLuong = sl;
            DAO_HD.taoChiTietHoaDon(hd);

            tongTien += sl[0] * double.Parse(edtGiaBan.Text);

            edtThanhTien.Text = ""+tongTien;

            dgvChiTietHoaDon.DataSource = dgvChiTietHoaDon.DataSource = DAO_HD.getSelectAll_ChiTietHoaDon(hd);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            hd = null;
            tongTien = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DAO_HD.suaHoaDon(getHoaDon());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DAO_HD.xoaHoaDon(getHoaDon());
            dgvHoaDon.DataSource = DAO_HD.getSelectALL_HoaDon();
        }

        private void edtMaHang_TabStopChanged(object sender, EventArgs e)
        {
            
        }

        private void edtMaHang_Enter(object sender, EventArgs e)
        {
          
        }

        private void edtMaHang_TextChanged(object sender, EventArgs e)
        {
            List<string> ls = DAO_Hang.getTenHang_Gia(new Hang(edtMaHang.Text));
            if (ls != null)
            {
                edtTenHang.Text = ls[0];
                edtGiaBan.Text = ls[1];
            }
        }
    }
}
