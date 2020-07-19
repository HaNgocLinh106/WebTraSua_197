using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTraSua_197.Models.EF;

namespace WebTraSua_197.Models.Fun
{
    public class PhanHoiF
    {
        WebTraSua db = null;
        public PhanHoiF()
        {
            db = new WebTraSua();
        }
        public List<PhanHoi> ListPH(int top)
        {
            return db.PhanHois.Take(top).ToList();
        }
        public long InsertPH(PhanHoi entity)
        {
            db.PhanHois.Add(entity);
            db.SaveChanges();
            return entity.MaPhanHoi;
        }
    }
}