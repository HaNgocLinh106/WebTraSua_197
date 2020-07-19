using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTraSua_197.Models.EF;

namespace WebTraSua_197.Models.Fun
{
    public class DanhMucF
    {

        WebTraSua db = null;
        public DanhMucF()
        {
            db = new WebTraSua();
        }

        public List<DanhMuc> ListAll()
        {
            return db.DanhMucs.ToList();
        }
        public SanPham ViewDetail(long MaDanhMuc)
        {
            return db.SanPhams.Find(MaDanhMuc);
        }
        public DanhMuc DanhMucSP(long id)
        {
            return db.DanhMucs.Find(id);
        }
        public List<SanPham> ListAllSP(long MaDanhMuc)
        {
            var sp = db.SanPhams.Find(MaDanhMuc);
            return db.SanPhams.Where(x => x.MaDanhMuc == sp.MaDanhMuc).ToList();
        }
    }
}