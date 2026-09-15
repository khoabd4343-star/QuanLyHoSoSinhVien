using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHoSoSinhVien
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!");
                return;
            }

            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    // ==============================
                    // 1. KIỂM TRA ADMIN
                    // ==============================

                    string queryAdmin = @"
                SELECT COUNT(*)
                FROM TAIKHOAN
                WHERE TenDangNhap = @TaiKhoan
                AND MatKhau = @MatKhau
                AND VaiTro = 'ADMIN'";

                    using (SqlCommand cmdAdmin =
                           new SqlCommand(queryAdmin, conn))
                    {
                        cmdAdmin.Parameters.AddWithValue(
                            "@TaiKhoan",
                            txtTaiKhoan.Text.Trim()
                        );

                        cmdAdmin.Parameters.AddWithValue(
                            "@MatKhau",
                            txtMatKhau.Text.Trim()
                        );

                        int resultAdmin =
                            Convert.ToInt32(cmdAdmin.ExecuteScalar());

                        if (resultAdmin > 0)
                        {
                            MessageBox.Show(
                                "Đăng nhập Admin thành công!"
                            );

                            FormMenu formMenu = new FormMenu();

                            this.Hide();

                            formMenu.ShowDialog();

                            this.Show();

                            return;
                        }
                    }


                    // ==============================
                    // 2. KIỂM TRA SINH VIÊN
                    // ==============================

                    string querySinhVien = @"
                SELECT sv.MaSV
                FROM SINHVIEN sv
                INNER JOIN HOSOSINHVIEN hs
                    ON sv.MaSV = hs.MaSV
                WHERE hs.CCCD = @CCCD
                AND FORMAT(sv.NgaySinh, 'ddMMyyyy') = @MatKhau";

                    using (SqlCommand cmdSinhVien =
                           new SqlCommand(querySinhVien, conn))
                    {
                        cmdSinhVien.Parameters.AddWithValue(
                            "@CCCD",
                            txtTaiKhoan.Text.Trim()
                        );

                        cmdSinhVien.Parameters.AddWithValue(
                            "@MatKhau",
                            txtMatKhau.Text.Trim()
                        );

                        object result = cmdSinhVien.ExecuteScalar();

                        if (result != null)
                        {
                            string maSV = result.ToString();

                            MessageBox.Show("Đăng nhập sinh viên thành công!");

                            FormThongTinSinhVien formSinhVien =
                                new FormThongTinSinhVien(maSV);

                            this.Hide();

                            formSinhVien.ShowDialog();

                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Tài khoản hoặc mật khẩu không đúng!"
                            );

                            txtMatKhau.Clear();
                            txtMatKhau.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
