using QLKS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLKS.BUS
{
    public class CheckoutBUS
    {
        private QLKSContext db = new QLKSContext();

        // Lấy tất cả phiếu thuê
        public List<PhieuThue> LayTatCaPhieuThue()
        {
            return db.PhieuThues.ToList();
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

            DateTime ngayDen = phieu.NgayDen;
            DateTime ngayDi = phieu.NgayDi ?? DateTime.Now; // nếu chưa có ngày đi thì tính đến hôm nay

            int soNgay = (ngayDi - ngayDen).Days;
            return soNgay > 0 ? soNgay : 1; // tối thiểu 1 ngày
        }

        // Lấy thông tin phòng: tên phòng + đơn giá loại phòng
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
            var dsDV = db.ChiTietDichVus.Where(c => c.MaPhieu == maPhieu).ToList();
            decimal tong = 0;
            foreach (var dv in dsDV)
            {
                var dichVu = db.DichVus.FirstOrDefault(d => d.MaDV == dv.MaDV);
                if (dichVu != null)
                    tong += dichVu.DonGia * dv.SoLuong;
            }
            return tong;
        }

        // Tổng tiền
        public decimal TinhTongTien(string maPhieu)
        {
            int soNgay = TinhSoNgayThue(maPhieu);
            var (_, donGiaPhong) = LayThongTinPhong(maPhieu);
            decimal tienPhong = donGiaPhong * soNgay;
            decimal tienDV = TinhTienDichVu(maPhieu);
            return tienPhong + tienDV;
        }

        // Checkout: cập nhật trạng thái phòng
        public void ThucHienCheckout(string maPhieu)
        {
            var pt = LayPhieuThueTheoMa(maPhieu);
            if (pt != null)
            {
                var phong = db.Phongs.FirstOrDefault(p => p.MaPhong == pt.MaPhong);
                if (phong != null)
                    phong.TrangThai = "TRONG";

                db.SaveChanges();
            }
        }
    }
}
