using Lab2.Models.Domain;
using Lab2.Views;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext>
options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        //public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder
        builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().HasData(
            new Category()
            {
                CategoryId = 1,
                CategoryName = "Iphone"
            },
            new Category()
            {
                CategoryId = 2,
                CategoryName = "SamSung"
            },
             new Category()
             {
                 CategoryId = 3,
                 CategoryName = "Oppo"
             },
             new Category()
             {
                 CategoryId = 4,
                 CategoryName = "Xiaomi"
             });
            builder.Entity<Product>().HasData(
            new Product()
            {
                ProductId = 1,
                ProductName = "IphoneX",
                ProductImage = "ip.png",
                Color = "Black",
                Ram = "3GB",
                Batterycapacity = "2716 mAh",
                Rom = "64GB",
                Descriptions = "iphoneX 256GB",
                ProductQuantity = 100,
                ProductPrice = 500.00,
                CreateDate = DateTime.Now,
                CategoryId = 1
            },
           new Product()
           {
               ProductId = 2,
               ProductName = "Iphone 8 Plus",
               ProductImage = "ip.png",
               Color = "Gold",
               Ram = "3 GB",
               Batterycapacity = "2691 mAh",
               Rom = "64GB",
               Descriptions = "iphone8+ 64GB",
               ProductQuantity = 90,
               ProductPrice = 200.00,
               CreateDate = DateTime.Now,
               CategoryId = 1
           },
           new Product()
           {
               ProductId = 3,
               ProductName = "Iphone 11 ProMax",
               ProductImage = "ip.png",
               Color = "Black",
               Ram = "4 GB",
               Batterycapacity = "3.969 mAh",
               Rom = "64GB",
               Descriptions = "iphone11 ProMax 512GB",
               ProductQuantity = 26,
               ProductPrice = 700.00,
               CreateDate = DateTime.Now,
               CategoryId = 1
           },
             new Product()
             {
                 ProductId = 8,
                 ProductName = "XiaoMi Black Shark3",
                 ProductImage = "ip.png",
                 Color = "Black",
                 Ram = "8GB",
                 Rom = "64GB",
                 Batterycapacity = "4720 mAh",
                 
                 Descriptions = "Xiaomi Black Shark3-128GB ",
                 ProductQuantity = 22,
                 ProductPrice = 600.00,
                 CreateDate = DateTime.Now,
                 CategoryId = 4
             });
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Visitor",
                    NormalizedName = "VISITOR"
                },
                new IdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                });
        }
    }
}

