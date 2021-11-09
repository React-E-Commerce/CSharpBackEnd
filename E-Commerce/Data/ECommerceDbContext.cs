﻿using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Data
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<E_Commerce.Models.Product> Product { get; set; }
    }
}