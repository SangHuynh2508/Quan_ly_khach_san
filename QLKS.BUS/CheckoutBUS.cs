using QLKS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLKS.BUS
{
    public class CheckoutBUS
    {
        private QLKSContext db = new QLKSContext();
        public List<PhieuThue> LayTatCaPhieuThue()
        {
            return db.PhieuThues.ToList();
        }
        public PhieuThue LayPhieuThueTheoMa(string maPhieu)
        {
            return db.PhieuThues.FirstOrDefault(p => p.MaPhieu == maPhieu);
        }
        public int TinhSoNgayThue(string maPhieu)
        {
            var phieu = LayPhieuThueTheoMa(maPhieu);
            if (phieu == null) return 0;

            DateTime ngayDen = phieu.NgayDen.Date;
            DateTime ngayDi = (phieu.NgayDi ?? DateTime.Now).Date;

            int soNgay = (ngayDi - ngayDen).Days;

            return soNgay <= 0 ? 1 : soNgay;
        }
        public (string tenPhong, decimal donGiaPhong) LayThongTinPhong(string maPhieu)
        {
            var phieu = LayPhieuThueTheoMa(maPhieu);
            if (phieu == null) return ("", 0);

            var phong = db.Phongs.FirstOrDefault(p => p.MaPhong == phieu.MaPhong);
            if (phong == null) return ("", 0);

            var loaiPhong = db.LoaiPhongs.FirstOrDefault(l => l.MaLoai == phong.MaLoai);
            if (loaiPhong == null) return (phong.TenPhong, 0);

            return (phong.TenPhong, loaiPhong.DonGia);
        }
        public decimal TinhTienDichVu(string maPhieu)
        {
            var ds = db.ChiTietDichVus.Where(c => c.MaPhieu == maPhieu).ToList();
            decimal tong = 0;

            foreach (var ct in ds)
            {
                var dv = db.DichVus.FirstOrDefault(d => d.MaDV == ct.MaDV);
                if (dv != null)
                    tong += dv.DonGia * ct.SoLuong;
            }
            return tong;
        }
        public decimal TinhTongTien(string maPhieu)
        {
            int soNgay = TinhSoNgayThue(maPhieu);
            var (_, donGia) = LayThongTinPhong(maPhieu);

            decimal tienPhong = donGia * soNgay;
            decimal tienDV = TinhTienDichVu(maPhieu);

            return tienPhong + tienDV;
        }
        public bool ThucHienCheckout(string maPhieu)
        {
            var pt = LayPhieuThueTheoMa(maPhieu);
            if (pt == null) return false;
            pt.NgayDi = DateTime.Now;
            HoaDon hd = new HoaDon
            {
                MaHD = "HD" + DateTime.Now.Ticks.ToString().Substring(10),
                MaPhieu = maPhieu,
                NgayThanhToan = DateTime.Now,
                TongTien = TinhTongTien(maPhieu)
            };
            db.HoaDons.Add(hd);
            var phong = db.Phongs.FirstOrDefault(p => p.MaPhong == pt.MaPhong);
            if (phong != null)
                phong.TrangThai = "TRONG";

            db.SaveChanges();
            return true;
        }
    }
}
