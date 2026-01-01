using QLKS.BUS;
using QLKS.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            LoadData();
            txtMaNV.Text = nvBus.TaoMaNVTuDong();
            txtMaNV.ReadOnly = true;
            LoadListView();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("ADMIN");
            comboBox1.Items.Add("NHANVIEN");
            comboBox1.SelectedIndex = 1;
        }
        #region hàm cần thiết
        private void LoadData()
        {
            dgvThemNV.DataSource = nvBus.LayTatCaNhanVien();

            if (dgvThemNV.Columns["PhieuThues"] != null)
                dgvThemNV.Columns["PhieuThues"].Visible = false;

            if (dgvThemNV.Columns["MatKhau"] != null)
                dgvThemNV.Columns["MatKhau"].Visible = false;
            dgvThemNV.Columns["MaNV"].HeaderText = "Mã NV";
            dgvThemNV.Columns["HoTen"].HeaderText = "Họ Tên";
        }
        private void LoadListView()
        {
            listView1.Items.Clear();
            var ds = nvBus.LayTatCaNhanVien();
            foreach (var nv in ds)
            {
                ListViewItem item = new ListViewItem(nv.MaNV);
                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(nv.TaiKhoan);
                item.SubItems.Add(nv.Quyen);
                listView1.Items.Add(item);
            }
        }
        private void ClearForm()
        {
            txtTenDangNhap.Clear();
            txtHoTen.Clear();
            txtMaNV.Text = nvBus.TaoMaNVTuDong();
            txtSDT.Clear();
        }
        #endregion
        #region events
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien
            {
                MaNV = txtMaNV.Text,
                HoTen = txtHoTen.Text,
                TaiKhoan = txtTenDangNhap.Text,
                SDT = txtSDT.Text,
                Quyen = comboBox1.SelectedItem.ToString()
            };

            if (nvBus.ThemNhanVien(nv))
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
                LoadListView();
                btnXoaBo_Click(null, null);
            }
            else
            {
                MessageBox.Show("Lỗi: Tài khoản đã tồn tại!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaBo_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtTenDangNhap.Clear();
            txtSDT.Clear();
            txtMaNV.Text = nvBus.TaoMaNVTuDong();
            comboBox1.SelectedIndex = 1;
            txtHoTen.Focus();
        }
        #endregion
    }
}
