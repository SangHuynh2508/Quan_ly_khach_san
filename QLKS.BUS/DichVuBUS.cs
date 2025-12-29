using QLKS.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace QLKS.BUS
{
    public class DichVuBUS
    {
        private QLKSContext db = new QLKSContext();

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
    }
}
