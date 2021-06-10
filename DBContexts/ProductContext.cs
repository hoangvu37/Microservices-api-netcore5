using Microsoft.EntityFrameworkCore;
using MyMicroservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMicroservice.DBContexts
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { 
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys{ get; set; }

        protected   override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   Id = 1,
                   Name = "Electronics",
                   Desc = "Electronic Items",
               },
              new Category
              {
                  Id = 2,
                  Name = "Clothes",
                  Desc = "Dresses",
              },
              new Category
              {
                  Id = 3,
                  Name = "Grocery",
                  Desc = "Grocery Items",
              }
           );
        }

    }
}
