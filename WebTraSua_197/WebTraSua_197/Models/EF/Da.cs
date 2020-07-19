namespace WebTraSua_197.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Da")]
    public partial class Da
    {
        [Key]
        public int MaDa { get; set; }

        [Column("Da")]
        [StringLength(10)]
        public string Da1 { get; set; }
    }
}
