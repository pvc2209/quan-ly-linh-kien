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
        public void tkTheoThang(string nam)
        {
            ThongKeDAO tk = new ThongKeDAO();
            DataTable dataTable = tk.tkTheoThang(nam);

            _view.HienThiThongKe(dataTable);
        }

        internal void tkTongTienNhapTheoThang(string nam)
        {
            ThongKeDAO tk = new ThongKeDAO();
            DataTable dataTable = tk.tkTongTienNhapTheoThang(nam);

            _view.HienThiThongKe(dataTable);
        }
    }
}
