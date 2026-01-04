using QLKS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLKS.BUS
{
    public class DichVuBUS
    {
        private QLKSContext db = new QLKSContext();

        // =======================
        // 1. DANH MỤC DỊCH VỤ
        // =======================
        public List<DichVu> LayTatCaDichVu()
        {
            return db.DichVus.ToList();
        }

        public bool ThemDichVu(DichVu dv)
        {
            db.DichVus.Add(dv);
            return db.SaveChanges() > 0;
        }

        public DichVu TimDichVuTheoTen(string tenDV)
        {
            return db.DichVus.FirstOrDefault(d => d.TenDV == tenDV);
        }

        // =======================
        // 2. DỊCH VỤ THEO PHIẾU THUÊ
        // =======================
        public bool ThemDichVuVaoPhieu(string maPhieu, string maDV, int soLuong)
        {
            ChiTietDichVu ct = new ChiTietDichVu
            {
                MaPhieu = maPhieu,
                MaDV = maDV,
                SoLuong = soLuong,
                NgayDung = DateTime.Now
            };

            db.ChiTietDichVus.Add(ct);
            return db.SaveChanges() > 0;
        }

        public List<ChiTietDichVu> LayDichVuTheoPhieu(string maPhieu)
        {
            return db.ChiTietDichVus
                     .Where(x => x.MaPhieu == maPhieu)
                     .ToList();
        }
    }
}
