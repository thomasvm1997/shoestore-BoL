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

            var random = new Random();
            var shoes = new List<Shoe>();

            var shoeNames = new List<string>
                {
                    "Air Stride", "Ultra Run", "SpeedFlex", "PowerStep", "Enduro",
                    "CloudFlow", "Solar Glide", "Velocity Boost", "Sprint Edge", "TrailBlazer",
                    "HyperRush", "AeroStride", "Thunder Run", "FloatStep", "ZoomDrive",
                    "VaporSwift", "PulseZoom", "AeroCushion", "GripMaster", "Stealth Glide",
                    "LunarStride", "RapidFlex", "Nova Flow", "JumpX", "OmniRun",
                    "Phantom Flex", "TrailMax", "SonicStep", "CrossCharge", "AeroRun",
                    "IgniteWave", "GlideFuel", "UltraLight", "AirVolt", "TerraBoost",
                    "CloudRush", "HyperGrip", "SwiftStrike", "SpeedStorm", "EdgeMax",
                    "AlphaCharge", "MaxPropel", "ZeroGravity", "PowerDash", "AeroSpeed",
                    "ZoomJet", "StormRunner", "GlideWave", "HydroFlow", "PulseStrider"
                };

            for (int i = 1; i <= 50; i++)
            {
                int brandIndex = random.Next(shoeBrands.Count); 
                string brandName = shoeBrands[brandIndex].Name; 
                string shoeName = $"{brandName} {shoeNames[i - 1]}";


                shoes.Add(new Shoe
                {
                    Id = i,
                    Name = shoeName,
                    Description = $"High-quality {brandName} shoe, model {shoeNames[i - 1]}, with excellent comfort.",
                    Price = 49.99m + (i % 10) * 5,
                    Size = 36 + (i % 11),
                    ImageUrl = stockPhotoUrl,
                    ShoeBrandId = brandIndex + 1,
                    ShoeCategoryId = (i % 3) + 1
                });
            }

            modelBuilder.Entity<Shoe>().HasData(shoes);
        }
    }
}
