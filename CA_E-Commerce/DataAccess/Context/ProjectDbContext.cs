using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class ProjectDbContext:DbContext
    {

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API
            //modelBuilder.Entity<OrderDetail>().Ignore(x => x.Id);
            //modelBuilder.Entity<OrderDetail>().HasKey(x => new { x.OrderId, x.ProductId });

            //modelBuilder.Entity<Product>().HasAlternateKey(x => new { x.SupplierId, x.CategoryId });




            base.OnModelCreating(modelBuilder);
        }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-5TJ97HC\\SQLEXPRESS;Database=ECommerceDB;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

    }
}
