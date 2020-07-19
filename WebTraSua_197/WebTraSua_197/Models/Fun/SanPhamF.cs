using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTraSua_197.Models.EF;

namespace WebTraSua_197.Models.Fun
{
    public class SanPhamF
    {
        WebTraSua db = null;
        public SanPhamF()
        {
            db = new WebTraSua();
        }
        public List<SanPham> Menu()
        {
            return db.SanPhams.ToList();
        }
        public SanPham Detail(long MaSanPham)
        {
            return db.SanPhams.Find(MaSanPham);
        }
        public List<ViewSanPham> ListDetail (long MaSanPham)
        {
            var sp = db.SanPhams.Find(MaSanPham);
            return db.ViewSanPhams.Where(x => x.MaSanPham == sp.MaSanPham).ToList();
        }

        public SanPham FindEntity(long MaSanPham)
        {
            return db.SanPhams.Find(MaSanPham);
        }
        public List<SanPham> ListAllSP()
        {
            return db.SanPhams.ToList();
        }

        public List<SanPham> SanPhamLQ(long MaDanhMuc)
        {
            var sp = db.SanPhams.Find(MaDanhMuc);
            return db.SanPhams.Where(x => x.MaDanhMuc == sp.MaDanhMuc && x.MaSanPham != sp.MaSanPham).ToList();
        }

        public List<SanPham> ListSP(int top)
        {
            return db.SanPhams.Take(top).ToList();
        }

        public List<Topping> Topping()
        {
            return db.Toppings.ToList();
        }
        public List<Duong> Duong()
        {
            return db.Duongs.ToList();
        }
        public List<Da> Da()
        {
            return db.Das.ToList();
        }

        public List<SanPham> TimKiemSP(string TenSP)
        {
            return db.SanPhams.Where(x => x.TenSanPham.Contains(TenSP)).ToList();
        }
        
    }
}