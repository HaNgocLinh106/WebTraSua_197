namespace WebTraSua_197.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Size")]
    public partial class Size
    {
        [Key]
        public int MaSize { get; set; }

        public long? MaSanPham { get; set; }

        [Column("Size")]
        [StringLength(10)]
        public string Size1 { get; set; }

        public int? Gia { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
