using Microsoft.Data.SqlClient;
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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();

            LoadThongKe();
        }
        private void LoadThongKe()
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    lblTongSinhVien.Text = LaySoLuong(conn, "SINHVIEN").ToString();
                    lblTongKhoa.Text = LaySoLuong(conn, "KHOA").ToString();
                    lblTongNganh.Text = LaySoLuong(conn, "NGANH").ToString();
                    lblTongLop.Text = LaySoLuong(conn, "LOP").ToString();
                    lblTongHoSo.Text = LaySoLuong(conn, "HOSOSINHVIEN").ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thống kê: " + ex.Message);
            }
        }
        private int LaySoLuong(SqlConnection conn, string tenBang)
        {
            string query = $"SELECT COUNT(*) FROM {tenBang}";

            SqlCommand cmd = new SqlCommand(query, conn);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
