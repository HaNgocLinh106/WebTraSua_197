namespace WebTraSua_197.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Topping")]
    public partial class Topping
    {
        [Key]
        public int MaTopping { get; set; }

        [Column("Topping")]
        [StringLength(100)]
        public string Topping1 { get; set; }

        public int? DonGia { get; set; }
    }
}
