using Form_quan_ly_khach_san.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Form_quan_ly_khach_san
{
    public partial class Dangnhap : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;
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
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo");
                return;
            }
            if (KtraDangNhap.kt_dangnhap(ten, mk))
            {
                MessageBox.Show($"Chào mừng {KtraDangNhap.strhoten}!", "Thành công");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Lỗi");
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
