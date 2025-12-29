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

        private void txtTenKhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
