using QLMuaBanLinhKien.Model;
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
    public partial class NhanVienView : Form
    {
        private TaiKhoan _nhanVien;
        
        private QLKhachHangView _qlKhachHangView;
        private QLBanHangView _qlBanHangView;
        private QLNhapHangView _qlNhapHangView;
        private QLThongTinHangView _qlThongTinHangView;
        
        public NhanVienView(TaiKhoan taiKhoan)
        {
            InitializeComponent();

            _nhanVien = taiKhoan;

            this.Text = $"Nhân Viên: {_nhanVien.HoTen} ({_nhanVien.SoDienThoai})";
        }

        private void NhanVienView_Load(object sender, EventArgs e)
        {
            _qlKhachHangView = new QLKhachHangView();
            _qlBanHangView = new QLBanHangView();
            _qlNhapHangView = new QLNhapHangView();
            _qlThongTinHangView = new QLThongTinHangView();


            addUseControl(_qlBanHangView);
        }
        
        
        private void addUseControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            addUseControl(_qlKhachHangView);
        }

        private void btnQLBanHang_Click(object sender, EventArgs e)
        {
            
            addUseControl(_qlBanHangView);
        }

        private void btnQLNhapHang_Click(object sender, EventArgs e)
        {
            addUseControl(_qlNhapHangView);
        }

        private void btnQLThongTinHang_Click(object sender, EventArgs e)
        {
            addUseControl(_qlThongTinHangView);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
