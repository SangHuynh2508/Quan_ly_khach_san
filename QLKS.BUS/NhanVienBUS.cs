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
        public NhanVien TimTheoMa(string maNV)
        {
            return db.NhanViens.FirstOrDefault(x => x.MaNV == maNV);
        }
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
    }
}
