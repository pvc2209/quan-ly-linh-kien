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
    public partial class QuanLyView : Form
    {
        private TaiKhoan _quanLy;
        
        private QLTaiKhoanView _qlTaiKhoanView = new QLTaiKhoanView();
        private ThongKeView _thongKeView = new ThongKeView();

        public QuanLyView(TaiKhoan taiKhoan)
        {
            InitializeComponent();

            _quanLy = taiKhoan;

            this.Text = $"Quản Lý: {_quanLy.HoTen} ({_quanLy.SoDienThoai})";
        }

        private void MenuQuanLy_Load(object sender, EventArgs e)
        {
            addUseControl(_qlTaiKhoanView);
        }
        
        private void addUseControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        
        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            addUseControl(_qlTaiKhoanView);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            addUseControl(_thongKeView);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
