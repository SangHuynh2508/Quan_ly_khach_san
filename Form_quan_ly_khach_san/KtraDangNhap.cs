using Form_quan_ly_khach_san.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_quan_ly_khach_san
{
    public static class KtraDangNhap
    {
        public static string strmanhanvien = "";
        public static string strhoten = "";
        public static string strnguoidung = "";
        public static string strquyenhan = "";
        public static string strmatkhau = "";

        public static bool kt_dangnhap(string ten, string matkhau)
        {
            try
            {
                using (var db = new QLKSContext()) 
                {
                    var nv = db.NhanViens.FirstOrDefault(x => x.TaiKhoan == ten && x.MatKhau == matkhau);

                    if (nv != null)
                    {
                        strmanhanvien = nv.MaNV;
                        strhoten = nv.HoTen;
                        strnguoidung = nv.TaiKhoan;
                        strquyenhan = nv.Quyen;
                        strmatkhau = nv.MatKhau;

                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                return false; 
            }
        }
    }
}
