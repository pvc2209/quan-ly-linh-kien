
using QLMuaBanLinhKien.Controller;
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
    public partial class QLBanHangView : UserControl
    {
        private int _maNhanVien;
        private QLBanHangController _qlBanHangController;
        public QLBanHangView(int maNhanVien)
        {
            InitializeComponent();

            _qlBanHangController = new QLBanHangController(this);

            _maNhanVien = maNhanVien;
        }

        private void QLBanHangView_Load(object sender, EventArgs e)
        {
            _qlBanHangController.LoadDanhSachHoaDon();

            dtpNgayTao.Value = DateTime.Now;
        }

        public void HienThiDanhSachHoaDon(DataTable dataTable)
        {
            dgvHoaDon.DataSource = dataTable;
        }

        public void HienThiDanhSachHangCuaHoaDon(DataTable dataTable)
        {
            dgvHang.DataSource = dataTable;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHoaDon.Text = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            dtpNgayTao.Value = (DateTime)dgvHoaDon.CurrentRow.Cells[1].Value;
            lbThanhTien.Text = dgvHoaDon.CurrentRow.Cells[2].Value.ToString() + " VNĐ";
            txtMaNhanVien.Text = dgvHoaDon.CurrentRow.Cells[3].Value.ToString();
            txtMaKhachHang.Text = dgvHoaDon.CurrentRow.Cells[4].Value.ToString();

            _qlBanHangController.LoadDanhSachHangCuaHoaDon(txtMaHoaDon.Text);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            string ngayTao = dtpNgayTao.Value.ToString("yyyy/MM/dd");
            string maKH = txtMaKhachHang.Text;
            
            _qlBanHangController.TaoHoaDon(ngayTao, _maNhanVien, maKH);
        }
        
        public void ThongBao(string message)
        {
            MessageBox.Show(message);
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtMaHoaDon.Text;
            string maHang = txtMaHang.Text;
            string soLuong = txtSoLuong.Text;

            _qlBanHangController.ThemHangVaoHoaDon(maHoaDon, maHang, soLuong);
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtMaHoaDon.Text;
            string maHang = txtMaHang.Text;
            string soLuong = txtSoLuong.Text;

            _qlBanHangController.XoaHangKhoiHoaDon(maHoaDon, maHang, soLuong);
        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = dgvHang.CurrentRow.Cells[0].Value.ToString();
            txtSoLuong.Text = dgvHang.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtMaHoaDon.Text;
            _qlBanHangController.XoaHoaDon(maHoaDon);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtTimKiem.Text;
            _qlBanHangController.TimKiemHoaDonTheoMa(maHoaDon);
        }
    }
}
