namespace QLKS.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Required]
        [StringLength(10)]
        public string MaPhieu { get; set; }

        public DateTime NgayThanhToan { get; set; }

        public decimal TongTien { get; set; }

        public virtual PhieuThue PhieuThue { get; set; }
    }
}
