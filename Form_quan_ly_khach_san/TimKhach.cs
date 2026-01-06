using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS.BUS;

namespace Form_quan_ly_khach_san
{
    public partial class TimKhach : Form
    {
        private KhachHangBUS khachHangBUS = new KhachHangBUS();
        public TimKhach()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rdbTimTheoTen.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng");
                    return;
                }

                dgvTimKhach.DataSource =
                    khachHangBUS.TimKhachTheoTen(txtTenKhach.Text);
                if (dgvTimKhach.Columns["PhieuThues"] != null)
                    dgvTimKhach.Columns["PhieuThues"].Visible = false;
            }
            else if (rdbTimTheoCMND.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtSoCMND.Text))
                {
                    MessageBox.Show("Vui lòng nhập số CMND");
                    return;
                }

                dgvTimKhach.DataSource =
                    khachHangBUS.TimKhachTheoCMND(txtSoCMND.Text);
                if (dgvTimKhach.Columns["PhieuThues"] != null)
                    dgvTimKhach.Columns["PhieuThues"].Visible = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kiểu tìm kiếm");
            }
        }

        private void dgvTimKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdbTimTheoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTimTheoTen.Checked)
            {
                txtTenKhach.Enabled = true;
                txtSoCMND.Enabled = false;
                txtSoCMND.Clear();
            }
        }

        private void rdbTimTheoCMND_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTimTheoCMND.Checked)
            {
                txtSoCMND.Enabled = true;
                txtTenKhach.Enabled = false;
                txtTenKhach.Clear();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimKhach_Load(object sender, EventArgs e)
        {
            dgvTimKhach.AllowUserToResizeColumns = false;
            dgvTimKhach.AllowUserToResizeRows = false;
            dgvTimKhach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTimKhach.ReadOnly = true;
            dgvTimKhach.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTimKhach.MultiSelect = false;
            dgvTimKhach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
