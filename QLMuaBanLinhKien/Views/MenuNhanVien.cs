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
    public partial class MenuNhanVien : Form
    {
        public MenuNhanVien()
        {
            InitializeComponent();
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
            UC_QLKhachHang uc = new UC_QLKhachHang();
            addUseControl(uc);
        }

        private void btnQLBanHang_Click(object sender, EventArgs e)
        {
            UC_QLBanHang uc = new UC_QLBanHang();
            addUseControl(uc);
        }

        private void btnQLNhapHang_Click(object sender, EventArgs e)
        {
            UC_QLNhapHang uc = new UC_QLNhapHang();
            addUseControl(uc);
        }

        private void btnQLThongTinHang_Click(object sender, EventArgs e)
        {
            UC_QLTHongTinHang uc = new UC_QLTHongTinHang();
            addUseControl(uc);
        }
    }
}
