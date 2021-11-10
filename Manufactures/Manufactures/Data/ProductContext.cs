using Manufactures.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Manufactures.Data
{
    public class ProductContext:DbContext
    {
        public ProductContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.; Integrated Security=true; Database=AutoDb");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<Models.Model> Models { get; set; }      
    }
}
