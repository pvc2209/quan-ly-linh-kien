using CuaHangLinhKienCode.DAO;
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
    public partial class UC_QLTHongTinHang : UserControl
    {
        public UC_QLTHongTinHang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_QLTHongTinHang_Load(object sender, EventArgs e)
        {
            HangDAO h = new HangDAO();
            dgvTTHang.DataSource = h.getSelectALL();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HangDAO h = new HangDAO();
            try
            {
                string maH = txtMaHang.Text.Trim();
                string tenH = txtTenHang.Text.Trim();
                double gia = double.Parse(txtGiaBan.Text.Trim());
                int sl = int.Parse(txtSoLuong.Text.Trim());
                if(maH != "" && tenH != "" && gia.ToString() != "" && sl.ToString() != "")
                {
                    h.themHang(new CuaHangLinhKienCode.Model.Hang(maH, tenH, gia, sl));
                    dgvTTHang.DataSource = h.getSelectALL();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi thêm hàng");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HangDAO h = new HangDAO();
            try
            {
                string maH = txtMaHang.Text.Trim();
                string tenH = txtTenHang.Text.Trim();
                double gia = double.Parse(txtGiaBan.Text.Trim());
                int sl = int.Parse(txtSoLuong.Text.Trim());
                if (maH != "" && tenH != "" && gia.ToString() != "" && sl.ToString() != "")
                {
                    h.suaHang(new CuaHangLinhKienCode.Model.Hang(maH, tenH, gia, sl));
                    dgvTTHang.DataSource = h.getSelectALL();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa hàng");
            }
        }

        private void dgvTTHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = dgvTTHang.CurrentRow.Index;
                dgvTTHang.CurrentRow.Selected = true;
                txtMaHang.Text = dgvTTHang.Rows[i].Cells[0].Value.ToString().Trim();
                txtTenHang.Text = dgvTTHang.Rows[i].Cells[1].Value.ToString().Trim();
                txtGiaBan.Text = dgvTTHang.Rows[i].Cells[2].Value.ToString().Trim();
                txtSoLuong.Text = dgvTTHang.Rows[i].Cells[3].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HangDAO h = new HangDAO();
            try
            {
                string maH = txtMaHang.Text.Trim();
                string tenH = txtTenHang.Text.Trim();
                double gia = double.Parse(txtGiaBan.Text.Trim());
                int sl = int.Parse(txtSoLuong.Text.Trim());
                if (maH != "" && tenH != "" && gia.ToString() != "" && sl.ToString() != "")
                {
                    h.xoaHang(new CuaHangLinhKienCode.Model.Hang(maH, tenH, gia, sl));
                    dgvTTHang.DataSource = h.getSelectALL();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa hàng");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HangDAO h = new HangDAO();
            if (rdMa.Checked == true)
            {
                string maH = txtTimHang.Text.Trim();
                if (maH != "")
                    dgvTTHang.DataSource = h.tkMaHang(new CuaHangLinhKienCode.Model.Hang(maH, "", 0, 0));
                else
                    dgvTTHang.DataSource = h.getSelectALL();
            }
            else if(rdTen.Checked==true)
            {
                string tenH = txtTimHang.Text.Trim();
                if (tenH == "")
                    dgvTTHang.DataSource = h.getSelectALL();
                else
                    dgvTTHang.DataSource = h.tkTenHang(new CuaHangLinhKienCode.Model.Hang("", tenH, 0, 0));
            }
        }
    }
}
