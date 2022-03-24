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
    public partial class UC_QLTaiKhoan : UserControl
    {
        TaiKhoanDAO DAO;
        public UC_QLTaiKhoan()
        {
            InitializeComponent();
        }

        private TaiKhoan getTaiKhoan()
        {
            TaiKhoan tk = new TaiKhoan(int.Parse(txtMaTaiKhoan.Text), txtTenTaiKhoan.Text, txtMatKhau.Text, cbChucVu.Text, txtHoTen.Text, txtSoDienThoai.Text, txtDiaChi.Text, txtEmail.Text);

            return tk;
        }

        private void UC_QLTaiKhoan_Load(object sender, EventArgs e)
        {
            DAO = new TaiKhoanDAO();

            dgvTaiKhoan.DataSource = DAO.getSelectALL();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool flas= DAO.xoaTaiKhoan(getTaiKhoan());
            if (flas == true)
            {
                dgvTaiKhoan.DataSource = DAO.getSelectALL();
                MessageBox.Show("Xoá thành công!");
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = DAO.timKiemTaiKhoan(new TaiKhoan(edtTimKiem.Text));
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool flas = DAO.suaTaiKhoan(getTaiKhoan());
            if (flas == true)
            {
                dgvTaiKhoan.DataSource = DAO.getSelectALL();
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dgvTaiKhoan.CurrentRow.Selected = true;
                txtMaTaiKhoan.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["ma_tai_khoan"].FormattedValue.ToString();
                txtTenTaiKhoan.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["ten_tai_khoan"].FormattedValue.ToString();
                txtMatKhau.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["mat_khau"].FormattedValue.ToString();
                txtSoDienThoai.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["so_dien_thoai"].FormattedValue.ToString();
                txtEmail.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
                txtHoTen.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["ho_ten"].FormattedValue.ToString();
                cbChucVu.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["chucvu"].FormattedValue.ToString();
                txtDiaChi.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["dia_chi"].FormattedValue.ToString();

            }catch(Exception ex)
            {

            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            bool flas = DAO.taoTaiKhoan(getTaiKhoan());
            if (flas == true)
            {
                dgvTaiKhoan.DataSource = DAO.getSelectALL();
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
        }
    }
}
