using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHoSoSinhVien
{
    public partial class FormKhoa : Form
    {
        public FormKhoa()
        {
            InitializeComponent();

            LoadDanhSachKhoa();
        }

        private void LoadDanhSachKhoa()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                string query = "SELECT * FROM KHOA";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dgvKhoa.DataSource = dt;
            }
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhoa.Rows[e.RowIndex];

                txtMaKhoa.Text = row.Cells["MaKhoa"].Value.ToString();
                txtTenKhoa.Text = row.Cells["TenKhoa"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "" ||
    txtTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                string query = @"INSERT INTO KHOA (MaKhoa, TenKhoa)
                     VALUES (@MaKhoa, @TenKhoa)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text.Trim());
                cmd.Parameters.AddWithValue("@TenKhoa", txtTenKhoa.Text.Trim());

                conn.Open();

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Thêm khoa thành công!");

                    LoadDanhSachKhoa();

                    txtMaKhoa.Clear();
                    txtTenKhoa.Clear();

                    txtMaKhoa.Focus();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "" ||
    txtTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn và nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                string query = @"UPDATE KHOA
                     SET TenKhoa = @TenKhoa
                     WHERE MaKhoa = @MaKhoa";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text.Trim());
                cmd.Parameters.AddWithValue("@TenKhoa", txtTenKhoa.Text.Trim());

                conn.Open();

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Sửa khoa thành công!");

                    LoadDanhSachKhoa();

                    txtMaKhoa.Clear();
                    txtTenKhoa.Clear();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khoa cần sửa!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn khoa cần xóa!");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa khoa này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string query = "DELETE FROM KHOA WHERE MaKhoa = @MaKhoa";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text.Trim());

                    conn.Open();

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa khoa thành công!");

                        LoadDanhSachKhoa();

                        txtMaKhoa.Clear();
                        txtTenKhoa.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khoa cần xóa!");
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "Không thể xóa khoa này vì vẫn còn ngành thuộc khoa!",
                    "Không thể xóa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtTimKiem.Clear();

            LoadDanhSachKhoa();

            txtMaKhoa.Focus();
        }

        private void lblTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            using (SqlConnection conn = Database.GetConnection())
            {
                string query = @"SELECT * FROM KHOA
                     WHERE MaKhoa LIKE @Keyword
                        OR TenKhoa LIKE @Keyword";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dgvKhoa.DataSource = dt;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
