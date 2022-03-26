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
    public partial class QLTaiKhoanView : UserControl
    {
        private QLTaiKhoanController _qlTaiKhoanController;
        public QLTaiKhoanView()
        {
            InitializeComponent();
            _qlTaiKhoanController = new QLTaiKhoanController(this);
        }
        private void QLTaiKhoanView_Load(object sender, EventArgs e)
        {
            LoadDanhSachTaiKhoan();
        }

        public void LoadDanhSachTaiKhoan()
        {
            _qlTaiKhoanController.LoadDanhSachTaiKhoan();
        }

        public void HienThiDanhSachTaiKhoan(DataTable dataTable)
        {
            dgvTaiKhoan.DataSource = dataTable;
        }

        public void ThongBao(string message)
        {
            MessageBox.Show(message);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenTK = txtTimKiem.Text;
            _qlTaiKhoanController.TimKiemTaiKhoan(tenTK);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maTK = txtMaTaiKhoan.Text;
            _qlTaiKhoanController.XoaTaiKhoan(maTK);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maTK = txtMaTaiKhoan.Text;
            string tenTK = txtTenTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            string cv = cbChucVu.Text;
            string email = txtEmail.Text;
            string sdt = txtSoDienThoai.Text;
            string diachi = txtDiaChi.Text;
            string hoten = txtHoTen.Text;
            _qlTaiKhoanController.SuaTaiKhoan(maTK,tenTK, matkhau, cv, sdt, diachi, email, hoten);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            string cv = cbChucVu.Text;
            string email = txtEmail.Text;
            string sdt = txtSoDienThoai.Text;
            string diachi = txtDiaChi.Text;
            string hoten = txtHoTen.Text;
            _qlTaiKhoanController.ThemTaiKhoan(tenTK, matkhau, cv, sdt, diachi, email, hoten);
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTaiKhoan.Text = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            txtTenTaiKhoan.Text = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString();
            cbChucVu.Text = dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvTaiKhoan.CurrentRow.Cells[7].Value.ToString();
            txtSoDienThoai.Text = dgvTaiKhoan.CurrentRow.Cells[5].Value.ToString();
            txtDiaChi.Text = dgvTaiKhoan.CurrentRow.Cells[6].Value.ToString();
            txtHoTen.Text = dgvTaiKhoan.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
