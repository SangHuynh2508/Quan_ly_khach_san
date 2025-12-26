using QLKS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.BUS
{
    public class CheckinBUS
    {
        private QLKSContext db = new QLKSContext();
        public string TaoMaKH()
        {
            var lastKH = db.KhachHangs.OrderByDescending(k => k.MaKH).FirstOrDefault();
            if (lastKH == null) return "MK001";
            int nextId = int.Parse(lastKH.MaKH.Substring(2)) + 1;
            return "MK" + nextId.ToString("D3");
        }
        public string TaoMaPT()
        {
            var lastPT = db.PhieuThues.OrderByDescending(p => p.MaPhieu).FirstOrDefault();
            if (lastPT == null) return "PT001";
            int nextId = int.Parse(lastPT.MaPhieu.Substring(2)) + 1;
            return "PT" + nextId.ToString("D3");
        }
        public string ThucHienCheckin(string hoTen, string cmnd, string diaChi, string gioiTinh, int soDon, int soDoi, string maNVHienTai)
        {
            try
            {
                var listDon = db.Phongs.Where(p => p.MaLoai == "LP01" && p.TrangThai == "TRONG").Take(soDon).ToList();
                var listDoi = db.Phongs.Where(p => p.MaLoai == "LP02" && p.TrangThai == "TRONG").Take(soDoi).ToList();

                if (listDon.Count < soDon || listDoi.Count < soDoi)
                    return $"Không đủ phòng! Trống: Đơn({listDon.Count}), Đôi({listDoi.Count})";
                var kh = db.KhachHangs.FirstOrDefault(k => k.CMND == cmnd);
                if (kh == null)
                {
                    kh = new KhachHang
                    {
                        MaKH = TaoMaKH(),
                        HoTen = hoTen,
                        CMND = cmnd,
                        DiaChi = diaChi,
                        GioiTinh = gioiTinh
                    };
                    db.KhachHangs.Add(kh);
                }
                var tatCaPhong = listDon.Concat(listDoi).ToList();
                foreach (var phong in tatCaPhong)
                {
                    PhieuThue pt = new PhieuThue
                    {
                        MaPhieu = TaoMaPT(),
                        MaKH = kh.MaKH,
                        MaPhong = phong.MaPhong,
                        NgayDen = DateTime.Now,
                        MaNV = maNVHienTai
                    };
                    phong.TrangThai = "DANG_THUE";
                    db.PhieuThues.Add(pt);
                    db.SaveChanges();
                }
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
    }
}
