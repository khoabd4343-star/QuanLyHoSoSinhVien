using Microsoft.Data.SqlClient;
using System.Data;

namespace QuanLyHoSoSinhVien
{
    public partial class FormSinhVien : Form
    {
        public FormSinhVien()
        {
            InitializeComponent();

            LoadSinhVien();
            LoadLop();
            LoadGioiTinh();
        }

        // ================= LOAD DANH SÁCH SINH VIÊN =================

        private void LoadSinhVien()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                string query = @"
                    SELECT
                        SV.MaSV,
                        SV.HoTen,
                        SV.NgaySinh,
                        SV.GioiTinh,
                        SV.MaLop,
                        L.TenLop,
                        N.TenNganh,
                        K.TenKhoa
                    FROM SINHVIEN SV
                    INNER JOIN LOP L ON SV.MaLop = L.MaLop
                    INNER JOIN NGANH N ON L.MaNganh = N.MaNganh
                    INNER JOIN KHOA K ON N.MaKhoa = K.MaKhoa";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvSinhVien.DataSource = table;

                dgvSinhVien.Columns["MaSV"].HeaderText = "Mã sinh viên";
                dgvSinhVien.Columns["HoTen"].HeaderText = "Họ tên";
                dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvSinhVien.Columns["MaLop"].HeaderText = "Mã lớp";
                dgvSinhVien.Columns["TenLop"].HeaderText = "Tên lớp";
                dgvSinhVien.Columns["TenNganh"].HeaderText = "Tên ngành";
                dgvSinhVien.Columns["TenKhoa"].HeaderText = "Tên khoa";

                dgvSinhVien.Columns["MaLop"].Visible = false;

                // Hiển thị ngày/tháng/năm
                dgvSinhVien.Columns["NgaySinh"].DefaultCellStyle.Format =
                    "dd/MM/yyyy";
            }
        }

        // ================= LOAD LỚP =================

        private void LoadLop()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                string query = "SELECT MaLop, TenLop FROM LOP";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();

                adapter.Fill(table);

                cboLop.DataSource = table;
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";

                cboLop.SelectedIndex = -1;
            }
        }

        // ================= LOAD GIỚI TÍNH =================

        private void LoadGioiTinh()
        {
            cboGioiTinh.Items.Clear();

            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");

            cboGioiTinh.SelectedIndex = -1;
        }

        // ================= KIỂM TRA DỮ LIỆU =================

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!");
                txtMaSV.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên sinh viên!");
                txtHoTen.Focus();
                return false;
            }

            if (cboGioiTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return false;
            }

            if (cboLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp!");
                return false;
            }

            return true;
        }

        // ================= LÀM MỚI FORM =================

        private void LamMoiForm()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();

            dtpNgaySinh.Value = DateTime.Today;

            cboGioiTinh.SelectedIndex = -1;
            cboLop.SelectedIndex = -1;

            txtMaSV.Focus();
        }

        // ================= THÊM SINH VIÊN =================

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string query = @"
                        INSERT INTO SINHVIEN
                        (MaSV, HoTen, NgaySinh, GioiTinh, MaLop)
                        VALUES
                        (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @MaLop)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@MaSV",
                        txtMaSV.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@HoTen",
                        txtHoTen.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@NgaySinh",
                        dtpNgaySinh.Value.Date
                    );

                    cmd.Parameters.AddWithValue(
                        "@GioiTinh",
                        cboGioiTinh.Text
                    );

                    cmd.Parameters.AddWithValue(
                        "@MaLop",
                        cboLop.SelectedValue.ToString()
                    );

                    conn.Open();

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm sinh viên thành công!");

                        LoadSinhVien();
                        LamMoiForm();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
        }

        // ================= SỬA SINH VIÊN =================

        private void button2_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string query = @"
                        UPDATE SINHVIEN
                        SET
                            HoTen = @HoTen,
                            NgaySinh = @NgaySinh,
                            GioiTinh = @GioiTinh,
                            MaLop = @MaLop
                        WHERE MaSV = @MaSV";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@MaSV",
                        txtMaSV.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@HoTen",
                        txtHoTen.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@NgaySinh",
                        dtpNgaySinh.Value.Date
                    );

                    cmd.Parameters.AddWithValue(
                        "@GioiTinh",
                        cboGioiTinh.Text
                    );

                    cmd.Parameters.AddWithValue(
                        "@MaLop",
                        cboLop.SelectedValue.ToString()
                    );

                    conn.Open();

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thông tin thành công!");

                        LoadSinhVien();
                        LamMoiForm();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên cần sửa!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // ================= XÓA SINH VIÊN =================

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    string maSV = txtMaSV.Text.Trim();

                    string queryHoSo =
                        "DELETE FROM HOSOSINHVIEN WHERE MaSV = @MaSV";

                    using (SqlCommand cmdHoSo =
                        new SqlCommand(queryHoSo, conn))
                    {
                        cmdHoSo.Parameters.AddWithValue(
                            "@MaSV",
                            maSV
                        );

                        cmdHoSo.ExecuteNonQuery();
                    }

                    string querySinhVien =
                        "DELETE FROM SINHVIEN WHERE MaSV = @MaSV";

                    using (SqlCommand cmdSinhVien =
                        new SqlCommand(querySinhVien, conn))
                    {
                        cmdSinhVien.Parameters.AddWithValue(
                            "@MaSV",
                            maSV
                        );

                        int result = cmdSinhVien.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Xóa sinh viên thành công!");

                            LoadSinhVien();
                            LamMoiForm();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy sinh viên cần xóa!"
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // ================= TÌM KIẾM =================

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string maSV = txtMaSV.Text.Trim();
                    string hoTen = txtHoTen.Text.Trim();

                    string gioiTinh =
                        cboGioiTinh.SelectedItem?.ToString() ?? "";

                    string maLop = "";

                    if (cboLop.SelectedValue != null)
                    {
                        maLop = cboLop.SelectedValue.ToString();
                    }

                    string query = @"
                        SELECT
                            SV.MaSV,
                            SV.HoTen,
                            SV.NgaySinh,
                            SV.GioiTinh,
                            SV.MaLop,
                            L.TenLop,
                            N.TenNganh,
                            K.TenKhoa
                        FROM SINHVIEN SV
                        INNER JOIN LOP L ON SV.MaLop = L.MaLop
                        INNER JOIN NGANH N ON L.MaNganh = N.MaNganh
                        INNER JOIN KHOA K ON N.MaKhoa = K.MaKhoa
                        WHERE 1 = 1";

                    if (!string.IsNullOrWhiteSpace(maSV))
                        query += " AND SV.MaSV LIKE '%' + @MaSV + '%'";

                    if (!string.IsNullOrWhiteSpace(hoTen))
                        query += " AND SV.HoTen LIKE '%' + @HoTen + '%'";

                    if (!string.IsNullOrWhiteSpace(gioiTinh))
                        query += " AND SV.GioiTinh = @GioiTinh";

                    if (!string.IsNullOrWhiteSpace(maLop))
                        query += " AND SV.MaLop = @MaLop";

                    SqlDataAdapter adapter =
                        new SqlDataAdapter(query, conn);

                    if (!string.IsNullOrWhiteSpace(maSV))
                        adapter.SelectCommand.Parameters.AddWithValue(
                            "@MaSV", maSV
                        );

                    if (!string.IsNullOrWhiteSpace(hoTen))
                        adapter.SelectCommand.Parameters.AddWithValue(
                            "@HoTen", hoTen
                        );

                    if (!string.IsNullOrWhiteSpace(gioiTinh))
                        adapter.SelectCommand.Parameters.AddWithValue(
                            "@GioiTinh", gioiTinh
                        );

                    if (!string.IsNullOrWhiteSpace(maLop))
                        adapter.SelectCommand.Parameters.AddWithValue(
                            "@MaLop", maLop
                        );

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvSinhVien.DataSource = table;

                    dgvSinhVien.Columns["NgaySinh"]
                        .DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // ================= CLICK DATAGRIDVIEW =================

        private void dgvSinhVien_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvSinhVien.Rows[e.RowIndex];

                txtMaSV.Text =
                    row.Cells["MaSV"].Value?.ToString();

                txtHoTen.Text =
                    row.Cells["HoTen"].Value?.ToString();

                if (row.Cells["NgaySinh"].Value != null &&
                    row.Cells["NgaySinh"].Value != DBNull.Value)
                {
                    dtpNgaySinh.Value =
                        Convert.ToDateTime(
                            row.Cells["NgaySinh"].Value
                        );
                }

                cboGioiTinh.Text =
                    row.Cells["GioiTinh"].Value?.ToString();

                if (row.Cells["MaLop"].Value != null)
                {
                    cboLop.SelectedValue =
                        row.Cells["MaLop"].Value.ToString();
                }
            }
        }

        // ================= XEM HỒ SƠ =================

        private void btnXemHoSo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn sinh viên trước!"
                );

                return;
            }

            string maSV = txtMaSV.Text.Trim();

            btnQuayLai formHoSo =
                new btnQuayLai(maSV, true);

            formHoSo.ShowDialog();
        }

        private void btnXemHoSo_Click_1(
            object sender,
            EventArgs e)
        {
            btnXemHoSo_Click(sender, e);
        }

        private void Form1_Load(
            object sender,
            EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(
            object sender,
            EventArgs e)
        {

        }

        private void btnLamMoi_Click(
            object sender,
            EventArgs e)
        {
            LamMoiForm();
            LoadSinhVien();
        }
    }
}