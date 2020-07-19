using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTraSua_197.Models.EF;

namespace WebTraSua_197.Models.Fun
{
    public class CartDetailF
    {
        WebTraSua db = null;
        public CartDetailF()
        {
            db = new WebTraSua();
        }
        public bool Insert(ChiTietGioHang ctgh)
        {
            try
            {
                db.ChiTietGioHangs.Add(ctgh);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}