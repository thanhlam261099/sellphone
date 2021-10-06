using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab2.Data;
using Lab2.Helper;
using Lab2.Models;
using Lab2.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Controllers
{
    public class CartController : Controller
    {
        private readonly DataContext dataContext;
        [BindProperty]
        public ProductToCart ProductToCart { get; set; }
        public CartController(DataContext dataContext)
        {
            this.dataContext = dataContext;
            ProductToCart = new ProductToCart()
            {
                products = new List<Views.Product>()
            };
        }
        public async Task<IActionResult> Index()
        {
            List<int> listShop = HttpContext.Session.Get<List<int>>("ShoppingCart");
            if (listShop.Count > 0)
            {
                foreach (int cartitem in listShop)
                {
                    Product product = dataContext.Products.Include(p => p.Category).Where(p => p.ProductId == cartitem).FirstOrDefault();
                    ProductToCart.products.Add(product);
                }
            }
            return View(ProductToCart);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Index")]
        public async Task<IActionResult> IndexPost()
        {
            if (ModelState.IsValid)
            {
                List<int> listCartItem = HttpContext.Session.Get<List<int>>("ShoppingCart");
                ProductToCart.order.OrderDate = ProductToCart.order.OrderDate;
                Order order = ProductToCart.order;
                order.OrderDate = DateTime.Now;
                dataContext.Orders.Add(order);
                await dataContext.SaveChangesAsync();

                int orderId = order.OrderId;
                foreach (int productId in listCartItem)
                {
                    try
                    {
                        //var total = SSShoppingCartVM.Products.Where(a=>a.Id==productId).Sum(c => c.Price);
                        OrderDetail detailsOrder = new OrderDetail()
                        {
                            OrderId = orderId,
                            ProductId = productId,
                            //Total = SSShoppingCartVM.Products.Sum(a => a.Price)
                        };
                        dataContext.OrderDetails.Add(detailsOrder);
                    }
                    catch (Exception ex)
                    {
                    }

                }
                await dataContext.SaveChangesAsync();
                listCartItem = new List<int>();
                HttpContext.Session.Set("ShoppingCart", listCartItem);
                return RedirectToAction("Checkout", "Cart", new { Id = orderId });
            }
            return RedirectToAction("Index");
        }
        public IActionResult Buy(int id)
        {
            List<int> listShop = HttpContext.Session.Get<List<int>>("ShoppingCart");
            if (listShop == null)
            {
                listShop = new List<int>();
            }
            listShop.Add(id);
            HttpContext.Session.Set("ShoppingCart", listShop);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Remove(int id)
        {
            List<int> listShop = HttpContext.Session.Get<List<int>>("ShoppingCart");
            if (listShop.Count > 0)
            {
                if (listShop.Contains(id))
                {
                    listShop.Remove(id);
                }
            }
            HttpContext.Session.Set("ShoppingCart", listShop);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Checkout(int id)
        {
            return View();
        }
    }
}
