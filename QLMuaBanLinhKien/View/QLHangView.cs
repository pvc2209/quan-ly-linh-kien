
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
    public partial class QLHangView : UserControl
    {
        private QLHangController _qlHangController;
        public QLHangView()
        {
            InitializeComponent();

            _qlHangController = new QLHangController(this);
        }

        private void QLThongTinHangView_Load(object sender, EventArgs e)
        {
            LoadDanhSachHang();
        }
        
        public void LoadDanhSachHang()
        {
            _qlHangController.LoadDanhSachHang();
        }

        public void HienThiDanhSachHang(DataTable dataTable)
        {
            dgvHang.DataSource = dataTable;
        }

        public void ThongBao(string message)
        {
            MessageBox.Show(message);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text;
            string tenHang = txtTenHang.Text;
            string giaBan = txtGiaBan.Text;

            _qlHangController.ThemHang(maHang, tenHang, giaBan);
        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = dgvHang.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dgvHang.CurrentRow.Cells[1].Value.ToString();
            txtGiaBan.Text = dgvHang.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text;
            string tenHang = txtTenHang.Text;
            string giaBan = txtGiaBan.Text;

            _qlHangController.SuaHang(maHang, tenHang, giaBan);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text;

            _qlHangController.XoaHang(maHang);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string input = txtTimKiem.Text;
            
            if (rdMaHang.Checked == true)
            {
                _qlHangController.TimKiemHangTheoMa(input);
            }
            else if (rdTenHang.Checked == true)
            {
                _qlHangController.TimKiemHangTheoTen(input);
            }
        }
    }
}
