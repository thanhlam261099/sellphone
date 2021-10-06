using Lab2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class ProductToCart
    {
        public List<Product> products { get; set; }
        public Order order { get; set; }
    }
}
