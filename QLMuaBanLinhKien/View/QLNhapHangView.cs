
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
    public partial class QLNhapHangView : UserControl
    {
        private int _maNhanVien;
        private QLNhapHangController _qlNhapHangController;
        public QLNhapHangView(int maNhanVien)
        {
            InitializeComponent();

            _qlNhapHangController = new QLNhapHangController(this);

            _maNhanVien = maNhanVien;
        }

        private void QLNhapHangView_Load(object sender, EventArgs e)
        {
            _qlNhapHangController.LoadDanhSachPhieuNhap();
        }

        public void HienThiDanhSachPhieuNhap(DataTable dataTable)
        {
            dgvPhieuNhap.DataSource = dataTable;
        }

        public void HienThiDanhSachChiTietPhieuNhap(DataTable dataTable)
        {
            dgvHang.DataSource = dataTable;
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieuNhap.Text = dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString();
            dtpNgayTao.Value = (DateTime)dgvPhieuNhap.CurrentRow.Cells[1].Value;
            txtMaNhanVien.Text = dgvPhieuNhap.CurrentRow.Cells[2].Value.ToString();

            _qlNhapHangController.LoadDanhSachChiTietPhieuNhap(txtMaPhieuNhap.Text);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            string ngayTao = dtpNgayTao.Value.ToString("yyyy/MM/dd");

            _qlNhapHangController.TaoPhieuNhap(ngayTao, _maNhanVien);
        }

        public void ThongBao(string message)
        {
            MessageBox.Show(message);
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            string maPhieuNhap = txtMaPhieuNhap.Text;
            string maHang = txtMaHang.Text;
            string soLuong = txtSoLuong.Text;
            string giaNhap = txtGiaNhap.Text;

            _qlNhapHangController.ThemChiTietPhieuNhap(maPhieuNhap, maHang, soLuong, giaNhap);
        }
    }
}
