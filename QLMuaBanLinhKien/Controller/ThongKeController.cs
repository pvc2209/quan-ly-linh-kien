using QLMuaBanLinhKien.Dal;
using QLMuaBanLinhKien.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanLinhKien.Controller
{
    public class ThongKeController
    {
        private ThongKeView _view;
        public ThongKeController(ThongKeView view)
        {
            _view = view;
        }
        
        public void ThongKeDoanhThuTheoThang(string nam)
        {
            ThongKeDAO thongKeDAO = new ThongKeDAO();
            DataTable dataTable = thongKeDAO.ThongKeDoanhThuTheoThang(nam);

            _view.HienThiThongKe(dataTable);
        }

        public void ThongKeTongTienNhapTheoThang(string nam)
        {
            ThongKeDAO thongKeDAO = new ThongKeDAO();
            DataTable dataTable = thongKeDAO.ThongKeTongTienNhapTheoThang(nam);

            _view.HienThiThongKe(dataTable);
        }
    }
}
