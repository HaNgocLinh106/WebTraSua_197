using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTraSua_197.Common;
using WebTraSua_197.Models.EF;
using WebTraSua_197.Models.Fun;
using WebTraSua_197.Models.User;


namespace WebTraSua_197.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserF();
                var result = dao.Login(model.UserName, model.Pass);
                if (result)
                {
                    var user = dao.GetById(model.UserName);
                    var userSession = new UserLogin();
                    /// userSession.UserName = user.UserName;
                    userSession.UserName = "admin";
                    userSession.MaNguoiDung = user.MaNguoiDung;

                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    // return RedirectToAction("Index", "Home");
                    return Redirect("/Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không thành công.");
                }
            }
            return View("Login");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserF();
                if (dao.CheckUserName(model.UserName))
                {
                    ModelState.AddModelError("", "Tên đăng nhập đã tồn tại");
                }
                else if (dao.CheckSDT(model.SDT))
                {
                    ModelState.AddModelError("", "Số điện thoại đã tồn tại");
                }
                else
                {
                    var user = new NguoiDung();
                    user.TenNguoiDung = model.TenNguoiDung;
                    user.UserName = model.UserName;
                    user.Pass = model.Pass;
                    user.DiaChi = model.DiaChi;
                    user.SDT = model.SDT;
                    var result = dao.Insert(user);
                    if (result > 0)
                    {
                        ViewBag.Success = "Đăng ký thành công";
                        model = new RegisterModel();
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng ký không thành công");
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult PhanHoi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PhanHoi(PhanHoiModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new PhanHoiF();
                var ph = new PhanHoi();
                ph.TenNguoiPhanHoi = model.TenNguoiDung;

                ph.NoiDung = model.NoiDung;
                ph.NgayPhanHoi = DateTime.Now;

                var result = dao.InsertPH(ph);
                if (result > 0)
                {
                    ViewBag.Success = "Gửi phản hồi thành công";
                    model = new PhanHoiModel();
                }
                else
                {
                    ModelState.AddModelError("", "Gửi phản hồi không thành công");
                }
            }
            return View(model);
        }
         public ActionResult TaiKhoan()
        {
            var model = new UserF().GHUser();
            return View(model);
        }
        public ActionResult Logout()
        {
            Session[CommonConstants.USER_SESSION] = null;

            return RedirectToAction("Index", "Home");
        }
    }
}