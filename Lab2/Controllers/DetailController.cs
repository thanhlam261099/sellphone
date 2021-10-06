using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Lab2.Data;
using Lab2.Models;
using Lab2.Views;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class DetailController : Controller
    {    
        private readonly ProductData productData;
        DataContext dataContext;
        IMapper mapper;
        public DetailController(ProductData productData,DataContext dataContext,IMapper mapper)
        {               
            this.productData = productData;
            this.dataContext = dataContext;
            this.mapper = mapper;
        }
        [HttpGet("Detail/{id}/{name}")]
        public IActionResult Index(int id)
        {
            Product products = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
            ProductModels currentProduct = new ProductModels
            {
                ProductId = products.ProductId,
                ProductName = products.ProductName,
                ProductImage = products.ProductImage,
                Color = products.Color,
                Ram=products.Ram,
                Rom = products.Rom,
                Batterycapacity=products.Batterycapacity,
                ProductPrice = products.ProductPrice,
                ProductQuantity = products.ProductQuantity,
                Descriptions = products.Descriptions
            };
            return View(currentProduct);
        }
    }
}