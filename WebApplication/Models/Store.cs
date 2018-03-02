using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string OpeningHours { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public Store()
        {
            Products = new List<Product>();
        }
    }
}