namespace QuanLyHoSoSinhVien
{
    partial class FormMenu
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
            panelMenu = new Panel();
            pictureBox1 = new PictureBox();
            lblLogo = new Label();
            btnKhoa = new Button();
            btnDangXuat = new Button();
            btnTrangChu = new Button();
            btnNganh = new Button();
            btnLop = new Button();
            btnHoSo = new Button();
            btnSinhVien = new Button();
            panelNoiDung = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(lblLogo);
            panelMenu.Controls.Add(btnKhoa);
            panelMenu.Controls.Add(btnDangXuat);
            panelMenu.Controls.Add(btnTrangChu);
            panelMenu.Controls.Add(btnNganh);
            panelMenu.Controls.Add(btnLop);
            panelMenu.Controls.Add(btnHoSo);
            panelMenu.Controls.Add(btnSinhVien);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(240, 894);
            panelMenu.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Ảnh_chụp_màn_hình_2026_09_11_165130;
            pictureBox1.Location = new Point(35, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point(12, 60);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(203, 20);
            lblLogo.TabIndex = 9;
            lblLogo.Text = "QUẢN LÝ HỒ SƠ SINH VIÊN";
            // 
            // btnKhoa
            // 
            btnKhoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKhoa.Location = new Point(-16, 238);
            btnKhoa.Name = "btnKhoa";
            btnKhoa.Size = new Size(236, 29);
            btnKhoa.TabIndex = 1;
            btnKhoa.Text = " 🏢 QUẢN LÝ KHOA\n";
            btnKhoa.UseVisualStyleBackColor = true;
            btnKhoa.Click += btnKhoa_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDangXuat.Location = new Point(0, 450);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(220, 38);
            btnDangXuat.TabIndex = 7;
            btnDangXuat.Text = "↩  ĐĂNG XUẤT";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTrangChu.Location = new Point(0, 133);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(220, 29);
            btnTrangChu.TabIndex = 8;
            btnTrangChu.Text = "🏠 TRANG CHỦ";
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // btnNganh
            // 
            btnNganh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNganh.Location = new Point(1, 273);
            btnNganh.Name = "btnNganh";
            btnNganh.Size = new Size(219, 29);
            btnNganh.TabIndex = 2;
            btnNganh.Text = "📚 QUẢN LÝ NGÀNH\n";
            btnNganh.UseVisualStyleBackColor = true;
            btnNganh.Click += btnNganh_Click;
            // 
            // btnLop
            // 
            btnLop.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLop.Location = new Point(1, 308);
            btnLop.Name = "btnLop";
            btnLop.Size = new Size(219, 32);
            btnLop.TabIndex = 3;
            btnLop.Text = "🏫 QUẢN LÝ LỚP\n";
            btnLop.UseVisualStyleBackColor = true;
            btnLop.Click += btnLop_Click;
            // 
            // btnHoSo
            // 
            btnHoSo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHoSo.Location = new Point(0, 203);
            btnHoSo.Name = "btnHoSo";
            btnHoSo.Size = new Size(220, 29);
            btnHoSo.TabIndex = 5;
            btnHoSo.Text = "📄 QUẢN LÝ HỒ SƠ\n";
            btnHoSo.UseVisualStyleBackColor = true;
            btnHoSo.Click += btnHoSo_Click;
            // 
            // btnSinhVien
            // 
            btnSinhVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSinhVien.Location = new Point(0, 168);
            btnSinhVien.Name = "btnSinhVien";
            btnSinhVien.Size = new Size(220, 29);
            btnSinhVien.TabIndex = 4;
            btnSinhVien.Text = "👨 QUẢN LÝ SINH VIÊN\n";
            btnSinhVien.UseVisualStyleBackColor = true;
            btnSinhVien.Click += btnSinhVien_Click;
            // 
            // panelNoiDung
            // 
            panelNoiDung.Location = new Point(297, 0);
            panelNoiDung.Name = "panelNoiDung";
            panelNoiDung.Size = new Size(1399, 894);
            panelNoiDung.TabIndex = 11;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1732, 894);
            Controls.Add(panelMenu);
            Controls.Add(panelNoiDung);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HỆ THỐNG QUẢN LÝ HỒ SƠ SINH VIÊN";
            WindowState = FormWindowState.Maximized;
            Load += FormMenu_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private PictureBox pictureBox1;
        private Label lblLogo;
        private Button btnKhoa;
        private Button btnDangXuat;
        private Button btnTrangChu;
        private Button btnNganh;
        private Button btnLop;
        private Button btnHoSo;
        private Button btnSinhVien;
        private Panel panelNoiDung;
    }
}