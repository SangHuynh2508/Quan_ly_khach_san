using QLKS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLKS.BUS
{
    public class NhanVienBUS
    {
        private QLKSContext db = new QLKSContext();
        #region lấy thông tin
        public List<NhanVien> LayTatCaNhanVien()
        {
            return db.NhanViens.ToList();
        }
        public bool DangNhap(string taiKhoan, string matKhau)
        {
            var nv = db.NhanViens.FirstOrDefault(x => x.TaiKhoan == taiKhoan && x.MatKhau == matKhau);

            if (nv != null)
            {
                return true;
            }
            return false;
        }
        public NhanVien LayThongTin(string taiKhoan)
        {
            return db.NhanViens.FirstOrDefault(x => x.TaiKhoan == taiKhoan);
        }
        public List<NhanVien> LayDanhSachNhanVien()
        {
            return db.NhanViens.ToList();
        }
        #endregion
        public NhanVien TimTheoMa(string maNV)
        {
            return db.NhanViens.FirstOrDefault(x => x.MaNV == maNV);
        }
        #region Cập nhật thông tin
        public bool CapNhatQuyen(string maNV, string quyenMoi)
        {
            var nv = db.NhanViens.FirstOrDefault(x => x.MaNV == maNV);
            if (nv != null)
            {
                nv.Quyen = quyenMoi;
                return db.SaveChanges() > 0;
            }
            return false;
        }
        public bool ThemNhanVien(NhanVien nv)
        {
            using (var db = new QLKSContext())
            {
                var check = db.NhanViens.FirstOrDefault(x => x.TaiKhoan == nv.TaiKhoan);
                if (check != null) return false;
                nv.MatKhau = "123";
                db.NhanViens.Add(nv);
                return db.SaveChanges() > 0;
            }
        }
        public bool CapNhatThongTinCaNhan(string maNV, string hoTen, string sdt)
        {
            using (var db = new QLKSContext())
            {
                var nv = db.NhanViens.FirstOrDefault(x => x.MaNV == maNV);
                if (nv != null)
                {
                    nv.HoTen = hoTen;
                    nv.SDT = sdt;
                    return db.SaveChanges() > 0;
                }
                return false;
            }
        }
        public string TaoMaNVTuDong()
        {
            using (var db = new QLKSContext())
            {
                var lastNV = db.NhanViens.OrderByDescending(x => x.MaNV).FirstOrDefault();
                if (lastNV == null) return "NV001";
                int nextId = int.Parse(lastNV.MaNV.Substring(2)) + 1;
                return "NV" + nextId.ToString("D3");
            }
        }
        public bool DoiMatKhau(string maNV, string mkCu, string mkMoi)
        {
            using (var db = new QLKSContext())
            {
                var nv = db.NhanViens.FirstOrDefault(x => x.MaNV == maNV && x.MatKhau == mkCu);

                if (nv != null)
                {
                    nv.MatKhau = mkMoi;
                    return db.SaveChanges() > 0;
                }
                return false;
            }
        }
        #endregion
    }
}
