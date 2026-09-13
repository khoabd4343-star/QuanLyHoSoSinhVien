using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyHoSoSinhVien
{
    public partial class FormThongTinSinhVien : Form
    {
        private string maSV;

        // Nhận Mã SV từ Form Đăng Nhập
        public FormThongTinSinhVien(string maSV)
        {
            InitializeComponent();

            this.maSV = maSV;

            LoadThongTinSinhVien();
        }

        private void LoadThongTinSinhVien()
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string query = @"
                        SELECT
                            MaSV,
                            HoTen,
                            NgaySinh,
                            GioiTinh,
                            MaLop
                        FROM SINHVIEN
                        WHERE MaSV = @MaSV";

                    SqlDataAdapter adapter =
                        new SqlDataAdapter(query, conn);

                    adapter.SelectCommand.Parameters.AddWithValue(
                        "@MaSV",
                        maSV
                    );

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        DataRow row = table.Rows[0];

                        txtMaSV.Text =
                            row["MaSV"].ToString();

                        txtHoTen.Text =
                            row["HoTen"].ToString();

                        txtNgaySinh.Text =
                            Convert.ToDateTime(
                                row["NgaySinh"]
                            ).ToString("dd/MM/yyyy");

                        txtGioiTinh.Text =
                            row["GioiTinh"].ToString();

                        txtMaLop.Text =
                            row["MaLop"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message
                );
            }
        }

        private void btnXemHoSo_Click(
            object sender,
            EventArgs e)
        {
            btnQuayLai formHoSo =
                new btnQuayLai(maSV);

            formHoSo.ShowDialog();
        }
        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất không?",
                "XÁC NHẬN ĐĂNG XUẤT",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
    }
    }
}