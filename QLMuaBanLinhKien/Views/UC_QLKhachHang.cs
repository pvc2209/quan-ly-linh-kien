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
    public partial class UC_QLKhachHang : UserControl
    {
        KhachHangDAO DAO; 
        public UC_QLKhachHang()
        {
            InitializeComponent();
        }

        private void UC_QLKhachHang_Load(object sender, EventArgs e)
        {
            DAO = new KhachHangDAO();
            dgvKhachHang.DataSource = DAO.getSelectALL(); 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool flas = DAO.themKhachHang(getKhachHang());
            if (flas == true)
            {
                dgvKhachHang.DataSource = DAO.getSelectALL();
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private KhachHang getKhachHang()
        {
            KhachHang kh = new KhachHang(int.Parse(edtMaKhachHang.Text),edtTenKhachHang.Text, edtSoDienThoai.Text, edtDiaChi.Text, edtEmail.Text);
            return kh;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool flas = DAO.suaKhachHang(getKhachHang());
            if (flas == true)
            {
                dgvKhachHang.DataSource = DAO.getSelectALL();
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool flas = DAO.xoaKhachHang(getKhachHang());
            if (flas == true)
            {
                dgvKhachHang.DataSource = DAO.getSelectALL();
                MessageBox.Show("Xoá thành công!");
            }
            else
            {
                MessageBox.Show("Xoá thất bại!");
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhachHang.Rows[e.RowIndex].Cells[1].Value != null)
            {
                dgvKhachHang.CurrentRow.Selected = true;
                edtMaKhachHang.Text = dgvKhachHang.Rows[e.RowIndex].Cells["ma_khac_hang"].FormattedValue.ToString();
                edtTenKhachHang.Text = dgvKhachHang.Rows[e.RowIndex].Cells["ho_ten"].FormattedValue.ToString();
                edtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells["dia_chi"].FormattedValue.ToString();
                edtSoDienThoai.Text = dgvKhachHang.Rows[e.RowIndex].Cells["so_dien_thoai"].FormattedValue.ToString();
                edtEmail.Text = dgvKhachHang.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();

            }
        }
    }
}
