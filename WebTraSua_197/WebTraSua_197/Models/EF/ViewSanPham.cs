namespace WebTraSua_197.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewSanPham")]
    public partial class ViewSanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MaSanPham { get; set; }

        [StringLength(100)]
        public string TenSanPham { get; set; }

        [StringLength(50)]
        public string MetaTitle { get; set; }

        public int? DonGia { get; set; }

        [StringLength(20)]
        public string LinkAnhSP { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        public bool? TrangThai { get; set; }

        [StringLength(10)]
        public string Size { get; set; }

        public int? Gia { get; set; }
    }
}
