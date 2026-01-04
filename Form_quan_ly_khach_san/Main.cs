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
    public partial class Main : Form
    {
        public static string s = "Chương trình quản lý khách sạn,Hãy đăng nhập để sử dụng chương trình ";
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            CapNhatTrangThaiMenu();
        }
        public void CapNhatTrangThaiMenu()
        {
            string quyen = KtraDangNhap.strquyenhan;
            if (string.IsNullOrEmpty(quyen))
            {
                MnCheckin.Enabled = false;
                MnCheckout.Enabled = false;
                MnTimKiem.Enabled = false;
                MnCapNhat.Enabled = false;
                MnXoaKhach.Enabled = false;
                MnQuanLyDichVu.Enabled = false;
                MnCapNhatNV.Enabled = false;
                MnTimKiemNV.Enabled = false;
                MnThemXoaNV.Enabled = false;

                MnThayDoiTTCaNhan.Enabled = false;
                MnDangXuat.Enabled = false;

                MnDangNhap.Enabled = true;

                s = "Chương trình quản lý khách sạn. Hãy đăng nhập để sử dụng chương trình!      ";
            }
            else
            {
                MnDangNhap.Enabled = false;
                MnDangXuat.Enabled = true;
                MnThayDoiTTCaNhan.Enabled = true;

                MnCheckin.Enabled = true;
                MnCheckout.Enabled = true;
                MnTimKiem.Enabled = true;
                MnQuanLyDichVu.Enabled = true;

                if (quyen == "ADMIN")
                {
                    MnCapNhat.Enabled = true;
                    MnXoaKhach.Enabled = true;
                    MnCapNhatNV.Enabled = true;
                    MnTimKiemNV.Enabled = true;
                    MnThemXoaNV.Enabled = true;
                }
                else 
                {
                    MnCapNhat.Enabled = true;
                    MnXoaKhach.Enabled = false; 
                    MnCapNhatNV.Enabled = false;
                    MnTimKiemNV.Enabled = false;
                    MnThemXoaNV.Enabled = false;
                }    
                s = "Chào mừng " + KtraDangNhap.strhoten + " đang sử dụng hệ thống quản lý khách sạn!      ";
            }
        }
        #region Chức năng chung
        private void MnDangNhap_Click(object sender, EventArgs e)
        {
            Dangnhap dangnhap = new Dangnhap();
            if (dangnhap.ShowDialog() == DialogResult.OK)
            {
                CapNhatTrangThaiMenu();
            }
        }

        private void MnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }

        private void MnThayDoiTTCaNhan_Click(object sender, EventArgs e)
        {
            ThayDoiTTNhanVien thayDoiTTNhanVien = new ThayDoiTTNhanVien();
            thayDoiTTNhanVien.ShowDialog();
        }

        private void MnDangXuat_Click(object sender, EventArgs e)
        {
            KtraDangNhap.strquyenhan = "";
            KtraDangNhap.strhoten = "";
            CapNhatTrangThaiMenu();
            MessageBox.Show("Đã đăng xuất tài khoản!");
        }

        private void MnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
#endregion
        #region chức năng quản lý
        private void MnCheckin_Click(object sender, EventArgs e)
        {
            Checkin frmCheckin = new Checkin(); 
            frmCheckin.ShowDialog();
        }

        private void MnCheckout_Click(object sender, EventArgs e)
        {
            Checkout frmCheckout = new Checkout();
            frmCheckout.ShowDialog();
        }

        private void MnTimKiem_Click(object sender, EventArgs e)
        {
            TimKhach timKhach = new TimKhach();
            timKhach.ShowDialog();
        }

        private void MnCapNhat_Click(object sender, EventArgs e)
        {
            ThayDoiTTKhach khach = new ThayDoiTTKhach();
            khach.ShowDialog();
        }

        private void MnXoaKhach_Click(object sender, EventArgs e)
        {
            XoaKhach xoakhach = new XoaKhach();
            xoakhach.ShowDialog();
        }

        private void MnQuanLyDichVu_Click(object sender, EventArgs e)
        {
            frmDichVu dichVu = new frmDichVu();
            dichVu.ShowDialog();
        }

        private void MnCapNhatNV_Click(object sender, EventArgs e)
        {
            Phanquyen frmPQ = new Phanquyen();
            frmPQ.ShowDialog();
        }

        private void MnTimKiemNV_Click(object sender, EventArgs e)
        {
            TimNhanVien timNhanVien = new TimNhanVien();
            timNhanVien.ShowDialog();
        }

        private void MnThemXoaNV_Click(object sender, EventArgs e)
        {
            ThemNhanVien themNhanVien = new ThemNhanVien();
            themNhanVien.ShowDialog();
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(s)) return;

            label2.Text = s;
            string tam = s[0].ToString();
            s = s.Substring(1, s.Length - 1) + tam;
        }

        private void MnQLKhach_Click(object sender, EventArgs e)
        {
            QuanLyKhach quanLyKhach = new QuanLyKhach();
            quanLyKhach.ShowDialog();
        }

    }
}
