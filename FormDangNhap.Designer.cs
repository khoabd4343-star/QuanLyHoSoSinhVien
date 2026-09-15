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
            lblTieuDe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Location = new Point(10, 360);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(410, 40);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "🎓 QUẢN LÝ HỒ SƠ SINH VIÊN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoSize = true;
            lblDangNhap.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblDangNhap.ForeColor = Color.FromArgb(15, 23, 42);
            lblDangNhap.Location = new Point(500, 60);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(357, 41);
            lblDangNhap.TabIndex = 1;
            lblDangNhap.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTaiKhoan.ForeColor = Color.FromArgb(71, 85, 105);
            lblTaiKhoan.Location = new Point(504, 135);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(104, 23);
            lblTaiKhoan.TabIndex = 2;
            lblTaiKhoan.Text = "TÀI KHOẢN";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaiKhoan.Font = new Font("Segoe UI", 11F);
            txtTaiKhoan.ForeColor = Color.FromArgb(15, 23, 42);
            txtTaiKhoan.Location = new Point(504, 165);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(370, 32);
            txtTaiKhoan.TabIndex = 4;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMatKhau.ForeColor = Color.FromArgb(71, 85, 105);
            lblMatKhau.Location = new Point(504, 215);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(100, 23);
            lblMatKhau.TabIndex = 3;
            lblMatKhau.Text = "MẬT KHẨU";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Segoe UI", 11F);
            txtMatKhau.ForeColor = Color.FromArgb(15, 23, 42);
            txtMatKhau.Location = new Point(504, 245);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(370, 32);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(37, 99, 235);
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(504, 315);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(180, 44);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(226, 232, 240);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 213, 225);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnThoat.ForeColor = Color.FromArgb(51, 65, 85);
            btnThoat.Location = new Point(694, 315);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(180, 44);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(picLogin);
            panel1.Controls.Add(lblTieuDe);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 480);
            panel1.TabIndex = 8;
            // 
            // picLogin
            // 
            picLogin.Image = Properties.Resources._66e7955b_f01b_4b2e_86fa_b4332f6feadc;
            picLogin.Location = new Point(20, 40);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(390, 300);
            picLogin.SizeMode = PictureBoxSizeMode.Zoom;
            picLogin.TabIndex = 10;
            picLogin.TabStop = false;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(950, 480);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTaiKhoan);
            Controls.Add(lblDangNhap);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ĐĂNG NHẬP HỆ THỐNG";
            Load += FormDangNhap_Load;
            panel1.ResumeLayout(false);
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