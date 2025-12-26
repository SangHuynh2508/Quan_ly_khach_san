using QLKS.BUS;
using QLKS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Form_quan_ly_khach_san
{
    public partial class TimNhanVien : Form
    {
        private NhanVienBUS nvBus = new NhanVienBUS();

        public TimNhanVien()
        {
            InitializeComponent();
        }

        private void TimNhanVien_Load(object sender, EventArgs e)
        {
            dgvTimNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTimNhanVien.MultiSelect = false;
            dgvTimNhanVien.AutoGenerateColumns = true;

            // mặc định tìm theo tên
            rdbTimTheoTenNV.Checked = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<NhanVien> ds = nvBus.LayTatCaNhanVien();
            if (rdbTimTheoTenNV.Checked)
            {
                string ten = txtTenNV.Text.Trim().ToLower();
                ds = ds.Where(x => x.HoTen.ToLower().Contains(ten)).ToList();
            }
            else if (rdbTimTheoSDT.Checked)
            {
                string sdt = txtSDTNV.Text.Trim();
                ds = ds.Where(x => x.SDT.Contains(sdt)).ToList();
            }

            dgvTimNhanVien.DataSource = null;
            dgvTimNhanVien.DataSource = ds;

            // Ẩn những cột không cần thiết
            if (dgvTimNhanVien.Columns["MatKhau"] != null)
                dgvTimNhanVien.Columns["MatKhau"].Visible = false;

            if (dgvTimNhanVien.Columns["PhieuThues"] != null)
                dgvTimNhanVien.Columns["PhieuThues"].Visible = false;

            // Đặt header
            dgvTimNhanVien.Columns["MaNV"].HeaderText = "Mã NV";
            dgvTimNhanVien.Columns["HoTen"].HeaderText = "Họ tên";
            dgvTimNhanVien.Columns["TaiKhoan"].HeaderText = "Tên đăng nhập";
            dgvTimNhanVien.Columns["SDT"].HeaderText = "SĐT";
            dgvTimNhanVien.Columns["Quyen"].HeaderText = "Quyền";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbTimTheoTenNV_CheckedChanged(object sender, EventArgs e)
        {
            txtTenNV.Enabled = true;
            txtSDTNV.Enabled = false;
            txtSDTNV.Clear();
        }

        private void rdbTimTheoSDT_CheckedChanged(object sender, EventArgs e)
        {
            txtSDTNV.Enabled = true;
            txtTenNV.Enabled = false;
            txtTenNV.Clear();
        }

        private void dgvTimNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // có thể thêm xử lý click vào dòng để hiển thị chi tiết
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            // có thể thực hiện tìm kiếm realtime nếu muốn
        }
    }
}
