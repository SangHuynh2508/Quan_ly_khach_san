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

namespace Form_quan_ly_khach_san
{
    public partial class Checkin : Form
    {
        private QLKSContext db = new QLKSContext();
        public Checkin()
        {
            InitializeComponent();
        }
        #region hàm cần thiết
        private string TaoMaKH()
        {
            var lastKH = db.KhachHangs.OrderByDescending(k => k.MaKH).FirstOrDefault();
            if (lastKH == null) return "MK001";

            int nextId = int.Parse(lastKH.MaKH.Substring(2)) + 1;
            return "MK" + nextId.ToString("D3");
        }

        private string TaoMaPT()
        {
            var lastPT = db.PhieuThues.OrderByDescending(p => p.MaPhieu).FirstOrDefault();
            if (lastPT == null) return "PT001";

            int nextId = int.Parse(lastPT.MaPhieu.Substring(2)) + 1;
            return "PT" + nextId.ToString("D3");
        }
        private void ResetForm()
        {
            txtHoTen.Clear();
            txtCMND.Clear();
            txtDiaChi.Clear();
            txtSoPhongDon.Clear();
            txtSoPhongDoi.Clear();
            txtMaKhach.Text = TaoMaKH();
            txtMaCheckin.Text = TaoMaPT();
        }
        #endregion
        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtSoPhongDon.Text, out int soDon);
                int.TryParse(txtSoPhongDoi.Text, out int soDoi);

                if (soDon == 0 && soDoi == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng phòng muốn thuê!");
                    return;
                }
                var listDon = db.Phongs.Where(p => p.MaLoai == "LP01" && p.TrangThai == "TRONG").Take(soDon).ToList();
                var listDoi = db.Phongs.Where(p => p.MaLoai == "LP02" && p.TrangThai == "TRONG").Take(soDoi).ToList();
                if (listDon.Count < soDon || listDoi.Count < soDoi)
                {
                    MessageBox.Show($"Không đủ phòng trống!\nĐơn còn: {listDon.Count}\nĐôi còn: {listDoi.Count}");
                    return;
                }
                string cmnd = txtCMND.Text.Trim();
                var khachHang = db.KhachHangs.FirstOrDefault(k => k.CMND == cmnd);
                if (khachHang == null)
                {
                    khachHang = new KhachHang
                    {
                        MaKH = txtMaKhach.Text,
                        HoTen = txtHoTen.Text.Trim(),
                        GioiTinh = radioButton1.Checked ? "Nam" : "Nữ",
                        CMND = cmnd,
                        DiaChi = txtDiaChi.Text.Trim()
                    };
                    db.KhachHangs.Add(khachHang);
                }
                var tatCaPhongThue = listDon.Concat(listDoi).ToList();

                foreach (var phong in tatCaPhongThue)
                {
                    PhieuThue pt = new PhieuThue
                    {
                        MaPhieu = TaoMaPT(), 
                        MaKH = khachHang.MaKH,
                        MaPhong = phong.MaPhong,
                        NgayDen = DateTime.Now,
                        MaNV = KtraDangNhap.strmanhanvien
                    };
                    phong.TrangThai = "DANG_THUE"; 
                    db.PhieuThues.Add(pt);
                    db.SaveChanges();
                }

                MessageBox.Show($"Check-in thành công {tatCaPhongThue.Count} phòng!");
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtCMND.Clear();
            txtSoPhongDon.Clear();
            txtMaKhach.Text = TaoMaKH();
            txtMaCheckin.Text = TaoMaPT();
            txtHoTen.Focus();
        }

        private void Checkin_Load(object sender, EventArgs e)
        {
            txtMaKhach.Text = TaoMaKH();
            txtMaCheckin.Text = TaoMaPT();
            txtMaKhach.ReadOnly = true;
            txtMaCheckin.ReadOnly = true;
            txtNgayDen.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
