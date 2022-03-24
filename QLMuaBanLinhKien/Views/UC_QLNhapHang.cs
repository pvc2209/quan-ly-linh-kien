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
    public partial class UC_QLNhapHang : UserControl
    {
        PhieuNhapDAO DAO = new PhieuNhapDAO();
        HangDAO DAO_Hang = new HangDAO();
        PhieuNhap phieuNhap;
        public UC_QLNhapHang()
        {
            InitializeComponent();
        }

        private void UC_QLNhapHang_Load(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = DAO.getSelectALL();
        }

        private PhieuNhap getPhieuNhap()
        {
            phieuNhap = new PhieuNhap(int.Parse(edtMaPhieuNhap.Text), edtNgayTao.Text,new TaiKhoan(int.Parse(edtMaNhanVien.Text)));
            return phieuNhap;
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            if(phieuNhap == null)
            {
                getPhieuNhap();
                DAO.taoPhieuNhap(phieuNhap);
                dgvPhieuNhap.DataSource = DAO.getSelectALL();
            }

            List<Hang> hangs = new List<Hang>() {new Hang(edtMaHang.Text)};
            List<double> giaNhap = new List<double>() { double.Parse(edtGiaNhap.Text)};
            List<int> soLuong = new List<int>() {int.Parse(edtSoLuong.Text) };
            phieuNhap.Hangs = hangs;
            phieuNhap.GiaNhap = giaNhap;
            phieuNhap.SoLuong = soLuong;

            bool flas = DAO.taoChiTietPhieuNhap(phieuNhap);
            if (flas == true)
            {
                dgvChiTietPhieuNhap.DataSource = DAO.getSelectALLChiTietPN(phieuNhap);
                MessageBox.Show("Tạo phiếu nhập thành công!");
            }
            else
            {
                MessageBox.Show("Tạo phiếu nhập thất bại!");
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DAO.xoaPhieuNhap(new PhieuNhap(int.Parse(edtMaPhieuNhap.Text)));
                dgvPhieuNhap.DataSource = DAO.getSelectALL();
            }
            catch(Exception c)
            {
                MessageBox.Show("Xoá thất bại");
            }
            
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            phieuNhap = null;
            edtMaHang.Text = "";
            edtGiaNhap.Text = "";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
          dgvPhieuNhap.DataSource = DAO.timKiemPhieuNhap(new PhieuNhap(int.Parse(edtTimKiem.Text)));
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPhieuNhap.Rows[e.RowIndex].Cells[1].Value != null)
            {
                dgvPhieuNhap.CurrentRow.Selected = true;
                edtMaPhieuNhap.Text = dgvPhieuNhap.Rows[e.RowIndex].Cells["ma_phieu_nhap"].FormattedValue.ToString();
                edtNgayTao.Text = dgvPhieuNhap.Rows[e.RowIndex].Cells["nga_tao"].FormattedValue.ToString();
                edtMaNhanVien.Text = dgvPhieuNhap.Rows[e.RowIndex].Cells["ma_nhan_vien"].FormattedValue.ToString();

                dgvChiTietPhieuNhap.DataSource = DAO.getSelectALLChiTietPN(getPhieuNhap());
            }
        }

        private void edtMaHang_TextChanged(object sender, EventArgs e)
        {
            List<string> ls = DAO_Hang.getTenHang_Gia(new Hang(edtMaHang.Text));
            if (ls != null)
            {
                edtTenHang.Text = ls[0];
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
