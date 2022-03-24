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
    public partial class MenuQuanLy : Form
    {
        public MenuQuanLy()
        {
            InitializeComponent();
        }

        private void MenuQuanLy_Load(object sender, EventArgs e)
        {
            UC_QLTaiKhoan uc = new UC_QLTaiKhoan();
            addUseControl(uc);
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
            UC_QLTaiKhoan uc = new UC_QLTaiKhoan();
            addUseControl(uc);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_ThongKe uc = new UC_ThongKe();
            addUseControl(uc);
        }
    }
}
