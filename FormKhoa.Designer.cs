namespace QuanLyHoSoSinhVien
{
    partial class FormKhoa
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
            lblMaKhoa = new Label();
            lblTenKhoa = new Label();
            txtMaKhoa = new TextBox();
            txtTenKhoa = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            dgvKhoa = new DataGridView();
            btnTimKiem = new Button();
            btnQuayLai = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Location = new Point(21, 29);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new Size(66, 20);
            lblMaKhoa.TabIndex = 0;
            lblMaKhoa.Text = "Mã khoa";
            // 
            // lblTenKhoa
            // 
            lblTenKhoa.AutoSize = true;
            lblTenKhoa.Location = new Point(21, 76);
            lblTenKhoa.Name = "lblTenKhoa";
            lblTenKhoa.Size = new Size(68, 20);
            lblTenKhoa.TabIndex = 1;
            lblTenKhoa.Text = "Tên khoa";
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(143, 26);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(125, 27);
            txtMaKhoa.TabIndex = 2;
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(143, 76);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(125, 27);
            txtTenKhoa.TabIndex = 3;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(21, 170);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(174, 170);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(344, 170);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(515, 170);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(39, 231);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(73, 20);
            lblTimKiem.TabIndex = 8;
            lblTimKiem.Text = "Tìm kiếm:";
            lblTimKiem.Click += lblTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(143, 224);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(125, 27);
            txtTimKiem.TabIndex = 9;
            // 
            // dgvKhoa
            // 
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Location = new Point(39, 305);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.RowHeadersWidth = 51;
            dgvKhoa.Size = new Size(873, 188);
            dgvKhoa.TabIndex = 10;
            dgvKhoa.CellClick += dgvKhoa_CellClick;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(324, 227);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(158, 29);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += button1_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(366, 51);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(128, 52);
            btnQuayLai.TabIndex = 12;
            btnQuayLai.Text = "QUAY LẠI";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // FormKhoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 521);
            Controls.Add(btnQuayLai);
            Controls.Add(btnTimKiem);
            Controls.Add(dgvKhoa);
            Controls.Add(txtTimKiem);
            Controls.Add(lblTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTenKhoa);
            Controls.Add(txtMaKhoa);
            Controls.Add(lblTenKhoa);
            Controls.Add(lblMaKhoa);
            Name = "FormKhoa";
            Text = "FormKhoa";
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaKhoa;
        private Label lblTenKhoa;
        private TextBox txtMaKhoa;
        private TextBox txtTenKhoa;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private DataGridView dgvKhoa;
        private Button btnTimKiem;
        private Button btnQuayLai;
    }
}