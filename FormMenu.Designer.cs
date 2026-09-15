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
            panelMenu.BackColor = Color.FromArgb(30, 41, 59);
            panelMenu.Controls.Add(btnDangXuat);
            panelMenu.Controls.Add(btnLop);
            panelMenu.Controls.Add(btnNganh);
            panelMenu.Controls.Add(btnKhoa);
            panelMenu.Controls.Add(btnHoSo);
            panelMenu.Controls.Add(btnSinhVien);
            panelMenu.Controls.Add(btnTrangChu);
            panelMenu.Controls.Add(lblLogo);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(260, 894);
            panelMenu.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Ảnh_chụp_màn_hình_2026_09_11_165130;
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(241, 245, 249);
            lblLogo.Location = new Point(10, 75);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(240, 28);
            lblLogo.TabIndex = 9;
            lblLogo.Text = "HỒ SƠ SINH VIÊN";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Cursor = Cursors.Hand;
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTrangChu.ForeColor = Color.FromArgb(226, 232, 240);
            btnTrangChu.Location = new Point(0, 120);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Padding = new Padding(25, 0, 0, 0);
            btnTrangChu.Size = new Size(260, 48);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "🏠  TRANG CHỦ";
            btnTrangChu.TextAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // btnSinhVien
            // 
            btnSinhVien.Cursor = Cursors.Hand;
            btnSinhVien.FlatAppearance.BorderSize = 0;
            btnSinhVien.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            btnSinhVien.FlatStyle = FlatStyle.Flat;
            btnSinhVien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSinhVien.ForeColor = Color.FromArgb(226, 232, 240);
            btnSinhVien.Location = new Point(0, 172);
            btnSinhVien.Name = "btnSinhVien";
            btnSinhVien.Padding = new Padding(25, 0, 0, 0);
            btnSinhVien.Size = new Size(260, 48);
            btnSinhVien.TabIndex = 1;
            btnSinhVien.Text = "👨‍🎓  SINH VIÊN";
            btnSinhVien.TextAlign = ContentAlignment.MiddleLeft;
            btnSinhVien.UseVisualStyleBackColor = true;
            btnSinhVien.Click += btnSinhVien_Click;
            // 
            // btnHoSo
            // 
            btnHoSo.Cursor = Cursors.Hand;
            btnHoSo.FlatAppearance.BorderSize = 0;
            btnHoSo.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            btnHoSo.FlatStyle = FlatStyle.Flat;
            btnHoSo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHoSo.ForeColor = Color.FromArgb(226, 232, 240);
            btnHoSo.Location = new Point(0, 224);
            btnHoSo.Name = "btnHoSo";
            btnHoSo.Padding = new Padding(25, 0, 0, 0);
            btnHoSo.Size = new Size(260, 48);
            btnHoSo.TabIndex = 2;
            btnHoSo.Text = "📋  HỒ SƠ SINH VIÊN";
            btnHoSo.TextAlign = ContentAlignment.MiddleLeft;
            btnHoSo.UseVisualStyleBackColor = true;
            btnHoSo.Click += btnHoSo_Click;
            // 
            // btnKhoa
            // 
            btnKhoa.Cursor = Cursors.Hand;
            btnKhoa.FlatAppearance.BorderSize = 0;
            btnKhoa.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            btnKhoa.FlatStyle = FlatStyle.Flat;
            btnKhoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKhoa.ForeColor = Color.FromArgb(226, 232, 240);
            btnKhoa.Location = new Point(0, 276);
            btnKhoa.Name = "btnKhoa";
            btnKhoa.Padding = new Padding(25, 0, 0, 0);
            btnKhoa.Size = new Size(260, 48);
            btnKhoa.TabIndex = 3;
            btnKhoa.Text = "🏢  QUẢN LÝ KHOA";
            btnKhoa.TextAlign = ContentAlignment.MiddleLeft;
            btnKhoa.UseVisualStyleBackColor = true;
            btnKhoa.Click += btnKhoa_Click;
            // 
            // btnNganh
            // 
            btnNganh.Cursor = Cursors.Hand;
            btnNganh.FlatAppearance.BorderSize = 0;
            btnNganh.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            btnNganh.FlatStyle = FlatStyle.Flat;
            btnNganh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNganh.ForeColor = Color.FromArgb(226, 232, 240);
            btnNganh.Location = new Point(0, 328);
            btnNganh.Name = "btnNganh";
            btnNganh.Padding = new Padding(25, 0, 0, 0);
            btnNganh.Size = new Size(260, 48);
            btnNganh.TabIndex = 4;
            btnNganh.Text = "📚  QUẢN LÝ NGÀNH";
            btnNganh.TextAlign = ContentAlignment.MiddleLeft;
            btnNganh.UseVisualStyleBackColor = true;
            btnNganh.Click += btnNganh_Click;
            // 
            // btnLop
            // 
            btnLop.Cursor = Cursors.Hand;
            btnLop.FlatAppearance.BorderSize = 0;
            btnLop.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            btnLop.FlatStyle = FlatStyle.Flat;
            btnLop.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLop.ForeColor = Color.FromArgb(226, 232, 240);
            btnLop.Location = new Point(0, 380);
            btnLop.Name = "btnLop";
            btnLop.Padding = new Padding(25, 0, 0, 0);
            btnLop.Size = new Size(260, 48);
            btnLop.TabIndex = 5;
            btnLop.Text = "🏫  QUẢN LÝ LỚP";
            btnLop.TextAlign = ContentAlignment.MiddleLeft;
            btnLop.UseVisualStyleBackColor = true;
            btnLop.Click += btnLop_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.FromArgb(185, 28, 28);
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 38, 38);
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Location = new Point(0, 844);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(25, 0, 0, 0);
            btnDangXuat.Size = new Size(260, 50);
            btnDangXuat.TabIndex = 6;
            btnDangXuat.Text = "🚪  ĐĂNG XUẤT";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // panelNoiDung
            // 
            panelNoiDung.BackColor = Color.FromArgb(248, 250, 252);
            panelNoiDung.Dock = DockStyle.Fill;
            panelNoiDung.Location = new Point(260, 0);
            panelNoiDung.Name = "panelNoiDung";
            panelNoiDung.Size = new Size(1472, 894);
            panelNoiDung.TabIndex = 11;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1732, 894);
            Controls.Add(panelNoiDung);
            Controls.Add(panelMenu);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HỆ THỐNG QUẢN LÝ HỒ SƠ SINH VIÊN";
            WindowState = FormWindowState.Maximized;
            Load += FormMenu_Load;
            panelMenu.ResumeLayout(false);
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