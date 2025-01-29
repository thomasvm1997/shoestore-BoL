using Microsoft.EntityFrameworkCore;
using Server.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ShoeCategory> Categories {get; set;}
        public DbSet<ShoeBrand> Brands {get; set;}
        public DbSet<Shoe> Shoes {get; set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
            Seeder.Seed(modelBuilder);
        }
    }
}
