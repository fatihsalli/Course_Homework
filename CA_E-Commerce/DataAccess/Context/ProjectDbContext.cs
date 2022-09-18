using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class ProjectDbContext : DbContext
    {

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API Yöntemi
            modelBuilder.Entity<OrderDetail>().Ignore(x => x.Id);
            modelBuilder.Entity<OrderDetail>().HasKey(x => new { x.OrderId, x.ProductId });

            //Özellikler kontrol
            modelBuilder.Entity<Supplier>().Property(x=> x.CompanyName).IsRequired(true);
            modelBuilder.Entity<Supplier>().Property(x => x.CompanyName).HasMaxLength(250);

            modelBuilder.Entity<Product>().Property(x => x.ProductName).IsRequired(true);
            modelBuilder.Entity<Product>().Property(x => x.ProductName).HasMaxLength(50);

            modelBuilder.Entity<Category>().Property(x => x.CategoryName).IsRequired(true);
            modelBuilder.Entity<Category>().Property(x => x.CategoryName).HasMaxLength(50);

            modelBuilder.Entity<Customer>().Property(x => x.Firstname).IsRequired(true);
            modelBuilder.Entity<Customer>().Property(x => x.Firstname).HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(x => x.Lastname).IsRequired(true);
            modelBuilder.Entity<Customer>().Property(x => x.Lastname).HasMaxLength(50);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-5TJ97HC\\SQLEXPRESS;Database=ECommerce;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

    }
}
