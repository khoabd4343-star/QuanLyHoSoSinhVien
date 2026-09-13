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
    public partial class FormNganh : Form
    {
        public FormNganh()
        {
            InitializeComponent();

            LoadDanhSachNganh();
            LoadKhoa();
        }
        private void LoadDanhSachNganh()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                string query = "SELECT * FROM NGANH";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dgvNganh.DataSource = dt;
            }
        }

        private void LoadKhoa()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                string query = "SELECT MaKhoa, TenKhoa FROM KHOA";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                cboKhoa.DataSource = dt;
                cboKhoa.DisplayMember = "TenKhoa";
                cboKhoa.ValueMember = "MaKhoa";
                cboKhoa.SelectedIndex = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMaNganh.Text.Trim() == "" ||
    txtTenNganh.Text.Trim() == "" ||
    cboKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                string query = @"INSERT INTO NGANH (MaNganh, TenNganh, MaKhoa)
                     VALUES (@MaNganh, @TenNganh, @MaKhoa)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaNganh", txtMaNganh.Text.Trim());
                cmd.Parameters.AddWithValue("@TenNganh", txtTenNganh.Text.Trim());
                cmd.Parameters.AddWithValue("@MaKhoa", cboKhoa.SelectedValue.ToString());

                conn.Open();

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Thêm ngành thành công!");

                    LoadDanhSachNganh();

                    txtMaNganh.Clear();
                    txtTenNganh.Clear();
                    cboKhoa.SelectedIndex = -1;

                    txtMaNganh.Focus();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNganh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn ngành cần xóa!");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa ngành này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = Database.GetConnection())
                    {
                        string query = "DELETE FROM NGANH WHERE MaNganh = @MaNganh";

                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue(
                            "@MaNganh",
                            txtMaNganh.Text.Trim());

                        conn.Open();

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Xóa ngành thành công!");

                            LoadDanhSachNganh();

                            txtMaNganh.Clear();
                            txtTenNganh.Clear();
                            cboKhoa.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy ngành cần xóa!");
                        }
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show(
                        "Không thể xóa ngành này vì vẫn còn lớp thuộc ngành!",
                        "Không thể xóa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void txtMaNganh_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNganh.Rows[e.RowIndex];

                txtMaNganh.Text = row.Cells["MaNganh"].Value.ToString();
                txtTenNganh.Text = row.Cells["TenNganh"].Value.ToString();

                cboKhoa.SelectedValue = row.Cells["MaKhoa"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (txtMaNganh.Text.Trim() == "" ||
                txtTenNganh.Text.Trim() == "" ||
                cboKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn ngành cần sửa và nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                string query = @"UPDATE NGANH
                         SET TenNganh = @TenNganh,
                             MaKhoa = @MaKhoa
                         WHERE MaNganh = @MaNganh";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaNganh", txtMaNganh.Text.Trim());
                cmd.Parameters.AddWithValue("@TenNganh", txtTenNganh.Text.Trim());
                cmd.Parameters.AddWithValue("@MaKhoa", cboKhoa.SelectedValue.ToString());

                conn.Open();

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Sửa ngành thành công!");

                    LoadDanhSachNganh();

                    txtMaNganh.Clear();
                    txtTenNganh.Clear();
                    cboKhoa.SelectedIndex = -1;

                    txtMaNganh.Focus();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ngành cần sửa!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtMaNganh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn ngành cần xóa!");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa ngành này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = Database.GetConnection())
                    {
                        string query = "DELETE FROM NGANH WHERE MaNganh = @MaNganh";

                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue(
                            "@MaNganh",
                            txtMaNganh.Text.Trim());

                        conn.Open();

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Xóa ngành thành công!");

                            LoadDanhSachNganh();

                            txtMaNganh.Clear();
                            txtTenNganh.Clear();
                            cboKhoa.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy ngành cần xóa!");
                        }
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show(
                        "Không thể xóa ngành này vì vẫn còn lớp thuộc ngành!",
                        "Không thể xóa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNganh.Clear();
            txtTenNganh.Clear();

            cboKhoa.SelectedIndex = -1;

            LoadDanhSachNganh();

            txtMaNganh.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            using (SqlConnection conn = Database.GetConnection())
            {
                string query = @"SELECT * FROM NGANH
                     WHERE MaNganh LIKE @Keyword
                        OR TenNganh LIKE @Keyword";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dgvNganh.DataSource = dt;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    