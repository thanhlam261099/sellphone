using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Lab2.Data;
using Lab2.Models;
using Lab2.Views;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class ProductController : Controller
    {
        private readonly ProductData productData;
        private readonly DataContext dataContext;
        private readonly IMapper mapper;

        public ProductController(ProductData productData, DataContext dataContext, IMapper mapper)
        {
            this.productData = productData;
            this.dataContext = dataContext;
            this.mapper = mapper;

        }
        [HttpGet]
        public IActionResult Index()
        {
            List<ProductModels> products = new List<ProductModels>();
            List<Product> productss = dataContext.Products.ToList();
            var valid = dataContext.Products.Include(p => p.Category);
            foreach (var item  in productss)
            {
                var map = mapper.Map<ProductModels>(item);
                products.Add(map);
            }
            return View(products);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ProductModels products = new ProductModels();
            ViewData["CategoryId"] = new SelectList(dataContext.Categories, "CategoryId", "CategoryId");
            return View(products);
        }
        [HttpPost]
        public IActionResult Add(ProductModels productModels, IFormFile photo)
        {
            var valid = dataContext.Products.Include(p => p.Category);
            if (ModelState.IsValid)
            {
                ProductModels newProduct = new ProductModels();
                if (photo == null || photo.Length == 0)
                {
                    newProduct.ProductImage = "abc.png";
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", photo.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    photo.CopyToAsync(stream);
                    newProduct.ProductImage = photo.FileName;
                }
                newProduct.ProductName = productModels.ProductName;
                newProduct.ProductQuantity = productModels.ProductQuantity;
                newProduct.ProductPrice = productModels.ProductPrice;
                newProduct.Descriptions = productModels.Descriptions;
                newProduct.Color = productModels.Color;
                newProduct.Ram = productModels.Ram;
                newProduct.Rom = productModels.Rom;
                newProduct.Batterycapacity = productModels.Batterycapacity;
                newProduct.CreateDate = DateTime.Now;
                newProduct.CategoryId = productModels.CategoryId;
                //productData.ProductList.Add(newProduct);
                Product p = new Product()
                {
                    ProductName = newProduct.ProductName,
                    ProductImage = newProduct.ProductImage,
                    ProductQuantity = newProduct.ProductQuantity,
                    ProductPrice = newProduct.ProductPrice,
                    Descriptions=newProduct.Descriptions,
                    Ram = newProduct.Ram,
                    Rom = newProduct.Rom,
                    Color = newProduct.Color,
                    Batterycapacity = newProduct.Batterycapacity,
                    CreateDate = newProduct.CreateDate,
                    CategoryId = newProduct.CategoryId,
                };
                ViewData["CategoryId"] = new SelectList(dataContext.Categories, "CategoryId", "CategoryId", p.CategoryId);    
                dataContext.Products.Add(p);
                dataContext.SaveChanges();
                return RedirectToAction("Index", "Product");
            }
            else
            {
                return View(productModels);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //ProductModels oldProduct = productData.ProductList.FirstOrDefault(p => p.ProductId == id);
            Product product = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
            ProductModels oldProduct = new ProductModels()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice,
                ProductQuantity = product.ProductQuantity,
                Color = product.Color,
                Ram = product.Ram,
                Rom = product.Rom,
                Batterycapacity = product.Batterycapacity,
                CreateDate = product.CreateDate
            };
            return View(oldProduct);
        }
        [HttpPost]
        public IActionResult Edit(int id, ProductModels productModels)
        {
            if (ModelState.IsValid)
            {
                //ProductModels oldProduct = productData.ProductList.FirstOrDefault(p => p.ProductId == id);
                //oldProduct.ProductName = productModels.ProductName;
                //oldProduct.ProductQuantity = productModels.ProductQuantity;
                //oldProduct.ProductPrice = productModels.ProductPrice;
                //oldProduct.CreateDate = DateTime.Now;
                Product p1 = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
                p1.ProductName = productModels.ProductName;
                p1.ProductPrice = productModels.ProductPrice;
                p1.Descriptions = productModels.Descriptions;
                p1.ProductQuantity = productModels.ProductQuantity;
                p1.Color = productModels.Color;
                p1.Ram = productModels.Ram;
                p1.Rom = productModels.Rom;
                p1.Batterycapacity = productModels.Batterycapacity;
                dataContext.SaveChanges();
                ViewBag.Status = 1;
                return RedirectToAction("Index", "Product");
            }
            else
            {
                return View(productModels);
            }
        }
            
        public IActionResult Delete(int id)
        {
            //ProductModels oldProduct =productData.ProductList.FirstOrDefault(p => p.ProductId == id);           

            Product product = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
            ProductModels oldProduct = new ProductModels()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                ProductQuantity = product.ProductQuantity,
                Descriptions=product.Descriptions,
                ProductPrice = product.ProductPrice

            };
            return View(oldProduct);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            //productData.ProductList.RemoveAll(p => p.ProductId == id);
            Product product = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
            dataContext.Products.Remove(product);
            dataContext.SaveChanges();
            return RedirectToAction("Index", "Product");
        }
    }
}
