using QLMuaBanLinhKien.Controller;
using QLMuaBanLinhKien.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanLinhKien
{
    public partial class DangNhapView : Form
    {
        private DangNhapController _dangNhapController;
        public DangNhapView()
        {
            InitializeComponent();

            _dangNhapController = new DangNhapController(this);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txtTenTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            
            _dangNhapController.DangNhap(tenTaiKhoan, matKhau);
        }
        
        public void showMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
