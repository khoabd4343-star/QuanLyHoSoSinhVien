using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyHoSoSinhVien
{
    public partial class FormMenu : Form
    {
        private Button? currentActiveButton = null;

        public FormMenu()
        {
            InitializeComponent();
        }

        // Cập nhật trạng thái hiển thị nút được chọn trên Sidebar
        private void SetActiveButton(Button btn)
        {
            if (currentActiveButton != null && currentActiveButton != btnDangXuat)
            {
                currentActiveButton.BackColor = Color.FromArgb(30, 41, 59);
                currentActiveButton.ForeColor = Color.FromArgb(226, 232, 240);
            }

            currentActiveButton = btn;
            if (currentActiveButton != null && currentActiveButton != btnDangXuat)
            {
                currentActiveButton.BackColor = Color.FromArgb(37, 99, 235);
                currentActiveButton.ForeColor = Color.White;
            }
        }

        // Hàm mở Form con vào panel bên phải
        private void MoFormCon(Form formCon, Button? btn = null)
        {
            if (btn != null)
            {
                SetActiveButton(btn);
            }

            panelNoiDung.Controls.Clear();

            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;

            panelNoiDung.Controls.Add(formCon);
            UIThemeHelper.ApplyTheme(formCon);
            formCon.Show();
        }

        // TRANG CHỦ
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormDashboard(), btnTrangChu);
        }

        // QUẢN LÝ SINH VIÊN
        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormSinhVien(), btnSinhVien);
        }

        // QUẢN LÝ HỒ SƠ
        private void btnHoSo_Click(object sender, EventArgs e)
        {
            MoFormCon(new btnQuayLai(), btnHoSo);
        }

        // QUẢN LÝ KHOA
        private void btnKhoa_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormKhoa(), btnKhoa);
        }

        // QUẢN LÝ NGÀNH
        private void btnNganh_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormNganh(), btnNganh);
        }

        // QUẢN LÝ LỚP
        private void btnLop_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormLop(), btnLop);
        }

        // ĐĂNG XUẤT
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất không?",
                "XÁC NHẬN ĐĂNG XUẤT",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Khi mở FormMenu -> tự động hiện Dashboard bên phải và active nút Trang Chủ
        private void FormMenu_Load(object sender, EventArgs e)
        {
            MoFormCon(new FormDashboard(), btnTrangChu);
        }

        // Sự kiện Paint của panel
        private void panelNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}