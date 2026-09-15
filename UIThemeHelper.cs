using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyHoSoSinhVien
{
    /// <summary>
    /// Tiện ích chuẩn hóa giao diện cho toàn bộ hệ thống (DataGridView, Nút bấm, Bảng màu)
    /// </summary>
    public static class UIThemeHelper
    {
        // Tone màu chuẩn
        public static readonly Color ColorPrimary = Color.FromArgb(37, 99, 235);     // Xanh dương chính
        public static readonly Color ColorSuccess = Color.FromArgb(5, 150, 105);    // Xanh lá (Thêm)
        public static readonly Color ColorWarning = Color.FromArgb(217, 119, 6);    // Cam vàng (Sửa)
        public static readonly Color ColorDanger = Color.FromArgb(220, 38, 38);     // Đỏ (Xóa / Thoát)
        public static readonly Color ColorInfo = Color.FromArgb(79, 70, 229);       // Xanh tím (Tìm kiếm)
        public static readonly Color ColorSecondary = Color.FromArgb(100, 116, 139);// Xám chì (Làm mới)
        public static readonly Color ColorBackground = Color.FromArgb(248, 250, 252);
        public static readonly Color ColorHeader = Color.FromArgb(30, 41, 59);

        /// <summary>
        /// Định dạng toàn bộ DataGridView theo phong cách hiện đại
        /// </summary>
        public static void FormatDataGridView(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.FromArgb(241, 245, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Cấu hình tiêu đề cột (Header)
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorHeader;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 6, 6, 6);
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = 38;

            // Cấu hình dòng dữ liệu (Rows)
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.Padding = new Padding(4, 2, 4, 2);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            // Dòng xen kẽ (Zebra striping)
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            // Tùy chọn khác
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowTemplate.Height = 32;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Định dạng nút bấm chuẩn phẳng hiện đại
        /// </summary>
        public static void FormatButton(Button btn, Color bg, Color? fg = null)
        {
            if (btn == null) return;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = bg;
            btn.ForeColor = fg ?? Color.White;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Áp dụng định dạng tự động cho một form bất kỳ
        /// </summary>
        public static void ApplyTheme(Form form)
        {
            if (form == null) return;

            form.BackColor = ColorBackground;
            form.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

            ApplyToControls(form.Controls);
        }

        private static void ApplyToControls(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is DataGridView dgv)
                {
                    FormatDataGridView(dgv);
                }
                else if (c is Button btn)
                {
                    string text = btn.Text.ToUpper();
                    if (text.Contains("THÊM"))
                    {
                        FormatButton(btn, ColorSuccess);
                    }
                    else if (text.Contains("SỬA") || text.Contains("CẬP NHẬT"))
                    {
                        FormatButton(btn, ColorWarning);
                    }
                    else if (text.Contains("XÓA"))
                    {
                        FormatButton(btn, ColorDanger);
                    }
                    else if (text.Contains("TÌM KIẾM") || text.Contains("TÌM"))
                    {
                        FormatButton(btn, ColorInfo);
                    }
                    else if (text.Contains("LÀM MỚI") || text.Contains("TẢI LẠI"))
                    {
                        FormatButton(btn, ColorSecondary);
                    }
                    else if (text.Contains("XUẤT") || text.Contains("EXCEL"))
                    {
                        FormatButton(btn, ColorSuccess);
                    }
                }
                else if (c.HasChildren)
                {
                    ApplyToControls(c.Controls);
                }
            }
        }
    }
}
