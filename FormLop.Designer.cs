namespace QuanLyHoSoSinhVien
{
    partial class FormLop
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            labelMaLop = new Label();
            labelTenLop = new Label();
            lblMaNganh = new Label();
            labelKhoaHoc = new Label();
            txtMaLop = new TextBox();
            txtTenLop = new TextBox();
            txtKhoaHoc = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnTimKiem = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            dgvLop = new DataGridView();
            btnQuayLai = new Button();
            cboNganh = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvLop).BeginInit();
            SuspendLayout();
            // 
            // labelMaLop
            // 
            labelMaLop.AutoSize = true;
            labelMaLop.Location = new Point(32, 43);
            labelMaLop.Name = "labelMaLop";
            labelMaLop.Size = new Size(56, 20);
            labelMaLop.TabIndex = 0;
            labelMaLop.Text = "Mã lớp";
            // 
            // labelTenLop
            // 
            labelTenLop.AutoSize = true;
            labelTenLop.Location = new Point(32, 105);
            labelTenLop.Name = "labelTenLop";
            labelTenLop.Size = new Size(58, 20);
            labelTenLop.TabIndex = 1;
            labelTenLop.Text = "Tên lớp";
            labelTenLop.Click += label2_Click;
            // 
            // lblMaNganh
            // 
            lblMaNganh.AutoSize = true;
            lblMaNganh.Location = new Point(373, 39);
            lblMaNganh.Name = "lblMaNganh";
            lblMaNganh.Size = new Size(79, 20);
            lblMaNganh.TabIndex = 2;
            lblMaNganh.Text = " Mã ngành";
            lblMaNganh.Click += label3_Click;
            // 
            // labelKhoaHoc
            // 
            labelKhoaHoc.AutoSize = true;
            labelKhoaHoc.Location = new Point(373, 120);
            labelKhoaHoc.Name = "labelKhoaHoc";
            labelKhoaHoc.Size = new Size(71, 20);
            labelKhoaHoc.TabIndex = 3;
            labelKhoaHoc.Text = "Khóa học";
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(115, 36);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(125, 27);
            txtMaLop.TabIndex = 4;
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(115, 105);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(125, 27);
            txtTenLop.TabIndex = 5;
            // 
            // txtKhoaHoc
            // 
            txtKhoaHoc.Location = new Point(519, 117);
            txtKhoaHoc.Name = "txtKhoaHoc";
            txtKhoaHoc.Size = new Size(125, 27);
            txtKhoaHoc.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 187);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(187, 187);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(350, 187);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(504, 187);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 11;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(280, 249);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(32, 257);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(73, 20);
            lblTimKiem.TabIndex = 13;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(115, 250);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(125, 27);
            txtTimKiem.TabIndex = 14;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // dgvLop
            // 
            dgvLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLop.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLop.Location = new Point(12, 376);
            dgvLop.MultiSelect = false;
            dgvLop.Name = "dgvLop";
            dgvLop.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLop.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLop.RowHeadersWidth = 51;
            dgvLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLop.Size = new Size(975, 188);
            dgvLop.TabIndex = 15;
            dgvLop.CellClick += dgvLop_CellClick;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(760, 73);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(133, 59);
            btnQuayLai.TabIndex = 16;
            btnQuayLai.Text = " QUAY LẠI";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // cboNganh
            // 
            cboNganh.FormattingEnabled = true;
            cboNganh.Location = new Point(519, 35);
            cboNganh.Name = "cboNganh";
            cboNganh.Size = new Size(151, 28);
            cboNganh.TabIndex = 17;
            // 
            // FormLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 603);
            Controls.Add(cboNganh);
            Controls.Add(btnQuayLai);
            Controls.Add(dgvLop);
            Controls.Add(txtTimKiem);
            Controls.Add(lblTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtKhoaHoc);
            Controls.Add(txtTenLop);
            Controls.Add(txtMaLop);
            Controls.Add(labelKhoaHoc);
            Controls.Add(lblMaNganh);
            Controls.Add(labelTenLop);
            Controls.Add(labelMaLop);
            Name = "FormLop";
            Text = "Quản lý lớp";
            Load += FormLop_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMaLop;
        private Label labelTenLop;
        private Label labelMaNganh;
        private Label labelKhoaHoc;
        private TextBox txtMaLop;
        private TextBox txtTenLop;
        private TextBox txtKhoaHoc;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private DataGridView dgvLop;
        private Label lblMaNganh;
        private Button btnQuayLai;
        private ComboBox cboNganh;
    }
}