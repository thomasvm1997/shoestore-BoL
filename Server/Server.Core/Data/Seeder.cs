using Microsoft.EntityFrameworkCore;
using Server.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core.Data
{
    public class Seeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            var shoeBrands = new List<ShoeBrand>
        {
            new ShoeBrand { Id = 1, Name = "Nike" },
            new ShoeBrand { Id = 2, Name = "Adidas" },
            new ShoeBrand { Id = 3, Name = "Puma" },
            new ShoeBrand { Id = 4, Name = "Reebok" },
            new ShoeBrand { Id = 5, Name = "New Balance" }
        };

            modelBuilder.Entity<ShoeBrand>().HasData(shoeBrands);


            var shoeCategories = new List<ShoeCategory>
        {
            new ShoeCategory { Id = 1, Name = "Running", Description = "Shoes for running and jogging" },
            new ShoeCategory { Id = 2, Name = "Casual", Description = "Everyday wear shoes" },
            new ShoeCategory { Id = 3, Name = "Formal", Description = "Elegant formal shoes" }
        };

            modelBuilder.Entity<ShoeCategory>().HasData(shoeCategories);


            string stockPhotoUrl = "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D";

            var shoes = new List<Shoe>();
            for (int i = 1; i <= 50; i++)
            {
                shoes.Add(new Shoe
                {
                    Id = i,
                    Name = $"Shoe Model {i}",
                    Description = $"High-quality shoe model {i} with excellent comfort.",
                    Price = 49.99m + (i % 10) * 5, 
                    Size = 36 + (i % 11), 
                    ImageUrl = stockPhotoUrl, 
                    ShoeBrandId = (i % 5) + 1, 
                    ShoeCategoryId = (i % 3) + 1 
                });
            }

            modelBuilder.Entity<Shoe>().HasData(shoes);
        }
    }
}
