using QLKS.BUS;
using QLKS.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_quan_ly_khach_san
{
    public partial class Dangnhap : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;
        NhanVienBUS nvBus = new NhanVienBUS();
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string ten = txtTendn.Text.Trim();
            string mk = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!");
                return;
            }
            if (nvBus.DangNhap(ten, mk))
            {
                var nv = nvBus.LayThongTin(ten);
                KtraDangNhap.strmanhanvien = nv.MaNV;
                KtraDangNhap.strhoten = nv.HoTen;
                KtraDangNhap.strquyenhan = nv.Quyen.Trim();
                KtraDangNhap.strnguoidung = nv.TaiKhoan;

                MessageBox.Show($"Chào mừng {KtraDangNhap.strhoten}!");
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            SendMessage(txtTendn.Handle, EM_SETCUEBANNER, 0, "Nhập tên đăng nhập...");
            SendMessage(txtMatKhau.Handle, EM_SETCUEBANNER, 0, "Nhập mật khẩu...");
            this.ActiveControl = btnDangnhap;
        }


    }
}
