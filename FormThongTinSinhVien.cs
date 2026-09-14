using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace QuanLyHoSoSinhVien
{
    public partial class FormThongTinSinhVien : Form
    {
        private string maSV;
        private byte[] anhDaiDien;

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
                    SV.MaSV,
                    SV.HoTen,
                    SV.NgaySinh,
                    SV.GioiTinh,
                    SV.MaLop,
                    HS.AnhDaiDien
                FROM SINHVIEN SV
                LEFT JOIN HOSOSINHVIEN HS
                    ON SV.MaSV = HS.MaSV
                WHERE SV.MaSV = @MaSV";

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

                        // ================= THÔNG TIN SINH VIÊN =================

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


                        // ================= HIỂN THỊ ẢNH ĐẠI DIỆN =================

                        if (row["AnhDaiDien"] != DBNull.Value)
                        {
                            byte[] imageBytes =
                                (byte[])row["AnhDaiDien"];

                            anhDaiDien = imageBytes;

                            using (MemoryStream ms =
                                   new MemoryStream(imageBytes))
                            {
                                using (Image image =
                                       Image.FromStream(ms))
                                {
                                    picAnhDaiDien.Image =
                                        new Bitmap(image);
                                }
                            }
                        }
                        else
                        {
                            // Nếu chưa có ảnh
                            picAnhDaiDien.Image = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải thông tin sinh viên: "
                    + ex.Message
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

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter =
                    "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    anhDaiDien = File.ReadAllBytes(
                        openFileDialog.FileName
                    );

                    using (MemoryStream ms =
                           new MemoryStream(anhDaiDien))
                    {
                        using (Image image =
                               Image.FromStream(ms))
                        {
                            picAnhDaiDien.Image =
                                new Bitmap(image);
                        }
                    }
                }
            }
        }

        private void btnLuuAnh_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn ảnh chưa
            if (anhDaiDien == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh trước!");
                return;
            }

            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string query = @"
                UPDATE HOSOSINHVIEN
                SET AnhDaiDien = @AnhDaiDien
                WHERE MaSV = @MaSV";

                    using (SqlCommand cmd =
                           new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(
                            "@AnhDaiDien",
                            SqlDbType.VarBinary
                        ).Value = anhDaiDien;

                        cmd.Parameters.AddWithValue(
                            "@MaSV",
                            maSV
                        );

                        conn.Open();

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show(
                                "Cập nhật ảnh đại diện thành công!"
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy hồ sơ sinh viên!"
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi lưu ảnh: " + ex.Message
                );
            }
        }
    }
}