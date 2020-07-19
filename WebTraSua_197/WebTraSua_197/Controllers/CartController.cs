using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTraSua_197.Models.Cart;
using WebTraSua_197.Models.Fun;

namespace WebTraSua_197.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart

        private const string CartSession = "CartSession";

        public ActionResult Index()
        {
            var cart = (Cart)Session[CartSession];

            var list = new List<CartItem>();

            if (cart != null)
            {
                list = cart.Lines.ToList();
                ViewBag.TongTien = cart.ComputeTotalValue();
            }

            return View(list);
        }



        public ActionResult AddItem(long Id, string returnURL)
        {

            var product = new SanPhamF().FindEntity(Id);
            var cart = (Cart)Session[CartSession];

            var duong = Request.Form["duong"];
            Console.WriteLine(duong);

            var da = Request.Form["da"];
            Console.WriteLine(da);

            var topping = Request.Form["topping"];
            Console.WriteLine(topping);

            var size = Request.Form["size"];
            Console.WriteLine(size);

            if (cart != null)
            {
                cart.AddItem(product, 1, duong, da, topping, size);
                //Gán vào session
                Session[CartSession] = cart;
            }
            else
            {
                //tạo mới đối tượng cart item
                cart = new Cart();
                cart.AddItem(product, 1, duong, da, topping, size);
                //Gán vào session
                Session[CartSession] = cart;
            }

            if (string.IsNullOrEmpty(returnURL))
            {
                return RedirectToAction("Index");
            }

            return Redirect(returnURL);

        }
        public ActionResult UpdateCart(long Id, FormCollection fr)
        {

            var product = new SanPhamF().FindEntity(Id);

            var cart = (Cart)Session[CartSession];

            var duong = Request.Form["duong"];
            Console.WriteLine(duong);

            var da = Request.Form["da"];
            Console.WriteLine(da);

            var topping = Request.Form["topping"];
            Console.WriteLine(topping);

            var size = Request.Form["size"];
            Console.WriteLine(size);

            if (cart != null)
            {
                int NewQuantity = int.Parse(fr["txtQuantity"].ToString());
                cart.UpdateItem(product, NewQuantity);
                //Gán vào session
                Session[CartSession] = cart;
            }
            else
            {
                //tạo mới đối tượng cart item
                cart = new Cart();
                cart.AddItem(product, 1, duong, da, topping, size);
                //Gán vào session
                Session[CartSession] = cart;
            }
            return RedirectToAction("Index");

        }

        // GET: /Cart/Details/5
        public ActionResult RemoveLine(long Id)
        {

            var product = new SanPhamF().FindEntity(Id);

            var cart = (Cart)Session[CartSession];

            if (cart != null)
            {
                cart.RemoveLine(product);
                //Gán vào session
                Session[CartSession] = cart;
            }
            return RedirectToAction("Index");
        }
        public ActionResult Clear()
        {
            var cart = (Cart)Session[CartSession];
            cart.Clear();
            Session[CartSession] = cart;
            return RedirectToAction("Index");
        }
    }
}