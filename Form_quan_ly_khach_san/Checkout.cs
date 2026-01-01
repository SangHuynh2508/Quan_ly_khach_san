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
    public partial class Checkout : Form
    {
        private CheckoutBUS bus = new CheckoutBUS();
        public Checkout()
        {
            InitializeComponent();
            LoadComboMaCheckin();
        }


        private void LoadComboMaCheckin()
        {
            comboBox1.DataSource = bus.LayTatCaPhieuThue();
            comboBox1.DisplayMember = "MaPhieu";
            comboBox1.ValueMember = "MaPhieu";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoNgayThue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaCheckin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTienPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTienDichVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongSoTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaCheckin.Text;

            if (string.IsNullOrEmpty(maPhieu))
            {
                MessageBox.Show("Chưa chọn phiếu thuê!");
                return;
            }

            if (bus.ThucHienCheckout(maPhieu))
            {
                MessageBox.Show("Checkout thành công!");
                LoadComboMaCheckin();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Checkout thất bại!");
            }
        }

        private void ClearForm()
        {
            txtMaCheckin.Clear();
            txtSoNgayThue.Clear();
            txtPhong.Clear();
            txtTienPhong.Clear();
            txtTienDichVu.Clear();
            txtTongSoTien.Clear();
        }

          
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            PhieuThue phieu = comboBox1.SelectedItem as PhieuThue;
            if (phieu == null) return;

            string maPhieu = phieu.MaPhieu;
            txtMaCheckin.Text = maPhieu;

            int soNgay = bus.TinhSoNgayThue(maPhieu);
            txtSoNgayThue.Text = soNgay.ToString();

            var (tenPhong, donGia) = bus.LayThongTinPhong(maPhieu);
            txtPhong.Text = tenPhong;
            txtTienPhong.Text = (donGia * soNgay).ToString("N0");

            txtTienDichVu.Text = bus.TinhTienDichVu(maPhieu).ToString("N0");
            txtTongSoTien.Text = bus.TinhTongTien(maPhieu).ToString("N0");
        }
    }
}