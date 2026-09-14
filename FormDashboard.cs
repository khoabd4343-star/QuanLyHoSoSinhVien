using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace QuanLyHoSoSinhVien
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();

            // Tải các số liệu thống kê
            LoadThongKe();

            // Bấm vào ô cảnh báo để xem danh sách
            pnlHoSoChuaHoanThien.Cursor = Cursors.Hand;
            pnlHoSoChuaHoanThien.Click += pnlHoSoChuaHoanThien_Click;
        }


        // ================= LOAD THỐNG KÊ =================

        private void LoadThongKe()
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    // Tổng sinh viên
                    lblTongSinhVien.Text =
                        LaySoLuong(conn, "SINHVIEN").ToString();

                    // Tổng khoa
                    lblTongKhoa.Text =
                        LaySoLuong(conn, "KHOA").ToString();

                    // Tổng ngành
                    lblTongNganh.Text =
                        LaySoLuong(conn, "NGANH").ToString();

                    // Tổng lớp
                    lblTongLop.Text =
                        LaySoLuong(conn, "LOP").ToString();

                    // Tổng hồ sơ
                    lblTongHoSo.Text =
                        LaySoLuong(conn, "HOSOSINHVIEN").ToString();

                    // Hồ sơ chưa hoàn thiện
                    lblHoSoChuaHoanThien.Text =
                        LaySoHoSoChuaHoanThien(conn).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải thống kê: " + ex.Message
                );
            }
        }


        // ================= ĐẾM SỐ LƯỢNG =================

        private int LaySoLuong(
            SqlConnection conn,
            string tenBang)
        {
            string query =
                $"SELECT COUNT(*) FROM {tenBang}";

            using (SqlCommand cmd =
                   new SqlCommand(query, conn))
            {
                return Convert.ToInt32(
                    cmd.ExecuteScalar()
                );
            }
        }


        // ================= ĐẾM HỒ SƠ CHƯA HOÀN THIỆN =================

        private int LaySoHoSoChuaHoanThien(
            SqlConnection conn)
        {
            string query = @"
                SELECT COUNT(*)
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
                    OR LTRIM(RTRIM(HS.Email)) = ''";

            using (SqlCommand cmd =
                   new SqlCommand(query, conn))
            {
                return Convert.ToInt32(
                    cmd.ExecuteScalar()
                );
            }
        }


        // ================= BẤM Ô CẢNH BÁO =================

        private void pnlHoSoChuaHoanThien_Click(
            object sender,
            EventArgs e)
        {
            FormCanhBaoHoSo formCanhBao =
                new FormCanhBaoHoSo();

            formCanhBao.ShowDialog();
        }
    }
}