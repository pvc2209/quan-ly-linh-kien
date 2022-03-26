
namespace QLMuaBanLinhKien.Views
{
    partial class ThongKeView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThongKeDoanhThu = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongKeTongTien = new Guna.UI2.WinForms.Guna2Button();
            this.cbbNam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvThongKe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThongKeDoanhThu
            // 
            this.btnThongKeDoanhThu.BorderRadius = 8;
            this.btnThongKeDoanhThu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKeDoanhThu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKeDoanhThu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKeDoanhThu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKeDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongKeDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnThongKeDoanhThu.Location = new System.Drawing.Point(39, 246);
            this.btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            this.btnThongKeDoanhThu.Size = new System.Drawing.Size(149, 45);
            this.btnThongKeDoanhThu.TabIndex = 19;
            this.btnThongKeDoanhThu.Text = "Thống kê doanh thu theo tháng";
            this.btnThongKeDoanhThu.Click += new System.EventHandler(this.btnThongKeDoanhThu_Click);
            // 
            // btnThongKeTongTien
            // 
            this.btnThongKeTongTien.BorderRadius = 8;
            this.btnThongKeTongTien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKeTongTien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKeTongTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKeTongTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKeTongTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongKeTongTien.ForeColor = System.Drawing.Color.White;
            this.btnThongKeTongTien.Location = new System.Drawing.Point(39, 174);
            this.btnThongKeTongTien.Name = "btnThongKeTongTien";
            this.btnThongKeTongTien.Size = new System.Drawing.Size(149, 43);
            this.btnThongKeTongTien.TabIndex = 20;
            this.btnThongKeTongTien.Text = "Thống kê tổng tiền nhập theo tháng";
            this.btnThongKeTongTien.Click += new System.EventHandler(this.btnThongKeTongTien_Click);
            // 
            // cbbNam
            // 
            this.cbbNam.BackColor = System.Drawing.Color.Transparent;
            this.cbbNam.BorderRadius = 8;
            this.cbbNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbNam.ForeColor = System.Drawing.Color.Black;
            this.cbbNam.ItemHeight = 30;
            this.cbbNam.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbbNam.Location = new System.Drawing.Point(78, 85);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(110, 36);
            this.cbbNam.TabIndex = 21;
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BorderRadius = 8;
            this.guna2GroupBox4.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox4.Controls.Add(this.btnThongKeDoanhThu);
            this.guna2GroupBox4.Controls.Add(this.btnThongKeTongTien);
            this.guna2GroupBox4.Controls.Add(this.cbbNam);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(225)))));
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox4.Location = new System.Drawing.Point(26, 33);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(222, 378);
            this.guna2GroupBox4.TabIndex = 25;
            this.guna2GroupBox4.Text = "Điều khiển";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(10, 95);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(54, 15);
            this.guna2HtmlLabel3.TabIndex = 22;
            this.guna2HtmlLabel3.Text = "Chọn năm:";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvThongKe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongKe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongKe.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongKe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongKe.EnableHeadersVisualStyles = false;
            this.dgvThongKe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongKe.Location = new System.Drawing.Point(278, 33);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(635, 378);
            this.dgvThongKe.TabIndex = 26;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongKe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongKe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongKe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvThongKe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongKe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvThongKe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongKe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongKe.ThemeStyle.HeaderStyle.Height = 24;
            this.dgvThongKe.ThemeStyle.ReadOnly = true;
            this.dgvThongKe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongKe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongKe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvThongKe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongKe.ThemeStyle.RowsStyle.Height = 22;
            this.dgvThongKe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongKe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ThongKeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.guna2GroupBox4);
            this.Name = "ThongKeView";
            this.Size = new System.Drawing.Size(932, 433);
            this.Load += new System.EventHandler(this.ThongKeView_Load);
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnThongKeDoanhThu;
        private Guna.UI2.WinForms.Guna2Button btnThongKeTongTien;
        private Guna.UI2.WinForms.Guna2ComboBox cbbNam;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongKe;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}
