using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class StoresContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Store>().HasMany(c => c.Products)
                .WithMany(s => s.Stores)
                .Map(t => t.MapLeftKey("StoreId")
                    .MapRightKey("ProductId")
                    .ToTable("StoreProduct"));
        }
    }
}