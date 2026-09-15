namespace QuanLyHoSoSinhVien
{
    partial class btnQuayLai
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMaHoSo = new TextBox();
            txtMaSV = new TextBox();
            txtCCCD = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            txtQueQuan = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            dgvHoSo = new DataGridView();
            button1 = new Button();
            btnLamMoi = new Button();
            btnXuatExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHoSo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã hồ sơ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "CCCD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 240);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 4;
            label5.Text = "Quê quán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 293);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 5;
            label6.Text = "SĐT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 341);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // txtMaHoSo
            // 
            txtMaHoSo.Location = new Point(132, 82);
            txtMaHoSo.Name = "txtMaHoSo";
            txtMaHoSo.Size = new Size(205, 27);
            txtMaHoSo.TabIndex = 7;
            txtMaHoSo.TextChanged += textBox1_TextChanged;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(132, 27);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(205, 27);
            txtMaSV.TabIndex = 8;
            txtMaSV.TextChanged += textBox2_TextChanged;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(132, 131);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(205, 27);
            txtCCCD.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(132, 286);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(205, 27);
            txtSDT.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(132, 334);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(205, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(132, 178);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(205, 27);
            txtDiaChi.TabIndex = 12;
            txtDiaChi.TextChanged += textBox6_TextChanged;
            // 
            // txtQueQuan
            // 
            txtQueQuan.Location = new Point(132, 233);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(205, 27);
            txtQueQuan.TabIndex = 13;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(558, 50);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 14;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(558, 134);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 15;
            btnSua.Text = "SỬA";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(558, 201);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(558, 258);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "TÌM KIẾM";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvHoSo
            // 
            dgvHoSo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoSo.Location = new Point(12, 420);
            dgvHoSo.Name = "dgvHoSo";
            dgvHoSo.RowHeadersWidth = 51;
            dgvHoSo.Size = new Size(1093, 222);
            dgvHoSo.TabIndex = 18;
            dgvHoSo.CellClick += dgvHoSo_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(809, 178);
            button1.Name = "button1";
            button1.Size = new Size(133, 52);
            button1.TabIndex = 19;
            button1.Text = "QUAY LẠI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(558, 337);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 20;
            btnLamMoi.Text = "LÀM MỚI  ";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(809, 284);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(133, 47);
            btnXuatExcel.TabIndex = 21;
            btnXuatExcel.Text = "XUẤT EXCEL";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnQuayLai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 638);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnLamMoi);
            Controls.Add(button1);
            Controls.Add(dgvHoSo);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtQueQuan);
            Controls.Add(txtDiaChi);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtCCCD);
            Controls.Add(txtMaSV);
            Controls.Add(txtMaHoSo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "btnQuayLai";
            Text = "FormHoSo";
            Load += FormHoSo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHoSo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMaHoSo;
        private TextBox txtMaSV;
        private TextBox txtCCCD;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtDiaChi;
        private TextBox txtQueQuan;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private DataGridView dgvHoSo;
        private Button button1;
        private Button btnLamMoi;
        private Button btnXuatExcel;
    }
}