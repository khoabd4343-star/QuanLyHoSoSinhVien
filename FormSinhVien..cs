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

            // Cập nhật lại danh sách lớp và sĩ số
            LoadLop();
        }

        // ================= LOAD LỚP =================

        private void LoadLop()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                string query = @"
                    SELECT 
                        L.MaLop, 
                        L.TenLop + ' (' + CAST(COUNT(SV.MaSV) AS VARCHAR) + '/30)' AS TenLopHienThi
                    FROM LOP L
                    LEFT JOIN SINHVIEN SV ON L.MaLop = SV.MaLop
                    GROUP BY L.MaLop, L.TenLop";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();

                adapter.Fill(table);

                cboLop.DataSource = table;
                cboLop.DisplayMember = "TenLopHienThi";
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

            if (cboLop.SelectedIndex == -1 || cboLop.SelectedValue == null)
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

        // ================= THÊM SINH VIÊN (TRANSACTION TIẾP NHẬN & XẾP LỚP) =================

        // ================= THÊM SINH VIÊN (TRANSACTION GIỚI HẠN 30 SV) =================

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            DateTime ngaySinh = dtpNgaySinh.Value.Date;
            string gioiTinh = cboGioiTinh.Text;
            string maLop = cboLop.SelectedValue?.ToString() ?? "";

            if (string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng chọn lớp!");
                return;
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // BƯỚC 1: Thêm sinh viên vào CSDL (trong Transaction)
                    string queryInsert = @"
                        INSERT INTO SINHVIEN
                        (MaSV, HoTen, NgaySinh, GioiTinh, MaLop)
                        VALUES
                        (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @MaLop)";

                    using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conn, transaction))
                    {
                        cmdInsert.Parameters.AddWithValue("@MaSV", maSV);
                        cmdInsert.Parameters.AddWithValue("@HoTen", hoTen);
                        cmdInsert.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmdInsert.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmdInsert.Parameters.AddWithValue("@MaLop", maLop);

                        cmdInsert.ExecuteNonQuery();
                    }

                    // BƯỚC 2: Kiểm tra sĩ số lớp đồng thời trong Transaction
                    string queryCount = "SELECT COUNT(*) FROM SINHVIEN WHERE MaLop = @MaLopCheck";
                    int siSoHienTai = 0;
                    using (SqlCommand cmdCheck = new SqlCommand(queryCount, conn, transaction))
                    {
                        cmdCheck.Parameters.AddWithValue("@MaLopCheck", maLop);
                        siSoHienTai = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    }

                    // Kiểm tra vượt quá giới hạn 30 sinh viên
                    if (siSoHienTai > 30)
                    {
                        throw new Exception($"Lớp đã đạt giới hạn tối đa (Sĩ số sau khi xếp: {siSoHienTai}/30 sinh viên)!");
                    }

                    // Thêm độ trễ 10 giây nếu được tick để giữ khóa phục vụ kiểm thử
                    if (chkDoTre.Checked)
                    {
                        using (SqlCommand cmdDelay = new SqlCommand("WAITFOR DELAY '00:00:10'", conn, transaction))
                        {
                            cmdDelay.CommandTimeout = 30;
                            cmdDelay.ExecuteNonQuery();
                        }
                    }

                    // BƯỚC 3: Nếu mọi điều kiện hợp lệ -> COMMIT TRANSACTION
                    transaction.Commit();

                    MessageBox.Show(
                        $"[TRANSACTION COMMIT]\nTiếp nhận sinh viên và xếp lớp thành công!\nSĩ số hiện tại của lớp: {siSoHienTai}/30",
                        "Thông báo Transaction",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadSinhVien();
                    LamMoiForm();
                }
                catch (Exception ex)
                {
                    // Khi có lỗi hoặc vi phạm điều kiện -> ROLLBACK TRANSACTION
                    try
                    {
                        transaction.Rollback();
                    }
                    catch
                    {
                    }

                    MessageBox.Show(
                        $"[TRANSACTION ROLLBACK]\nLý do: {ex.Message}\nThao tác tiếp nhận sinh viên {maSV} đã được hủy bỏ hoàn toàn để bảo đảm tính nhất quán dữ liệu.",
                        "Cảnh báo Transaction Rollback",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    LoadSinhVien();
                }
            }
        }

        // ================= SỬA SINH VIÊN (TRANSACTION CHUYỂN LỚP & KHÓA TÀI NGUYÊN) =================

        private void button2_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            DateTime ngaySinh = dtpNgaySinh.Value.Date;
            string gioiTinh = cboGioiTinh.Text;
            string maLop = cboLop.SelectedValue?.ToString() ?? "";

            if (string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng chọn lớp!");
                return;
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Lấy mã lớp hiện tại của sinh viên trước khi cập nhật
                    string queryLopCu = "SELECT MaLop FROM SINHVIEN WHERE MaSV = @MaSV";
                    string maLopCu = "";
                    using (SqlCommand cmdGetOld = new SqlCommand(queryLopCu, conn, transaction))
                    {
                        cmdGetOld.Parameters.AddWithValue("@MaSV", maSV);
                        object? res = cmdGetOld.ExecuteScalar();
                        if (res == null || res == DBNull.Value)
                        {
                            throw new Exception("Không tìm thấy sinh viên cần sửa!");
                        }
                        maLopCu = res.ToString() ?? "";
                    }

                    bool laChuyenLop = !string.Equals(maLopCu, maLop, StringComparison.OrdinalIgnoreCase);

                    if (laChuyenLop)
                    {
                        // BƯỚC 1: Khóa lớp hiện tại (Resource 1)
                        string sqlLockLopCu = "UPDATE LOP SET TenLop = TenLop WHERE MaLop = @MaLopCu";
                        using (SqlCommand cmdLock1 = new SqlCommand(sqlLockLopCu, conn, transaction))
                        {
                            cmdLock1.Parameters.AddWithValue("@MaLopCu", maLopCu);
                            cmdLock1.ExecuteNonQuery();
                        }

                        // Độ trễ 10 giây ở GIỮA 2 tài nguyên để tạo điều kiện khóa chéo (Deadlock)
                        if (chkDoTre.Checked)
                        {
                            using (SqlCommand cmdDelay = new SqlCommand("WAITFOR DELAY '00:00:10'", conn, transaction))
                            {
                                cmdDelay.CommandTimeout = 30;
                                cmdDelay.ExecuteNonQuery();
                            }
                        }

                        // BƯỚC 2: Đòi khóa lớp chuyển đến (Resource 2)
                        string sqlLockLopMoi = "UPDATE LOP SET TenLop = TenLop WHERE MaLop = @MaLopMoi";
                        using (SqlCommand cmdLock2 = new SqlCommand(sqlLockLopMoi, conn, transaction))
                        {
                            cmdLock2.Parameters.AddWithValue("@MaLopMoi", maLop);
                            cmdLock2.ExecuteNonQuery();
                        }
                    }

                    // BƯỚC 3: Cập nhật thông tin sinh viên
                    string queryUpdate = @"
                        UPDATE SINHVIEN
                        SET
                            HoTen = @HoTen,
                            NgaySinh = @NgaySinh,
                            GioiTinh = @GioiTinh,
                            MaLop = @MaLop
                        WHERE MaSV = @MaSV";

                    using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn, transaction))
                    {
                        cmdUpdate.Parameters.AddWithValue("@MaSV", maSV);
                        cmdUpdate.Parameters.AddWithValue("@HoTen", hoTen);
                        cmdUpdate.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmdUpdate.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmdUpdate.Parameters.AddWithValue("@MaLop", maLop);

                        cmdUpdate.ExecuteNonQuery();
                    }

                    // BƯỚC 4: Kiểm tra sĩ số lớp đích trong Transaction
                    string queryCount = "SELECT COUNT(*) FROM SINHVIEN WHERE MaLop = @MaLopCheck";
                    int siSoHienTai = 0;
                    using (SqlCommand cmdCheck = new SqlCommand(queryCount, conn, transaction))
                    {
                        cmdCheck.Parameters.AddWithValue("@MaLopCheck", maLop);
                        siSoHienTai = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    }

                    if (siSoHienTai > 30)
                    {
                        throw new Exception($"Lớp chuyển đến đã vượt quá giới hạn (Sĩ số: {siSoHienTai}/30 sinh viên)!");
                    }

                    // Nếu không đổi lớp nhưng có tick trễ -> giữ khóa sinh viên để kiểm thử Lock Wait
                    if (!laChuyenLop && chkDoTre.Checked)
                    {
                        using (SqlCommand cmdDelay = new SqlCommand("WAITFOR DELAY '00:00:10'", conn, transaction))
                        {
                            cmdDelay.CommandTimeout = 30;
                            cmdDelay.ExecuteNonQuery();
                        }
                    }

                    // BƯỚC 5: COMMIT TRANSACTION
                    transaction.Commit();

                    MessageBox.Show(
                        $"[TRANSACTION COMMIT]\nCập nhật thông tin và chuyển lớp thành công!\nSĩ số lớp mới: {siSoHienTai}/30",
                        "Thông báo Transaction",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadSinhVien();
                    LamMoiForm();
                }
                catch (Exception ex)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch
                    {
                    }

                    MessageBox.Show(
                        $"[TRANSACTION ROLLBACK]\nLý do: {ex.Message}\nThao tác sửa thông tin / chuyển lớp đã bị hủy bỏ hoàn toàn.",
                        "Cảnh báo Transaction Rollback",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    LoadSinhVien();
                }
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