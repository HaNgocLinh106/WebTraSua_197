namespace WebTraSua_197.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Duong")]
    public partial class Duong
    {
        [Key]
        public int MaDuong { get; set; }

        [Column("Duong")]
        [StringLength(10)]
        public string Duong1 { get; set; }
    }
}
