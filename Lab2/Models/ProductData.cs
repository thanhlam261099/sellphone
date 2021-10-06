using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class ProductData
    {
        public List<ProductModels> ProductList { get; set; }
        public static ProductData initData()
        {
            List<ProductModels> product = new List<ProductModels>();
            product.AddRange(new List<ProductModels>
                {
                new ProductModels()
                {
                    ProductName="Iphone11 ProMax",
                    ProductImage="ip.png",
                    ProductQuantity= 100,
                    ProductPrice=100000.00,
                    Descriptions="Iphone11 ProMax64gb-512gb",
                    CreateDate=DateTime.Now
                  },
               new ProductModels()
                {
                    ProductName="Iphone11 ProMax",
                    ProductImage="ip.png",
                    ProductQuantity= 100,
                    ProductPrice=100000.00,
                    Descriptions="Iphone11 ProMax64gb-512gb",
                    CreateDate=DateTime.Now
                  },
               new ProductModels()
                {
                    ProductName="Iphone11 ProMax",
                    ProductImage="ip.png",
                    ProductQuantity= 100,
                    ProductPrice=100000.00,
                    Descriptions="Iphone11 ProMax64gb-512gb",
                    CreateDate=DateTime.Now
                  },
               new ProductModels()
                {
                    ProductName="Iphone11 ProMax",
                    ProductImage="ip.png",
                    ProductQuantity= 100,
                    ProductPrice=100000.00,
                    Descriptions="Iphone11 ProMax64gb-512gb",
                    CreateDate=DateTime.Now
                  }
            }); ;
            return new ProductData()
            {
                ProductList = product
            };
        }
    }
}
