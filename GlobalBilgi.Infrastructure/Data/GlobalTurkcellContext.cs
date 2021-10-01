using GlobalBilgi.Core.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalBilgi.Infrastructure.Data
{
    public class GlobalTurkcellContext : DbContext
    {

        public GlobalTurkcellContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
      new Product
      {
          ProductName = "IPhone",
          UnitPrice = 2000,
          UnitsInStock = 5
      }
  );
        }

        public DbSet<Product> Products { get; set; }

    }
}
