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
    public partial class ThayDoiTTNhanVien : Form
    {
        private NhanVienBUS nvBus = new NhanVienBUS();
        public ThayDoiTTNhanVien()
        {
            InitializeComponent();
        }
        private void ThayDoiTTNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = KtraDangNhap.strmanhanvien;
            txtHoTen.Text = KtraDangNhap.strhoten;
            txtTenDangNhap.Text = KtraDangNhap.strnguoidung;


            var nv = nvBus.LayThongTin(KtraDangNhap.strnguoidung);
            if (nv != null)
            {
                txtSDT.Text = nv.SDT;
            }
            txtMaNV.ReadOnly = true;
            txtTenDangNhap.ReadOnly = true;
        }
        #region events
        private void btnThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            ThayDoiMatKhau mk = new ThayDoiMatKhau();
            mk.ShowDialog();    
        }

        private void btnThayDoiThongTin_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string hoTenMoi = txtHoTen.Text.Trim();
            string sdtMoi = txtSDT.Text.Trim();

            if (string.IsNullOrEmpty(hoTenMoi))
            {
                MessageBox.Show("Họ tên không được để trống!");
                return;
            }
            if (nvBus.CapNhatThongTinCaNhan(maNV, hoTenMoi, sdtMoi))
            {
                KtraDangNhap.strhoten = hoTenMoi;
                MessageBox.Show("Cập nhật thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Không có thay đổi nào được thực hiện.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        
    }
}
