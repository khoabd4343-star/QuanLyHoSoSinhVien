using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyHoSoSinhVien
{
    public partial class btnQuayLai : Form
    {
        private bool laSinhVien = false;
        public btnQuayLai()
        {
            InitializeComponent();
            LoadHoSo();
        }
        public btnQuayLai(string maSV, bool admin)
        {
            InitializeComponent();

            LoadHoSoTheoMaSV(maSV);
        }

        public btnQuayLai(string maSV)
        {
            InitializeComponent();
            laSinhVien = true;

            txtMaSV.Text = maSV;

            LoadHoSoTheoMaSV(maSV);
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnTimKiem.Visible = false;

            txtMaHoSo.ReadOnly = true;
            txtMaSV.ReadOnly = true;
            txtCCCD.ReadOnly = true;
            txtQueQuan.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtEmail.ReadOnly = true;
        }
        private void LoadHoSoTheoMaSV(string maSV)
        {
            try
            {
                // Luôn hiển thị mã sinh viên đang được chọn
                txtMaSV.Text = maSV;

                using (SqlConnection conn = Database.GetConnection())
                {
                    string query = @"
                SELECT *
                FROM HOSOSINHVIEN
                WHERE MaSV = @MaSV";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    adapter.SelectCommand.Parameters.AddWithValue(
                        "@MaSV",
                        maSV
                    );

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvHoSo.DataSource = table;

                    if (table.Rows.Count > 0)
                    {
                        DataRow row = table.Rows[0];

                        txtMaHoSo.Text = row["MaHoSo"].ToString();
                        txtMaSV.Text = row["MaSV"].ToString();
                        txtCCCD.Text = row["CCCD"].ToString();
                        txtQueQuan.Text = row["QueQuan"].ToString();
                        txtDiaChi.Text = row["DiaChi"].ToString();
                        txtSDT.Text = row["SDT"].ToString();
                        txtEmail.Text = row["Email"].ToString();
                    }
                    else
                    {
                        // Chưa có hồ sơ thì xóa thông tin cũ
                        txtMaHoSo.Clear();
                        txtCCCD.Clear();
                        txtQueQuan.Clear();
                        txtDiaChi.Clear();
                        txtSDT.Clear();
                        txtEmail.Clear();

                        // Giữ lại MaSV
                        txtMaSV.Text = maSV;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void LoadHoSo()
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string query = @"
                SELECT
                    HS.MaHoSo,
                    HS.MaSV,
                    SV.HoTen,
                    L.TenLop,
                    N.TenNganh,
                    K.TenKhoa,
                    HS.CCCD,
                    HS.QueQuan,
                    HS.DiaChi,
                    HS.SDT,
                    HS.Email
                FROM HOSOSINHVIEN HS
                INNER JOIN SINHVIEN SV
                    ON HS.MaSV = SV.MaSV
                INNER JOIN LOP L
                    ON SV.MaLop = L.MaLop
                INNER JOIN NGANH N
                    ON L.MaNganh = N.MaNganh
                INNER JOIN KHOA K
                    ON N.MaKhoa = K.MaKhoa";

                    SqlDataAdapter adapter =
                        new SqlDataAdapter(query, conn);

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvHoSo.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormHoSo_Load(object sender, EventArgs e)
        {
        }

        private void dgvHoSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoSo.Rows[e.RowIndex];

                txtMaHoSo.Text = row.Cells["MaHoSo"].Value?.ToString();
                txtMaSV.Text = row.Cells["MaSV"].Value?.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value?.ToString();
                txtQueQuan.Text = row.Cells["QueQuan"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string query = @"INSERT INTO HOSOSINHVIEN
                         (MaHoSo, MaSV, CCCD, QueQuan, DiaChi, SDT, Email)
                         VALUES
                         (@MaHoSo, @MaSV, @CCCD, @QueQuan, @DiaChi, @SDT, @Email)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MaHoSo", txtMaHoSo.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text.Trim());
                    cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text.Trim());
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm hồ sơ thành công!");

                    LoadHoSo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string query = @"UPDATE HOSOSINHVIEN
                         SET CCCD = @CCCD,
                             QueQuan = @QueQuan,
                             DiaChi = @DiaChi,
                             SDT = @SDT,
                             Email = @Email
                         WHERE MaHoSo = @MaHoSo";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MaHoSo", txtMaHoSo.Text.Trim());
                    cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text.Trim());
                    cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text.Trim());
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sửa hồ sơ thành công!");
                    LoadHoSoTheoMaSV(txtMaSV.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string query = "DELETE FROM HOSOSINHVIEN WHERE MaHoSo = @MaHoSo";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MaHoSo", txtMaHoSo.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa hồ sơ thành công!");
                    LoadHoSo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string maHoSo = txtMaHoSo.Text.Trim();
                    string maSV = txtMaSV.Text.Trim();
                    string cccd = txtCCCD.Text.Trim();
                    string queQuan = txtQueQuan.Text.Trim();
                    string diaChi = txtDiaChi.Text.Trim();
                    string sdt = txtSDT.Text.Trim();
                    string email = txtEmail.Text.Trim();

                    string query = @"
                SELECT * FROM HOSOSINHVIEN
                WHERE 1 = 1";

                    if (!string.IsNullOrWhiteSpace(maHoSo))
                    {
                        query += " AND MaHoSo LIKE '%' + @MaHoSo + '%'";
                    }

                    if (!string.IsNullOrWhiteSpace(maSV))
                    {
                        query += " AND MaSV LIKE '%' + @MaSV + '%'";
                    }

                    if (!string.IsNullOrWhiteSpace(cccd))
                    {
                        query += " AND CCCD LIKE '%' + @CCCD + '%'";
                    }

                    if (!string.IsNullOrWhiteSpace(queQuan))
                    {
                        query += " AND QueQuan LIKE '%' + @QueQuan + '%'";
                    }

                    if (!string.IsNullOrWhiteSpace(diaChi))
                    {
                        query += " AND DiaChi LIKE '%' + @DiaChi + '%'";
                    }

                    if (!string.IsNullOrWhiteSpace(sdt))
                    {
                        query += " AND SDT LIKE '%' + @SDT + '%'";
                    }

                    if (!string.IsNullOrWhiteSpace(email))
                    {
                        query += " AND Email LIKE '%' + @Email + '%'";
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    if (!string.IsNullOrWhiteSpace(maHoSo))
                        adapter.SelectCommand.Parameters.AddWithValue("@MaHoSo", maHoSo);

                    if (!string.IsNullOrWhiteSpace(maSV))
                        adapter.SelectCommand.Parameters.AddWithValue("@MaSV", maSV);

                    if (!string.IsNullOrWhiteSpace(cccd))
                        adapter.SelectCommand.Parameters.AddWithValue("@CCCD", cccd);

                    if (!string.IsNullOrWhiteSpace(queQuan))
                        adapter.SelectCommand.Parameters.AddWithValue("@QueQuan", queQuan);

                    if (!string.IsNullOrWhiteSpace(diaChi))
                        adapter.SelectCommand.Parameters.AddWithValue("@DiaChi", diaChi);

                    if (!string.IsNullOrWhiteSpace(sdt))
                        adapter.SelectCommand.Parameters.AddWithValue("@SDT", sdt);

                    if (!string.IsNullOrWhiteSpace(email))
                        adapter.SelectCommand.Parameters.AddWithValue("@Email", email);

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvHoSo.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHoSo.Clear();
            txtMaSV.Clear();
            txtCCCD.Clear();
            txtQueQuan.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();

            dgvHoSo.ClearSelection();

            LoadHoSo();

            txtMaHoSo.Focus();
        }
    }
}
