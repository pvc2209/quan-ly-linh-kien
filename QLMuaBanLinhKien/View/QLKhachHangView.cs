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
    public partial class QLKhachHangView : UserControl
    {
        private QLKhachHangController _khachHangController;
        public QLKhachHangView()
        {
            InitializeComponent();

            _khachHangController = new QLKhachHangController(this);
        }
        
        private void QLKhachHangView_Load(object sender, EventArgs e)
        {
            _khachHangController.LoadDanhSachKhachHang();
        }

        public void HienThiDanhSachKhachHang(DataTable dataTable)
        {
            dgvKhachHang.DataSource = dataTable;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
        }

        public void ThongBao(string message)
        {
            MessageBox.Show(message);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            string email = txtEmail.Text;
            _khachHangController.ThemKhachHang(hoTen, diaChi, sdt, email);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string hoTen = txtHoTen.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            string email = txtEmail.Text;
            _khachHangController.SuaKhachHang(ma, hoTen, diaChi, sdt, email);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            _khachHangController.XoaKhachHang(ma);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string soDienThoai = txtTimKiem.Text;
            _khachHangController.TimKiemKhachHang(soDienThoai);
        }

        //public void Clear()
        //{
        //    txtMa.Text = "";
        //    txtHoTen.Text = "";
        //    txtSDT.Text = "";
        //    txtDiaChi.Text = "";
        //    txtEmail.Text = "";
        //}
    }
}
