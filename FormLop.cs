using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyHoSoSinhVien
{
    public partial class FormLop : Form
    {
        public FormLop()
        {
            InitializeComponent();

            LoadNganh();
            LoadDanhSachLop();
        }

        // Load danh sách ngành vào ComboBox
        private void LoadNganh()
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string query = "SELECT MaNganh, TenNganh FROM NGANH";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    cboNganh.DataSource = dt;
                    cboNganh.DisplayMember = "TenNganh";
                    cboNganh.ValueMember = "MaNganh";

                    cboNganh.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load ngành: " + ex.Message);
            }
        }

        // Hiển thị danh sách lớp
       
        private void LoadDanhSachLop()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                string query = @"
            SELECT 
                LOP.MaLop,
                LOP.TenLop,
                LOP.KhoaHoc,
                LOP.MaNganh,
                NGANH.TenNganh
            FROM LOP
            INNER JOIN NGANH
                ON LOP.MaNganh = NGANH.MaNganh";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dgvLop.DataSource = dt;
            }
        }
        // Thêm lớp
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim() == "" ||
                txtTenLop.Text.Trim() == "" ||
                cboNganh.SelectedIndex == -1 ||
                txtKhoaHoc.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                string query = @"INSERT INTO LOP
                                (MaLop, TenLop, KhoaHoc, MaNganh)
                                VALUES
                                (@MaLop, @TenLop, @KhoaHoc, @MaNganh)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text.Trim());
                cmd.Parameters.AddWithValue("@KhoaHoc", txtKhoaHoc.Text.Trim());
                cmd.Parameters.AddWithValue("@MaNganh", cboNganh.SelectedValue.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm lớp thành công!");

                LoadDanhSachLop();

                txtMaLop.Clear();
                txtTenLop.Clear();
                txtKhoaHoc.Clear();
                cboNganh.SelectedIndex = -1;
            }
        }

        // Khi click vào một dòng trong bảng
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLop.Rows[e.RowIndex];

                txtMaLop.Text = row.Cells["MaLop"].Value?.ToString();
                txtTenLop.Text = row.Cells["TenLop"].Value?.ToString();
                txtKhoaHoc.Text = row.Cells["KhoaHoc"].Value?.ToString();

                cboNganh.SelectedValue =
                    row.Cells["MaNganh"].Value?.ToString();
            }
        }

        // Sửa lớp
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim() == "" ||
                txtTenLop.Text.Trim() == "" ||
                cboNganh.SelectedIndex == -1 ||
                txtKhoaHoc.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn và nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                string query = @"UPDATE LOP
                                 SET TenLop = @TenLop,
                                     KhoaHoc = @KhoaHoc,
                                     MaNganh = @MaNganh
                                 WHERE MaLop = @MaLop";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text.Trim());
                cmd.Parameters.AddWithValue("@KhoaHoc", txtKhoaHoc.Text.Trim());
                cmd.Parameters.AddWithValue("@MaNganh", cboNganh.SelectedValue.ToString());

                conn.Open();

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Sửa lớp thành công!");

                    LoadDanhSachLop();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lớp cần sửa!");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormLop_Load(object sender, EventArgs e)
        {

        }

        // Xóa lớp
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn lớp cần xóa!");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa lớp này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = Database.GetConnection())
                    {
                        string query = "DELETE FROM LOP WHERE MaLop = @MaLop";

                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue(
                            "@MaLop",
                            txtMaLop.Text.Trim());

                        conn.Open();

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Xóa lớp thành công!");

                            LoadDanhSachLop();

                            txtMaLop.Clear();
                            txtTenLop.Clear();
                            txtKhoaHoc.Clear();
                            cboNganh.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy lớp cần xóa!");
                        }
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show(
                        "Không thể xóa lớp này vì vẫn còn sinh viên thuộc lớp!",
                        "Không thể xóa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        // Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtKhoaHoc.Clear();

            cboNganh.SelectedIndex = -1;

            LoadDanhSachLop();

            txtMaLop.Focus();
        }

        // Tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            using (SqlConnection conn = Database.GetConnection())
            {
                string query = @"
            SELECT 
                LOP.MaLop,
                LOP.TenLop,
                LOP.KhoaHoc,
                LOP.MaNganh,
                NGANH.TenNganh
            FROM LOP
            INNER JOIN NGANH
                ON LOP.MaNganh = NGANH.MaNganh
            WHERE LOP.MaLop LIKE @Keyword
               OR LOP.TenLop LIKE @Keyword
               OR LOP.MaNganh LIKE @Keyword
               OR NGANH.TenNganh LIKE @Keyword
               OR LOP.KhoaHoc LIKE @Keyword";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@Keyword",
                    "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dgvLop.DataSource = dt;
            }
        }

        // Quay lại
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}