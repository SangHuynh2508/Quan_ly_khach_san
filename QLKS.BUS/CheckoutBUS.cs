using QLKS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLKS.BUS
{
    public class CheckoutBUS
    {
        private QLKSContext db = new QLKSContext();

        // Lấy tất cả phiếu thuê CHƯA checkout
        public List<PhieuThue> LayTatCaPhieuThue()
        {
            return db.PhieuThues
                     .Where(p => p.NgayDi == null)
                     .ToList();
        }

        // Lấy phiếu thuê theo mã
        public PhieuThue LayPhieuThueTheoMa(string maPhieu)
        {
            return db.PhieuThues.FirstOrDefault(p => p.MaPhieu == maPhieu);
        }

        // Tính số ngày thuê
        public int TinhSoNgayThue(string maPhieu)
        {
            var phieu = LayPhieuThueTheoMa(maPhieu);
            if (phieu == null) return 0;

            DateTime ngayDen = phieu.NgayDen.Date;
            DateTime ngayDi = DateTime.Now.Date;

            int soNgay = (ngayDi - ngayDen).Days;

            return soNgay <= 0 ? 1 : soNgay;
        }

        // Lấy thông tin phòng
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

        // Tính tiền dịch vụ
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

        // Tổng tiền
        public decimal TinhTongTien(string maPhieu)
        {
            int soNgay = TinhSoNgayThue(maPhieu);
            var (_, donGia) = LayThongTinPhong(maPhieu);

            decimal tienPhong = donGia * soNgay;
            decimal tienDV = TinhTienDichVu(maPhieu);

            return tienPhong + tienDV;
        }

        // CHECKOUT
        public bool ThucHienCheckout(string maPhieu)
        {
            var pt = LayPhieuThueTheoMa(maPhieu);
            if (pt == null) return false;

            // cập nhật ngày đi
            pt.NgayDi = DateTime.Now;

            // tạo hóa đơn
            HoaDon hd = new HoaDon
            {
                MaHD = "HD" + DateTime.Now.Ticks.ToString().Substring(10),
                MaPhieu = maPhieu,
                NgayThanhToan = DateTime.Now,
                TongTien = TinhTongTien(maPhieu)
            };
            db.HoaDons.Add(hd);

            // cập nhật trạng thái phòng
            var phong = db.Phongs.FirstOrDefault(p => p.MaPhong == pt.MaPhong);
            if (phong != null)
                phong.TrangThai = "TRONG";

            db.SaveChanges();
            return true;
        }
    }
}
