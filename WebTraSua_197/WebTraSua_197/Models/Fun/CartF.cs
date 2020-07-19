using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTraSua_197.Models.EF;

namespace WebTraSua_197.Models.Fun
{
    public class CartF
    {
        WebTraSua db = null;
        public CartF()
        {
            db = new WebTraSua();
        }
        public long Insert(GioHang giohang)
        {
            db.GioHangs.Add(giohang);
            db.SaveChanges();
            return giohang.MaGioHang;
        }

        //public long Update(ChiTietSanPham chitietsp)
        //{

        //    var ctsp = db.ChiTietSanPhams.Find(chitietsp.MaCTSP);
        //    ctsp.SoLuong = chitietsp.SoLuong;
        //    db.SaveChanges();
        //    return ctsp.MaCTSP;


        //}
    }
}