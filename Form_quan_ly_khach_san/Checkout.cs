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
            var dsPhieu = bus.LayTatCaPhieuThue();
            comboBox1.DataSource = dsPhieu;
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
            bus.ThucHienCheckout(maPhieu);
            MessageBox.Show("Checkout thành công!");
            LoadComboMaCheckin(); // refresh combobox
        }

          
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            var phieu = comboBox1.SelectedItem as PhieuThue;
            if (phieu == null) return;

            string maPhieu = phieu.MaPhieu;
            txtMaCheckin.Text = maPhieu;

            // Số ngày thuê
            txtSoNgayThue.Text = bus.TinhSoNgayThue(maPhieu).ToString();

            // Phòng + tiền phòng
            var (tenPhong, donGiaPhong) = bus.LayThongTinPhong(maPhieu);
            txtPhong.Text = tenPhong;
            txtTienPhong.Text = (donGiaPhong * bus.TinhSoNgayThue(maPhieu)).ToString();

            // Tiền dịch vụ
            txtTienDichVu.Text = bus.TinhTienDichVu(maPhieu).ToString();

            // Tổng tiền
            txtTongSoTien.Text = bus.TinhTongTien(maPhieu).ToString();
        }
    }
}