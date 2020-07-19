namespace WebTraSua_197.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [Key]
        public int MaNguoiDung { get; set; }

        [StringLength(250)]
        public string TenNguoiDung { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        [StringLength(250)]
        public string UserName { get; set; }

        [StringLength(10)]
        public string Pass { get; set; }
    }
}
