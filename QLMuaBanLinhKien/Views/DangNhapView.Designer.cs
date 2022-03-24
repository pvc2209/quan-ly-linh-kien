
namespace QLMuaBanLinhKien
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtTaiKhoan = new System.Windows.Forms.TextBox();
            this.edtMatKhau = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // edtTaiKhoan
            // 
            this.edtTaiKhoan.Location = new System.Drawing.Point(154, 21);
            this.edtTaiKhoan.Name = "edtTaiKhoan";
            this.edtTaiKhoan.Size = new System.Drawing.Size(183, 20);
            this.edtTaiKhoan.TabIndex = 2;
            // 
            // edtMatKhau
            // 
            this.edtMatKhau.Location = new System.Drawing.Point(154, 65);
            this.edtMatKhau.Name = "edtMatKhau";
            this.edtMatKhau.Size = new System.Drawing.Size(183, 20);
            this.edtMatKhau.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edtMatKhau);
            this.panel1.Controls.Add(this.edtTaiKhoan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(47, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 115);
            this.panel1.TabIndex = 4;
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(201, 183);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(74, 27);
            this.btDangNhap.TabIndex = 5;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 246);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtTaiKhoan;
        private System.Windows.Forms.TextBox edtMatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDangNhap;
    }
}

