namespace QuanLyHoSoSinhVien
{
    partial class FormCanhBaoHoSo
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

        private void InitializeComponent()
        {
            dgvCanhBao = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dgvCanhBao).BeginInit();

            SuspendLayout();

            // 
            // dgvCanhBao
            // 
            dgvCanhBao.AllowUserToAddRows = false;

            dgvCanhBao.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvCanhBao.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvCanhBao.Dock = DockStyle.Fill;

            dgvCanhBao.Location = new Point(0, 0);

            dgvCanhBao.Name = "dgvCanhBao";

            dgvCanhBao.ReadOnly = true;

            dgvCanhBao.RowHeadersWidth = 51;

            dgvCanhBao.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvCanhBao.Size = new Size(800, 450);

            dgvCanhBao.TabIndex = 0;

            // 
            // FormCanhBaoHoSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);

            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(800, 450);

            Controls.Add(dgvCanhBao);

            Name = "FormCanhBaoHoSo";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "⚠ DANH SÁCH HỒ SƠ CHƯA HOÀN THIỆN";

            ((System.ComponentModel.ISupportInitialize)dgvCanhBao).EndInit();

            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCanhBao;
    }
}