using E_Commerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Data
{
    public class ECommerceDbContext : IdentityDbContext  //we used IdentityUser before
    {
        public ECommerceDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Product { get; set; }
        //public DbSet<AdminIndexViewModel> AdminIndexViewModels { get; set; }

        protected override void OnModelCreating ( ModelBuilder builder )
        {
            base.OnModelCreating(builder);
            SeedRole(builder, "Administrator");
            SeedRole(builder, "Editor");
            SeedRole(builder, "Site Owner");
        }
        private void SeedRole(ModelBuilder builder, string roleName)
        {
            var role = new IdentityRole
            {
                Id = roleName,
                Name = roleName,
                NormalizedName = roleName.ToUpper(),
                ConcurrencyStamp = Guid.Empty.ToString(),
            };
            builder.Entity<IdentityRole>().HasData(role);
        }
    }
}
