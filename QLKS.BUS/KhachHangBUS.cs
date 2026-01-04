using QLKS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.BUS
{
    public class KhachHangBUS
    {
        private QLKSContext db = new QLKSContext();
        public List<KhachHang> LayTatCaKhachHang()
        {
            return db.KhachHangs.ToList();
        }
        public List<KhachHang> TimKhachTheoTen(string ten)
        {
            return db.KhachHangs
                     .Where(k => k.HoTen.Contains(ten))
                     .ToList();
        }
        public List<KhachHang> TimKhachTheoCMND(string cmnd)
        {
            return db.KhachHangs
                     .Where(k => k.CMND.Contains(cmnd))
                     .ToList();
        }
        public bool XoaKhachHang(string maKH)
        {
            var kh = db.KhachHangs.Find(maKH);
            if (kh != null)
            {
                db.KhachHangs.Remove(kh);
                return db.SaveChanges() > 0;
            }
            return false;
        }


        // Tìm khách theo mã
        public KhachHang TimKhachTheoMa(string maKH)
        {
            return db.KhachHangs.FirstOrDefault(k => k.MaKH == maKH);
        }

        // Sửa thông tin khách hàng
        public bool SuaKhachHang(KhachHang kh)
        {
            var khachCu = db.KhachHangs.FirstOrDefault(k => k.MaKH == kh.MaKH);
            if (khachCu == null)
                return false;

            khachCu.HoTen = kh.HoTen;
            khachCu.GioiTinh = kh.GioiTinh;
            khachCu.CMND = kh.CMND;
            khachCu.SDT = kh.SDT;
            khachCu.DiaChi = kh.DiaChi;
            // khachCu.NgayDat = kh.NgayDat; // nếu cần cập nhật ngày đặt

            return db.SaveChanges() > 0;
        }




    }
}
