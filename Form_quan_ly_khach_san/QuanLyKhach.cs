using QLKS.BUS;
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
    public partial class QuanLyKhach : Form
    {
        private KhachHangBUS khBus = new KhachHangBUS();
        public QuanLyKhach()
        {
            InitializeComponent();
        }
        private void QuanLyKhach_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvQuanLyKhach.AllowUserToResizeColumns = false;
            dgvQuanLyKhach.AllowUserToResizeRows = false;
            dgvQuanLyKhach.ReadOnly = true;
            dgvQuanLyKhach.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvQuanLyKhach.MultiSelect = false;
        }
        private void LoadData()
        {
            dgvQuanLyKhach.DataSource = khBus.LayTatCaKhachHang();
            if (dgvQuanLyKhach.Columns["PhieuThues"] != null)
                dgvQuanLyKhach.Columns["PhieuThues"].Visible = false;
            if (dgvQuanLyKhach.Columns["HoaDons"] != null)
                dgvQuanLyKhach.Columns["HoaDons"].Visible = false;

            dgvQuanLyKhach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            Checkin frmCheckin = new Checkin();
            if (frmCheckin.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            ThayDoiTTKhach thayDoiTTKhach = new ThayDoiTTKhach();
            thayDoiTTKhach.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKhach timKhach = new TimKhach();
            timKhach.ShowDialog();
        }

        private void btnXoaThongTin_Click(object sender, EventArgs e)
        {
            XoaKhach xoaKhach = new XoaKhach();
            xoaKhach.ShowDialog();
        }
    }
}
