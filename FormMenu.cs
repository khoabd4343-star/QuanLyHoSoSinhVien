using System;
using System.Windows.Forms;

namespace QuanLyHoSoSinhVien
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        // Hàm mở Form vào panel bên phải
        private void MoFormCon(Form formCon)
        {
            panelNoiDung.Controls.Clear();

            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;

            panelNoiDung.Controls.Add(formCon);
            formCon.Show();
        }

        // TRANG CHỦ
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormDashboard());
        }

        // QUẢN LÝ SINH VIÊN
        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormSinhVien());
        }

        // QUẢN LÝ HỒ SƠ
        private void btnHoSo_Click(object sender, EventArgs e)
        {
            MoFormCon(new btnQuayLai());
        }

        // QUẢN LÝ KHOA
        private void btnKhoa_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormKhoa());
        }

        // QUẢN LÝ NGÀNH
        private void btnNganh_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormNganh());
        }

        // QUẢN LÝ LỚP
        private void btnLop_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormLop());
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

        // Khi mở FormMenu -> hiện Dashboard bên phải
        private void FormMenu_Load(object sender, EventArgs e)
        {
           
        }

        // Sự kiện Paint của panel
        private void panelNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}