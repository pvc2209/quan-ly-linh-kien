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
    public partial class ThongKeView : UserControl
    {
        private ThongKeController controller;
        public ThongKeView()
        {
            InitializeComponent();
            controller = new ThongKeController(this);
        }
        public void HienThiThongKe(DataTable dataTable)
        {
            dgvThongKe.DataSource = dataTable;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string input = cbbNam.Text;

            if (input != "")
            {
                controller.tkTheoThang(input);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string input = cbbNam.Text;

            if (input != "")
            {
                controller.tkTongTienNhapTheoThang(input);
            }
        }

        private void ThongKeView_Load(object sender, EventArgs e)
        {
            cbbNam.SelectedIndex = 6;
        }

    }
}
