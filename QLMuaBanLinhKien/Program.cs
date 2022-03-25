using QLMuaBanLinhKien.Model;
using QLMuaBanLinhKien.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanLinhKien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TaiKhoan fake = new TaiKhoan();
            fake.HoTen = "Faker";
            fake.SoDienThoai = "0000000";

            //Application.Run(new DangNhapView());
            Application.Run(new NhanVienView(fake));
        }
    }
}
