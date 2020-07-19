namespace WebTraSua_197.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietGioHang")]
    public partial class ChiTietGioHang
    {
        [Key]
        public long MaChiTietGioHang { get; set; }

        public long? MaGioHang { get; set; }

        public long? MaSanPham { get; set; }

        [StringLength(10)]
        public string Duong { get; set; }

        [StringLength(10)]
        public string Da { get; set; }

        [StringLength(100)]
        public string Topping { get; set; }

        public int? DonGia { get; set; }

        public int? SoLuong { get; set; }

        public virtual GioHang GioHang { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
