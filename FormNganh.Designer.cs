namespace QuanLyHoSoSinhVien
{
    partial class FormNganh
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
            lblMaNganh = new Label();
            lblTenNganh = new Label();
            txtMaNganh = new TextBox();
            txtTenNganh = new TextBox();
            lblKhoa = new Label();
            cboKhoa = new ComboBox();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            dgvNganh = new DataGridView();
            btnTimKiem = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnQuayLai = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNganh).BeginInit();
            SuspendLayout();
            // 
            // lblMaNganh
            // 
            lblMaNganh.AutoSize = true;
            lblMaNganh.Location = new Point(35, 86);
            lblMaNganh.Name = "lblMaNganh";
            lblMaNganh.Size = new Size(82, 20);
            lblMaNganh.TabIndex = 0;
            lblMaNganh.Text = "Mã ngành :";
            // 
            // lblTenNganh
            // 
            lblTenNganh.AutoSize = true;
            lblTenNganh.Location = new Point(35, 132);
            lblTenNganh.Name = "lblTenNganh";
            lblTenNganh.Size = new Size(84, 20);
            lblTenNganh.TabIndex = 1;
            lblTenNganh.Text = "Tên ngành :";
            // 
            // txtMaNganh
            // 
            txtMaNganh.Location = new Point(195, 86);
            txtMaNganh.Name = "txtMaNganh";
            txtMaNganh.Size = new Size(205, 27);
            txtMaNganh.TabIndex = 2;
            txtMaNganh.TextChanged += txtMaNganh_TextChanged;
            // 
            // txtTenNganh
            // 
            txtTenNganh.Location = new Point(195, 132);
            txtTenNganh.Name = "txtTenNganh";
            txtTenNganh.Size = new Size(205, 27);
            txtTenNganh.TabIndex = 3;
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new Point(46, 189);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(50, 20);
            lblKhoa.TabIndex = 4;
            lblKhoa.Text = "Khoa :";
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(195, 186);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(151, 28);
            cboKhoa.TabIndex = 5;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(46, 253);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(77, 20);
            lblTimKiem.TabIndex = 6;
            lblTimKiem.Text = "Tìm kiếm :";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(195, 246);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(125, 27);
            txtTimKiem.TabIndex = 7;
            // 
            // dgvNganh
            // 
            dgvNganh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNganh.Location = new Point(46, 303);
            dgvNganh.Name = "dgvNganh";
            dgvNganh.RowHeadersWidth = 51;
            dgvNganh.Size = new Size(821, 188);
            dgvNganh.TabIndex = 8;
            dgvNganh.CellClick += dgvNganh_CellClick;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(357, 244);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "Tìm Kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(616, 40);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button2_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(616, 100);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(616, 166);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button4_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(616, 231);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(748, 109);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(142, 72);
            btnQuayLai.TabIndex = 14;
            btnQuayLai.Text = "QUAY LẠI";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // FormNganh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 503);
            Controls.Add(btnQuayLai);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnTimKiem);
            Controls.Add(dgvNganh);
            Controls.Add(txtTimKiem);
            Controls.Add(lblTimKiem);
            Controls.Add(cboKhoa);
            Controls.Add(lblKhoa);
            Controls.Add(txtTenNganh);
            Controls.Add(txtMaNganh);
            Controls.Add(lblTenNganh);
            Controls.Add(lblMaNganh);
            Name = "FormNganh";
            Text = "FormNganh";
            ((System.ComponentModel.ISupportInitialize)dgvNganh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaNganh;
        private Label lblTenNganh;
        private TextBox txtMaNganh;
        private TextBox txtTenNganh;
        private Label lblKhoa;
        private ComboBox cboKhoa;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private DataGridView dgvNganh;
        private Button btnTimKiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnQuayLai;
    }
}