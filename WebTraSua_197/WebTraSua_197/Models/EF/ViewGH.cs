namespace WebTraSua_197.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewGH")]
    public partial class ViewGH
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MaGioHang { get; set; }

        [StringLength(100)]
        public string TenSanPham { get; set; }

        [StringLength(20)]
        public string LinkAnhSP { get; set; }

        [StringLength(10)]
        public string Size { get; set; }

        [StringLength(10)]
        public string Duong { get; set; }

        [StringLength(10)]
        public string Da { get; set; }

        [StringLength(100)]
        public string Topping { get; set; }

        public int? DonGia { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(250)]
        public string TenNguoiDung { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        [StringLength(250)]
        public string HinhThucThanhToan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThang { get; set; }
    }
}
