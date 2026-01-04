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
            dgvThemNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            dgvThemNV.ReadOnly = true;                                        
            dgvThemNV.EditMode = DataGridViewEditMode.EditProgrammatically;  
            dgvThemNV.MultiSelect = false;
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
                btnNhapLai_Click(null, null);
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
            if (dgvThemNV.CurrentRow != null)
            {
                string maNV = dgvThemNV.CurrentRow.Cells["MaNV"].Value.ToString();
                string tenNV = dgvThemNV.CurrentRow.Cells["HoTen"].Value.ToString();

                DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {tenNV} ({maNV}) không?",
                                                 "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    if (nvBus.XoaNhanVien(maNV))
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        LoadData();   
                        LoadListView(); 
                        btnNhapLai_Click(null, null); 
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhân viên này.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa trong danh sách!");
            }
        }
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtTenDangNhap.Clear();
            txtSDT.Clear();
            txtMaNV.Text = nvBus.TaoMaNVTuDong();
            comboBox1.SelectedIndex = 1;
            txtHoTen.Focus();
        }
        private void dgvThemNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvThemNV.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtTenDangNhap.Text = row.Cells["TaiKhoan"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();

                string quyen = row.Cells["Quyen"].Value?.ToString();
                if (!string.IsNullOrEmpty(quyen))
                {
                    comboBox1.SelectedItem = quyen;
                }
            }
        }
        #endregion

        
    }
}
