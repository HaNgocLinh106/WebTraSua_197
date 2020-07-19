using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTraSua_197.Models.User
{
    public class PhanHoiModel
    {
        [Key]
        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Yêu cầu nhập họ tên")]
        public string TenNguoiDung { set; get; }

        [Display(Name = "Nội Dung")]
        public string NoiDung { set; get; }

    }
}