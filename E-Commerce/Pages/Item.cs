using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Pages
{
    public class Item
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }
        //public List<Product> Products { get; set; }
    }
}
