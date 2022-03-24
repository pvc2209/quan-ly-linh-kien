using CuaHangLinhKienCode.DAO;
using CuaHangLinhKienCode.Model;
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
    public partial class Form1 : Form
    {
        TaiKhoanDAO DAO;
        public Form1()
        {
            InitializeComponent();
            DAO = new TaiKhoanDAO();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string chucvu = "";
            chucvu = DAO.dangNhap(new TaiKhoan(edtTaiKhoan.Text, edtMatKhau.Text));

            switch (chucvu)
            {
                case "QuanLy":
                    MenuQuanLy ql = new MenuQuanLy();
                    ql.Show();
                    break;
                case "NhanVien":
                    MenuNhanVien nv = new MenuNhanVien();
                    nv.Show();
                    break;
                default:
                    MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ!");
                    break;
            }
            
        }
    }
}
