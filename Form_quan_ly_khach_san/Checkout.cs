using QLKS.DAL.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Form_quan_ly_khach_san
{
    public partial class Checkout : Form
    {
        private QLKSContext db = new QLKSContext();

        public Checkout()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            LoadActiveCheckins();
            txtMaCheckin.ReadOnly = true;
            txtPhong.ReadOnly = true;
            txtTienPhong.ReadOnly = true;
            txtTienDichVu.ReadOnly = true;
            txtTongSoTien.ReadOnly = true;
        }

        private void LoadActiveCheckins()
        {
            comboBox1.Items.Clear();
            var list = db.PhieuThues
                .Where(p => p.NgayDi == null)
                .Select(p => new
                {
                    p.MaPhieu,
                    p.MaPhong,
                    TenPhong = p.Phong.TenPhong,
                    Khach = p.KhachHang.HoTen
                })
                .ToList();

            foreach (var it in list)
            {
                // Display MaPhieu - Room - Guest
                comboBox1.Items.Add($"{it.MaPhieu} | {it.MaPhong} | {it.TenPhong} | {it.Khach}");
            }

            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
        }

        private string ExtractMaPhieuFromCombo()
        {
            if (comboBox1.SelectedItem == null) return null;
            var s = comboBox1.SelectedItem.ToString();
            var parts = s.Split('|');
            return parts.Length > 0 ? parts[0].Trim() : null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedRentalInfo();
        }

        private void UpdateSelectedRentalInfo()
        {
            string maPhieu = ExtractMaPhieuFromCombo();
            if (string.IsNullOrEmpty(maPhieu)) return;

            var pt = db.PhieuThues
                .Where(p => p.MaPhieu == maPhieu)
                .Select(p => new
                {
                    p.MaPhieu,
                    p.MaPhong,
                    p.NgayDen,
                    LoaiDonGia = p.Phong.LoaiPhong.DonGia
                })
                .FirstOrDefault();

            if (pt == null) return;

            txtMaCheckin.Text = pt.MaPhieu;
            txtPhong.Text = pt.MaPhong;

            // compute days (at least 1)
            var days = (DateTime.Now.Date - pt.NgayDen.Date).Days;
            if (days <= 0) days = 1;
            txtSoNgayThue.Text = days.ToString();

            // room total
            decimal tienPhong = pt.LoaiDonGia * days;
            txtTienPhong.Text = tienPhong.ToString("N0");

            // service total
            var tienDichVu = db.ChiTietDichVus
                .Where(c => c.MaPhieu == pt.MaPhieu)
                .Join(db.DichVus, c => c.MaDV, d => d.MaDV, (c, d) => new { c.SoLuong, d.DonGia })
                .Select(x => x.SoLuong * x.DonGia)
                .DefaultIfEmpty(0M)
                .Sum();

            txtTienDichVu.Text = tienDichVu.ToString("N0");

            // total
            txtTongSoTien.Text = (tienPhong + tienDichVu).ToString("N0");
        }

        private string TaoMaHD()
        {
            var last = db.HoaDons.OrderByDescending(h => h.MaHD).FirstOrDefault();
            if (last == null) return "HD001";
            int next = int.Parse(last.MaHD.Substring(2)) + 1;
            return "HD" + next.ToString("D3");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhieu = ExtractMaPhieuFromCombo();
                if (string.IsNullOrEmpty(maPhieu))
                {
                    MessageBox.Show("Chọn một phiếu thuê để thanh toán.");
                    return;
                }

                var pt = db.PhieuThues.FirstOrDefault(p => p.MaPhieu == maPhieu);
                if (pt == null)
                {
                    MessageBox.Show("Phiếu thuê không tồn tại.");
                    return;
                }

                // compute totals again server-side
                var days = (DateTime.Now.Date - pt.NgayDen.Date).Days;
                if (days <= 0) days = 1;
                decimal tienPhong = pt.Phong.LoaiPhong.DonGia * days;
                decimal tienDichVu = db.ChiTietDichVus
                    .Where(c => c.MaPhieu == pt.MaPhieu)
                    .Join(db.DichVus, c => c.MaDV, d => d.MaDV, (c, d) => c.SoLuong * d.DonGia)
                    .DefaultIfEmpty(0M)
                    .Sum();
                decimal tong = tienPhong + tienDichVu;

                // create HoaDon
                var hd = new HoaDon
                {
                    MaHD = TaoMaHD(),
                    MaPhieu = pt.MaPhieu,
                    NgayThanhToan = DateTime.Now,
                    TongTien = tong
                };

                pt.NgayDi = DateTime.Now;
                pt.Phong.TrangThai = "TRONG";

                db.HoaDons.Add(hd);
                db.SaveChanges();

                MessageBox.Show($"Check-out thành công. Hoá đơn: {hd.MaHD}\nTổng: {tong:N0}");
                LoadActiveCheckins();
                txtMaCheckin.Clear();
                txtPhong.Clear();
                txtTienPhong.Clear();
                txtTienDichVu.Clear();
                txtTongSoTien.Clear();
                txtSoNgayThue.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện thanh toán: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoNgayThue_TextChanged(object sender, EventArgs e)
        {
            // allow manual override: recalc room and total if days changed
            if (string.IsNullOrEmpty(txtMaCheckin.Text)) return;
            int days;
            if (!int.TryParse(txtSoNgayThue.Text.Trim(), out days) || days <= 0) return;

            var maPhieu = txtMaCheckin.Text;
            var pt = db.PhieuThues.Where(p => p.MaPhieu == maPhieu).Select(p => new
            {
                DonGia = p.Phong.LoaiPhong.DonGia
            }).FirstOrDefault();
            if (pt == null) return;

            decimal tienPhong = pt.DonGia * days;
            txtTienPhong.Text = tienPhong.ToString("N0");

            // update total with existing displayed service money
            decimal dv = 0;
            decimal.TryParse(txtTienDichVu.Text, System.Globalization.NumberStyles.AllowThousands, null, out dv);
            txtTongSoTien.Text = (tienPhong + dv).ToString("N0");
        }
    }
}
