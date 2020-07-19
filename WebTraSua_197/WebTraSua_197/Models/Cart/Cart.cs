using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTraSua_197.Models.EF;

namespace WebTraSua_197.Models.Cart
{
    [Serializable]
    public class CartItem
    {
        public SanPham SanPham { get; set; }
        public string Size { set; get; }
        public int Quantity { set; get; }
        public string Duong { set; get; }
        public string Da { set; get; }
        public string Topping { set; get; }

    }
    public class Cart
    {
        private List<CartItem> lineCollection = new List<CartItem>();

        public void AddItem(SanPham sp, int quantity, string duong, string da, string topping, string size)
        {
            CartItem line = lineCollection
                .Where(p => p.SanPham.MaSanPham == sp.MaSanPham)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartItem
                {
                    SanPham = sp,
                    Quantity = quantity,
                    Duong = duong,
                    Da = da,
                    Topping = topping,
                    Size = size

                });
            }
            else
            {
                line.Quantity += quantity;
                if (line.Quantity <= 0)
                {
                    lineCollection.RemoveAll(l => l.SanPham.MaSanPham == sp.MaSanPham);
                }
            }
        }

        public void UpdateItem(SanPham sp, int quantity)
        {
            CartItem line = lineCollection
                .Where(p => p.SanPham.MaSanPham == sp.MaSanPham)
                .FirstOrDefault();

            if (line != null)
            {
                if (quantity > 0)
                {
                    line.Quantity = quantity;
                }
                else
                {
                    lineCollection.RemoveAll(l => l.SanPham.MaSanPham == sp.MaSanPham);
                }
            }
        }

        public void RemoveLine(SanPham sp)
        {
            lineCollection.RemoveAll(l => l.SanPham.MaSanPham == sp.MaSanPham);
        }

        public int? ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.SanPham.DonGia * e.Quantity);

        }
        public int? ComputeTotalProduct()
        {
            return lineCollection.Sum(e => e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartItem> Lines
        {
            get { return lineCollection; }
        }
    }
}