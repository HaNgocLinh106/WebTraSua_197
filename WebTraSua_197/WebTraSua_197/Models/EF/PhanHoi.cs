namespace WebTraSua_197.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanHoi")]
    public partial class PhanHoi
    {
        [Key]
        public int MaPhanHoi { get; set; }

        [StringLength(250)]
        public string TenNguoiPhanHoi { get; set; }

        [StringLength(500)]
        public string NoiDung { get; set; }

        public DateTime? NgayPhanHoi { get; set; }
    }
}
