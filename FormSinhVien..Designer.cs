namespace QuanLyHoSoSinhVien
{
    partial class FormSinhVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            cboGioiTinh = new ComboBox();
            cboLop = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            dgvSinhVien = new DataGridView();
            btnXemHoSo = new Button();
            btnQuayLai = new Button();
            btnLamMoi = new Button();
            dtpNgaySinh = new DateTimePicker();
            chkDoTre = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 85);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 139);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh:\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 190);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Giới tính:\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 252);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 4;
            label5.Text = "Lớp:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(145, 82);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 6;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(145, 22);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(125, 27);
            txtMaSV.TabIndex = 7;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Location = new Point(145, 190);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(151, 28);
            cboGioiTinh.TabIndex = 8;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(145, 244);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(151, 28);
            cboLop.TabIndex = 9;
            // 
            // chkDoTre
            // 
            chkDoTre.AutoSize = true;
            chkDoTre.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            chkDoTre.ForeColor = Color.FromArgb(71, 85, 105);
            chkDoTre.Location = new Point(315, 246);
            chkDoTre.Name = "chkDoTre";
            chkDoTre.Size = new Size(145, 24);
            chkDoTre.TabIndex = 22;
            chkDoTre.Text = "Thêm độ trễ 10s";
            chkDoTre.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(129, 306);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 10;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(298, 306);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 11;
            btnSua.Text = "SỬA";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += button2_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(447, 306);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(600, 306);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "TÌM KIẾM";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += button4_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(52, 371);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(1134, 188);
            dgvSinhVien.TabIndex = 14;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            dgvSinhVien.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnXemHoSo
            // 
            btnXemHoSo.Location = new Point(487, 212);
            btnXemHoSo.Name = "btnXemHoSo";
            btnXemHoSo.Size = new Size(138, 60);
            btnXemHoSo.TabIndex = 15;
            btnXemHoSo.Text = "XEM HỒ SƠ";
            btnXemHoSo.UseVisualStyleBackColor = true;
            btnXemHoSo.Click += btnXemHoSo_Click_1;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(487, 115);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(138, 51);
            btnQuayLai.TabIndex = 16;
            btnQuayLai.Text = "QUAY LẠI ";
            btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(742, 306);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 17;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(142, 139);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 18;
            // 
            // FormSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 590);
            Controls.Add(dtpNgaySinh);
            Controls.Add(btnLamMoi);
            Controls.Add(btnQuayLai);
            Controls.Add(btnXemHoSo);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(chkDoTre);
            Controls.Add(cboLop);
            Controls.Add(cboGioiTinh);
            Controls.Add(txtMaSV);
            Controls.Add(txtHoTen);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ HỒ SƠ SINH VIÊN";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtHoTen;
        private TextBox txtMaSV;
        private ComboBox cboGioiTinh;
        private ComboBox cboLop;
        private CheckBox chkDoTre;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private DataGridView dgvSinhVien;
        private Button btnXemHoSo;
        private Button btnQuayLai;
        private Button btnLamMoi;
        private DateTimePicker dtpNgaySinh;
    }
}
