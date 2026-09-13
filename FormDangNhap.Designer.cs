namespace QuanLyHoSoSinhVien
{
    partial class FormDangNhap
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
            lblTieuDe = new Label();
            lblDangNhap = new Label();
            lblTaiKhoan = new Label();
            lblMatKhau = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            picLogin = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogin).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTieuDe.Location = new Point(68, 361);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(295, 23);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "🎓QUẢN LÝ HỒ SƠ SINH VIÊN";
            lblTieuDe.Click += label1_Click;
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoSize = true;
            lblDangNhap.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblDangNhap.Location = new Point(552, 105);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(239, 23);
            lblDangNhap.TabIndex = 1;
            lblDangNhap.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTaiKhoan.Location = new Point(552, 168);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.RightToLeft = RightToLeft.No;
            lblTaiKhoan.Size = new Size(122, 23);
            lblTaiKhoan.TabIndex = 2;
            lblTaiKhoan.Text = "TÀI KHOẢN";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblMatKhau.Location = new Point(552, 241);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(117, 23);
            lblMatKhau.TabIndex = 3;
            lblMatKhau.Text = "MẬT KHẨU";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.ForeColor = SystemColors.WindowText;
            txtTaiKhoan.Location = new Point(552, 194);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(280, 27);
            txtTaiKhoan.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(552, 267);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(280, 27);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnDangNhap.ForeColor = SystemColors.MenuHighlight;
            btnDangNhap.Location = new Point(519, 331);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(159, 39);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnThoat.ForeColor = SystemColors.MenuHighlight;
            btnThoat.Location = new Point(745, 331);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(162, 39);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(picLogin);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblTieuDe);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 505);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Location = new Point(473, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 502);
            panel2.TabIndex = 9;
            // 
            // picLogin
            // 
            picLogin.Image = Properties.Resources._66e7955b_f01b_4b2e_86fa_b4332f6feadc;
            picLogin.Location = new Point(10, 21);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(433, 309);
            picLogin.SizeMode = PictureBoxSizeMode.Zoom;
            picLogin.TabIndex = 10;
            picLogin.TabStop = false;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 499);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTaiKhoan);
            Controls.Add(lblDangNhap);
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            Load += FormDangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblDangNhap;
        private Label lblTaiKhoan;
        private Label lblMatKhau;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
        private Panel panel1;
        private Panel panel2;
        private PictureBox picLogin;
    }
}