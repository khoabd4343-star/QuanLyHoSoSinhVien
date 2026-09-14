using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHoSoSinhVien
{
    public partial class FormCanhBaoHoSo : Form
    {
        public FormCanhBaoHoSo()
        {
            InitializeComponent();

            LoadDanhSachCanhBao();
        }

        private void LoadDanhSachCanhBao()
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string query = @"
                        SELECT
                            SV.MaSV,
                            SV.HoTen,

                            CASE
                                WHEN HS.MaSV IS NULL
                                    THEN N'Chưa có hồ sơ'

                                WHEN HS.CCCD IS NULL
                                    OR LTRIM(RTRIM(HS.CCCD)) = ''
                                    THEN N'Thiếu CCCD'

                                WHEN HS.QueQuan IS NULL
                                    OR LTRIM(RTRIM(HS.QueQuan)) = ''
                                    THEN N'Thiếu quê quán'

                                WHEN HS.DiaChi IS NULL
                                    OR LTRIM(RTRIM(HS.DiaChi)) = ''
                                    THEN N'Thiếu địa chỉ'

                                WHEN HS.SDT IS NULL
                                    OR LTRIM(RTRIM(HS.SDT)) = ''
                                    THEN N'Thiếu số điện thoại'

                                WHEN HS.Email IS NULL
                                    OR LTRIM(RTRIM(HS.Email)) = ''
                                    THEN N'Thiếu Email'

                                ELSE N'Hoàn chỉnh'
                            END AS TrangThaiHoSo

                        FROM SINHVIEN SV

                        LEFT JOIN HOSOSINHVIEN HS
                            ON SV.MaSV = HS.MaSV

                        WHERE
                            HS.MaSV IS NULL

                            OR HS.CCCD IS NULL
                            OR LTRIM(RTRIM(HS.CCCD)) = ''

                            OR HS.QueQuan IS NULL
                            OR LTRIM(RTRIM(HS.QueQuan)) = ''

                            OR HS.DiaChi IS NULL
                            OR LTRIM(RTRIM(HS.DiaChi)) = ''

                            OR HS.SDT IS NULL
                            OR LTRIM(RTRIM(HS.SDT)) = ''

                            OR HS.Email IS NULL
                            OR LTRIM(RTRIM(HS.Email)) = ''

                        ORDER BY SV.MaSV";

                    SqlDataAdapter adapter =
                        new SqlDataAdapter(query, conn);

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvCanhBao.DataSource = table;

                    dgvCanhBao.Columns["MaSV"].HeaderText =
                        "Mã sinh viên";

                    dgvCanhBao.Columns["HoTen"].HeaderText =
                        "Họ tên";

                    dgvCanhBao.Columns["TrangThaiHoSo"].HeaderText =
                        "Trạng thái hồ sơ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách cảnh báo: " + ex.Message
                );
            }
        }
    }
}