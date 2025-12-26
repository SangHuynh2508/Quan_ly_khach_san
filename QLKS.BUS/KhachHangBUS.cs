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
    }
}
