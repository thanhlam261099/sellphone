using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class ProductModels
    {
        public int ProductId { get; set; }
        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Not null")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string ProductName { get; set; }
        [Required]
        [Range(0, 100)]
        [DisplayName("Quantity")]
        public int ProductQuantity { get; set; }
        [DisplayName("Image")]
        public string ProductImage { get; set; }
        [DisplayName("Description")]
        public string Descriptions { get; set; }
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [DisplayName("Color")]
        public string Color { get; set; }
        [DisplayName("Ram")]
        public string Ram { get; set; }
        [DisplayName("Rom")]
        public string Rom { get; set; }
        [DisplayName("Batterycapacity")]
        public string Batterycapacity { get; set; }
        
        [Required]
        [Range(0, 999.99)]
        [DisplayName("Price")]
        public double ProductPrice { get; set; }
        [DisplayName("Create on")]
        public DateTime CreateDate { get; set; }      
        private static int nextId = 1;
        public ProductModels()
        {
            ProductId = nextId;
            nextId++;
        }
        public override int GetHashCode()
        {
            return ProductId;
        }
    }
}
