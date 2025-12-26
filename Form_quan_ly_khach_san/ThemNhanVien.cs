using QLKS.BUS;
using QLKS.DAL.Models;
using System;
using System.Windows.Forms;

namespace Form_quan_ly_khach_san
{
    public partial class ThemNhanVien : Form
    {
        private NhanVienBUS nvBus = new NhanVienBUS();

        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            // 🔐 Kiểm tra quyền ADMIN
            if (KtraDangNhap.strquyenhan != "ADMIN")
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này!");
                this.Close();
                return;
            }

            // Cấu hình DataGridView
            dgvThemNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThemNV.MultiSelect = false;
            dgvThemNV.AutoGenerateColumns = true;

            // Load dữ liệu
            LoadData();

            // Mã NV tự động
            txtMaNV.Text = nvBus.TaoMaNVTuDong();
            txtMaNV.ReadOnly = true;

            // Quyền
            comboBox1.Items.Clear();
            comboBox1.Items.Add("ADMIN");
            comboBox1.Items.Add("NHANVIEN");
            comboBox1.SelectedIndex = 1;
        }

        #region HÀM XỬ LÝ

        private void LoadData()
        {
            dgvThemNV.DataSource = null;
            dgvThemNV.DataSource = nvBus.LayTatCaNhanVien();

            if (dgvThemNV.Columns["PhieuThues"] != null)
                dgvThemNV.Columns["PhieuThues"].Visible = false;

            if (dgvThemNV.Columns["MatKhau"] != null)
                dgvThemNV.Columns["MatKhau"].Visible = false;

            dgvThemNV.Columns["MaNV"].HeaderText = "Mã NV";
            dgvThemNV.Columns["HoTen"].HeaderText = "Họ tên";
            dgvThemNV.Columns["TaiKhoan"].HeaderText = "Tên đăng nhập";
            dgvThemNV.Columns["SDT"].HeaderText = "SĐT";
            dgvThemNV.Columns["Quyen"].HeaderText = "Quyền";
        }

        private void ClearForm()
        {
            txtHoTen.Clear();
            txtTenDangNhap.Clear();
            txtSDT.Clear();

            txtMaNV.Text = nvBus.TaoMaNVTuDong();
            txtMaNV.ReadOnly = true;

            comboBox1.SelectedIndex = 1;
            txtHoTen.Focus();
        }

        #endregion

        #region EVENTS

        // ➕ Thêm nhân viên
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtTenDangNhap.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            NhanVien nv = new NhanVien
            {
                MaNV = txtMaNV.Text,
                HoTen = txtHoTen.Text.Trim(),
                TaiKhoan = txtTenDangNhap.Text.Trim(),
                SDT = txtSDT.Text.Trim(),
                Quyen = comboBox1.SelectedItem.ToString()
            };

            if (nvBus.ThemNhanVien(nv))
            {
                MessageBox.Show("Thêm nhân viên thành công!\nMật khẩu mặc định: 123");
                LoadData();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại!");
            }
        }

        // ❌ Xóa trắng form
        private void btnXoaBo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn xóa nhân viên này?",
                "Xác nhận",
                MessageBoxButtons.YesNo
            );

            if (r == DialogResult.Yes)
            {
                if (nvBus.XoaNhanVien(txtMaNV.Text))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();      // reload dgv
                    ClearForm();     // reset form
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên!");
                }
            }
        }

        // 🚪 Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 👉 Click bảng → dữ liệu nhảy lên form
        private void dgvThemNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvThemNV.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtTenDangNhap.Text = row.Cells["TaiKhoan"].Value.ToString();
                comboBox1.Text = row.Cells["Quyen"].Value.ToString();
            }
        }

        #endregion

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvThemNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
