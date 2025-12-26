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
    public partial class ThayDoiMatKhau : Form
    {
        private NhanVienBUS nvBus = new NhanVienBUS();
        public ThayDoiMatKhau()
        {
            InitializeComponent();
        }
        private void ThayDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMatKhauCu.UseSystemPasswordChar = true;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            txtNhapLaiMatKhauMoi.UseSystemPasswordChar = true;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string mkCu = txtMatKhauCu.Text.Trim();
            string mkMoi = txtMatKhauMoi.Text.Trim();
            string xacNhan = txtNhapLaiMatKhauMoi.Text.Trim();
            if (string.IsNullOrEmpty(mkCu) || string.IsNullOrEmpty(mkMoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (mkMoi != xacNhan)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return;
            }
            if (nvBus.DoiMatKhau(KtraDangNhap.strmanhanvien, mkCu, mkMoi))
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
