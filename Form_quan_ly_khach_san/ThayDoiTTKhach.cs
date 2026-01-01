using QLKS.BUS;
using QLKS.DAL.Models;   // namespace chứa QLKSContext, KhachHang
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
    public partial class ThayDoiTTKhach : Form
    {
        private KhachHangBUS khBUS = new KhachHangBUS();
        public ThayDoiTTKhach()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhachMoi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách cần sửa");
                return;
            }

            KhachHang kh = new KhachHang
            {
                MaKH = txtMaKhachMoi.Text.Trim(),
                HoTen = txtTenKhachMoi.Text.Trim(),
                GioiTinh = txtGioiTinhMoi.Text.Trim(),
                CMND = txtCMNDMoi.Text.Trim(),
                SDT = txtSDTMoi.Text.Trim(),
                DiaChi = txtDiaChiMoi.Text.Trim(),
                // NgayDat = DateTime.Parse(txtNgayDatMoi.Text) // nếu cần cập nhật ngày đặt
            };

            if (khBUS.SuaKhachHang(kh))
                MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
            else
                MessageBox.Show("Cập nhật thất bại. Vui lòng kiểm tra lại mã khách.");
        }

        private void txtMaKhachCu_TextChanged(object sender, EventArgs e)
        {
            string maKH = txtMaKhachCu.Text.Trim();
            if (maKH == "") return;

            var kh = khBUS.TimKhachTheoMa(maKH);
            if (kh == null) return;

            // Hiển thị thông tin cũ
            txtTenKhachCu.Text = kh.HoTen;
            txtGioiTinhCu.Text = kh.GioiTinh;
            txtCMNDCu.Text = kh.CMND;
            txtSDTCu.Text = kh.SDT;
            txtDiaChiCu.Text = kh.DiaChi;
            

            // Copy sang textbox mới
            txtMaKhachMoi.Text = kh.MaKH;
            txtTenKhachMoi.Text = kh.HoTen;
            txtGioiTinhMoi.Text = kh.GioiTinh;
            txtCMNDMoi.Text = kh.CMND;
            txtSDTMoi.Text = kh.SDT;
            txtDiaChiMoi.Text = kh.DiaChi;
            
        }

        private void txtTenKhachCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGioiTinhCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCMNDCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDTCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChiCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayDatCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKhachMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKhachMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGioiTinhMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCMNDMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDTMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChiMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayDatMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
