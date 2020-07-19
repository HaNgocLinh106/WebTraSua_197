using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTraSua_197.Models.EF;

namespace WebTraSua_197.Models.Fun
{
    public class UserF
    {

        WebTraSua db = null;
        public UserF()
        {
            db = new WebTraSua();
        }

        public long Insert(NguoiDung entity)
        {
            db.NguoiDungs.Add(entity);
            db.SaveChanges();
            return entity.MaNguoiDung;
        }
       

        public bool Update(NguoiDung entity)
        {
            try
            {
                var user = db.NguoiDungs.Find(entity.MaNguoiDung);
                user.UserName = entity.UserName;
                if (!string.IsNullOrEmpty(entity.Pass))
                {
                    user.Pass = entity.Pass;
                }
                user.DiaChi = entity.DiaChi;
                user.SDT = entity.SDT;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //logging
                return false;
            }

        }

        public NguoiDung GetById(string userName)
        {
            return db.NguoiDungs.SingleOrDefault(x => x.UserName == userName);
        }
        public NguoiDung ViewDetail(int id)
        {
            return db.NguoiDungs.Find(id);
        }

        public bool Login(string userName, string passWord)
        {
            var result = db.NguoiDungs.Count(x => x.UserName == userName && x.Pass == passWord);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckUserName(string userName)
        {
            return db.NguoiDungs.Count(x => x.UserName == userName) > 0;
        }
        public bool CheckSDT(string sdt)
        {
            return db.NguoiDungs.Count(x => x.SDT == sdt) > 0;
        }
    }
}