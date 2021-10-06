using System;

using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab2.Models;
using Lab2.Data;
using AutoMapper;
using System.Collections.Generic;
using Lab2.Views;

namespace Lab2.Controllers
{
    public class HomeController : Controller
    {
         ProductData data;
         DataContext dataContext;
        IMapper mapper;


        public HomeController(ProductData productData, DataContext dataContext,IMapper mapper)
        {

            this.data = productData;
            this.dataContext = dataContext;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {

            List<ProductModels> products = new List<ProductModels>();
            List<Product> productss = dataContext.Products.ToList();
            foreach ( var item in productss)
            {
                var map = mapper.Map<ProductModels>(item);
                products.Add(map);
            }
            return View(products);
        }
        public IActionResult Iphone()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 1).ToList());
        }
        public IActionResult SamSung()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 2).ToList());
        }
        public IActionResult Oppo()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 3).ToList());
        }
        public IActionResult Xiaomi()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 4).ToList());
        }
        public IActionResult Search(string search)
        {
            var item = dataContext.Products.Where(p => p.ProductName.ToLower().Contains(search.ToLower())).ToList();
            return View(item);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
