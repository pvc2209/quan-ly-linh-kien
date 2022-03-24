
namespace QLMuaBanLinhKien.Views
{
    partial class UC_QLBanHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edtNhanVien = new System.Windows.Forms.TextBox();
            this.edtThanhTien = new System.Windows.Forms.TextBox();
            this.edtNgayTao = new System.Windows.Forms.TextBox();
            this.edtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.edtGiaBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtSoLuong = new System.Windows.Forms.TextBox();
            this.btnThemHang = new System.Windows.Forms.Button();
            this.edtTenHang = new System.Windows.Forms.TextBox();
            this.edtMaHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cuaHangLinhKienDataSet = new QLMuaBanLinhKien.CuaHangLinhKienDataSet();
            this.cuaHangLinhKienDataSet1 = new QLMuaBanLinhKien.CuaHangLinhKienDataSet1();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangLinhKienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangLinhKienDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edtTimKiem);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.btnTao);
            this.groupBox2.Location = new System.Drawing.Point(27, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 108);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều khiển";
            // 
            // edtTimKiem
            // 
            this.edtTimKiem.Location = new System.Drawing.Point(6, 79);
            this.edtTimKiem.Name = "edtTimKiem";
            this.edtTimKiem.Size = new System.Drawing.Size(145, 20);
            this.edtTimKiem.TabIndex = 10;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(167, 76);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(167, 39);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(86, 39);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(6, 39);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(75, 23);
            this.btnTao.TabIndex = 0;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edtMaKhachHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edtNhanVien);
            this.groupBox1.Controls.Add(this.edtThanhTien);
            this.groupBox1.Controls.Add(this.edtNgayTao);
            this.groupBox1.Controls.Add(this.edtMaHoaDon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 176);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hoá đơn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // edtMaKhachHang
            // 
            this.edtMaKhachHang.Location = new System.Drawing.Point(125, 145);
            this.edtMaKhachHang.Name = "edtMaKhachHang";
            this.edtMaKhachHang.Size = new System.Drawing.Size(124, 20);
            this.edtMaKhachHang.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã khách hàng:";
            // 
            // edtNhanVien
            // 
            this.edtNhanVien.Location = new System.Drawing.Point(125, 115);
            this.edtNhanVien.Name = "edtNhanVien";
            this.edtNhanVien.Size = new System.Drawing.Size(124, 20);
            this.edtNhanVien.TabIndex = 7;
            // 
            // edtThanhTien
            // 
            this.edtThanhTien.Enabled = false;
            this.edtThanhTien.Location = new System.Drawing.Point(125, 87);
            this.edtThanhTien.Name = "edtThanhTien";
            this.edtThanhTien.Size = new System.Drawing.Size(124, 20);
            this.edtThanhTien.TabIndex = 6;
            // 
            // edtNgayTao
            // 
            this.edtNgayTao.Location = new System.Drawing.Point(125, 58);
            this.edtNgayTao.Name = "edtNgayTao";
            this.edtNgayTao.Size = new System.Drawing.Size(124, 20);
            this.edtNgayTao.TabIndex = 5;
            // 
            // edtMaHoaDon
            // 
            this.edtMaHoaDon.Location = new System.Drawing.Point(125, 32);
            this.edtMaHoaDon.Name = "edtMaHoaDon";
            this.edtMaHoaDon.Size = new System.Drawing.Size(124, 20);
            this.edtMaHoaDon.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thành tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày tạo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hoá đơn:";
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(21, 18);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(487, 148);
            this.dgvChiTietHoaDon.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.edtGiaBan);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.edtSoLuong);
            this.groupBox3.Controls.Add(this.btnThemHang);
            this.groupBox3.Controls.Add(this.edtTenHang);
            this.groupBox3.Controls.Add(this.edtMaHang);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(50, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(747, 84);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin hàng";
            // 
            // edtGiaBan
            // 
            this.edtGiaBan.Enabled = false;
            this.edtGiaBan.Location = new System.Drawing.Point(371, 54);
            this.edtGiaBan.Name = "edtGiaBan";
            this.edtGiaBan.Size = new System.Drawing.Size(124, 20);
            this.edtGiaBan.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Giá Bán:";
            // 
            // edtSoLuong
            // 
            this.edtSoLuong.Location = new System.Drawing.Point(371, 28);
            this.edtSoLuong.Name = "edtSoLuong";
            this.edtSoLuong.Size = new System.Drawing.Size(124, 20);
            this.edtSoLuong.TabIndex = 6;
            // 
            // btnThemHang
            // 
            this.btnThemHang.Location = new System.Drawing.Point(597, 30);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(75, 23);
            this.btnThemHang.TabIndex = 16;
            this.btnThemHang.Text = "Thêm";
            this.btnThemHang.UseVisualStyleBackColor = true;
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // edtTenHang
            // 
            this.edtTenHang.Enabled = false;
            this.edtTenHang.Location = new System.Drawing.Point(125, 54);
            this.edtTenHang.Name = "edtTenHang";
            this.edtTenHang.Size = new System.Drawing.Size(124, 20);
            this.edtTenHang.TabIndex = 5;
            // 
            // edtMaHang
            // 
            this.edtMaHang.Location = new System.Drawing.Point(125, 27);
            this.edtMaHang.Name = "edtMaHang";
            this.edtMaHang.Size = new System.Drawing.Size(124, 20);
            this.edtMaHang.TabIndex = 4;
            this.edtMaHang.TabStopChanged += new System.EventHandler(this.edtMaHang_TabStopChanged);
            this.edtMaHang.TextChanged += new System.EventHandler(this.edtMaHang_TextChanged);
            this.edtMaHang.Enter += new System.EventHandler(this.edtMaHang_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã hàng";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(19, 18);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.Size = new System.Drawing.Size(489, 147);
            this.dgvHoaDon.TabIndex = 17;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvChiTietHoaDon);
            this.groupBox4.Location = new System.Drawing.Point(361, 184);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(524, 175);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sach san pham";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvHoaDon);
            this.groupBox5.Location = new System.Drawing.Point(361, 3);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(524, 176);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sach hoa don";
            // 
            // cuaHangLinhKienDataSet
            // 
            this.cuaHangLinhKienDataSet.DataSetName = "CuaHangLinhKienDataSet";
            this.cuaHangLinhKienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuaHangLinhKienDataSet1
            // 
            this.cuaHangLinhKienDataSet1.DataSetName = "CuaHangLinhKienDataSet1";
            this.cuaHangLinhKienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UC_QLBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_QLBanHang";
            this.Size = new System.Drawing.Size(932, 447);
            this.Load += new System.EventHandler(this.UC_QLBanHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangLinhKienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangLinhKienDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox edtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox edtMaKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtNhanVien;
        private System.Windows.Forms.TextBox edtThanhTien;
        private System.Windows.Forms.TextBox edtNgayTao;
        private System.Windows.Forms.TextBox edtMaHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox edtSoLuong;
        private System.Windows.Forms.TextBox edtTenHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.TextBox edtGiaBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private CuaHangLinhKienDataSet cuaHangLinhKienDataSet;
        private CuaHangLinhKienDataSet1 cuaHangLinhKienDataSet1;
        private System.Windows.Forms.TextBox edtMaHang;
    }
}
