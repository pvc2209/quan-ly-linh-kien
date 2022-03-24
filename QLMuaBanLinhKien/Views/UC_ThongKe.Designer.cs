
namespace QLMuaBanLinhKien.Views
{
    partial class UC_ThongKe
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
            this.btnThongKeDoanhThuThang = new System.Windows.Forms.Button();
            this.btnTongTienHangNhapTheoThang = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThongKeDoanhThuThang
            // 
            this.btnThongKeDoanhThuThang.Location = new System.Drawing.Point(23, 17);
            this.btnThongKeDoanhThuThang.Name = "btnThongKeDoanhThuThang";
            this.btnThongKeDoanhThuThang.Size = new System.Drawing.Size(193, 23);
            this.btnThongKeDoanhThuThang.TabIndex = 0;
            this.btnThongKeDoanhThuThang.Text = "Thống kê doanh thu theo tháng";
            this.btnThongKeDoanhThuThang.UseVisualStyleBackColor = true;
            // 
            // btnTongTienHangNhapTheoThang
            // 
            this.btnTongTienHangNhapTheoThang.Location = new System.Drawing.Point(222, 17);
            this.btnTongTienHangNhapTheoThang.Name = "btnTongTienHangNhapTheoThang";
            this.btnTongTienHangNhapTheoThang.Size = new System.Drawing.Size(193, 23);
            this.btnTongTienHangNhapTheoThang.TabIndex = 1;
            this.btnTongTienHangNhapTheoThang.Text = "Tổng tiền hàng nhập theo tháng";
            this.btnTongTienHangNhapTheoThang.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(715, 274);
            this.dataGridView1.TabIndex = 2;
            // 
            // UC_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTongTienHangNhapTheoThang);
            this.Controls.Add(this.btnThongKeDoanhThuThang);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(800, 402);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThongKeDoanhThuThang;
        private System.Windows.Forms.Button btnTongTienHangNhapTheoThang;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
