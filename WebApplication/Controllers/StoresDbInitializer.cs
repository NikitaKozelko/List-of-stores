using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class StoresDbInitializer : DropCreateDatabaseAlways<StoresContext>
    {
        protected override void Seed(StoresContext context)
        {
            Product s1 = new Product { Id = 1, Name = "100 First Words", Description = "Book for children" };
            Product s2 = new Product { Id = 2, Name = "A Dance with Dragons", Description = "Book by George R. R. Martin" };
            Product s3 = new Product { Id = 3, Name = "Harry Potter", Description = "Book by J. K. Rowling" };
            Product s4 = new Product { Id = 4, Name = "1408", Description = "Book by Stephen King" };
            Product s5 = new Product { Id = 5, Name = "iPhone X", Description = "New mobile by Apple" };

            context.Products.Add(s1);
            context.Products.Add(s2);
            context.Products.Add(s3);
            context.Products.Add(s4);
            context.Products.Add(s5);

            Store c1 = new Store
            {
                Id = 1,
                Name = "Amazon",
                OpeningHours = "0.00-24.00",
                Address = "New York, St. Yellow-95",
                Products = new List<Product>() { s1, s2, s3}
            };
            Store c2 = new Store
            {
                Id = 2,
                Name = "ThriftBooks",
                OpeningHours = "10.30 - 21.00",
                Address = "New York, St. Louis-123",
                Products = new List<Product>() { s2, s3, s4}
            };
            Store c3 = new Store
            {
                Id = 3,
                Name = "Apple Store",
                OpeningHours = "9.00-22.00",
                Address = " 340 University Ave, Palo Alto",
                Products = new List<Product>() { s5 }
            };

            context.Stores.Add(c1);
            context.Stores.Add(c2);
            context.Stores.Add(c3);

            base.Seed(context);
        }
    }
}