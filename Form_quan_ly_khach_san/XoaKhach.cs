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
    public partial class XoaKhach : Form
    {

        private KhachHangBUS khachHangBUS = new KhachHangBUS();
        public XoaKhach()
        {
            InitializeComponent();
            this.Load += XoaKhach_Load;
        }

        private void dgvXoaKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaKhach.Text = dgvXoaKhach
                    .Rows[e.RowIndex]
                    .Cells["MaKH"]
                    .Value.ToString();
            }
        }

        private void txtMaKhach_TextChanged(object sender, EventArgs e)
        {
            string maKH = txtMaKhach.Text.Trim();

            if (string.IsNullOrEmpty(maKH))
            {
                LoadDanhSachKhach();
            }
            else
            {
                dgvXoaKhach.DataSource = khachHangBUS
                    .LayTatCaKhachHang()
                    .Where(k => k.MaKH.Contains(maKH))
                    .ToList();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKhach.Text.Trim();

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng nhập mã khách");
                return;
            }

            using (var db = new QLKSContext())
            {
                bool daThue = db.PhieuThues.Any(p => p.MaKH == maKH);

                if (daThue)
                {
                    MessageBox.Show(
                        "Không thể xóa khách đã từng thuê phòng",
                        "Cảnh báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
            }

            KhachHangBUS bus = new KhachHangBUS();
            bool kq = bus.XoaKhachHang(maKH);

            MessageBox.Show(kq ? "Xóa thành công" : "Không tìm thấy khách");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XoaKhach_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhach();
            dgvXoaKhach.AllowUserToResizeColumns = false;
            dgvXoaKhach.AllowUserToResizeRows = false;
            dgvXoaKhach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvXoaKhach.ReadOnly = true;
            dgvXoaKhach.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvXoaKhach.MultiSelect = false;
        }

        private void LoadDanhSachKhach()
        {
            dgvXoaKhach.DataSource = khachHangBUS.LayTatCaKhachHang();
            dgvXoaKhach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
