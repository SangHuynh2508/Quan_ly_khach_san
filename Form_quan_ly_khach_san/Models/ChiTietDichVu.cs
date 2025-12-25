namespace Form_quan_ly_khach_san.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDichVu")]
    public partial class ChiTietDichVu
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaPhieu { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaDV { get; set; }

        public int SoLuong { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime NgayDung { get; set; }

        public virtual DichVu DichVu { get; set; }

        public virtual PhieuThue PhieuThue { get; set; }
    }
}
