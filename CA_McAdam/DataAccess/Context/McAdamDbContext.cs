using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class McAdamDbContext : DbContext
    {
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(x => x.ProductName).HasMaxLength(100);
            modelBuilder.Entity<Product>().Property(x => x.ProductName).IsRequired(true);

            modelBuilder.Entity<Category>().Property(x => x.CategoryName).HasMaxLength(50);
            modelBuilder.Entity<Category>().Property(x => x.CategoryName).IsRequired(true);

            modelBuilder.Entity<Employee>().Property(x => x.FirstName).HasMaxLength(50);
            modelBuilder.Entity<Employee>().Property(x => x.LastName).HasMaxLength(50);
            modelBuilder.Entity<Employee>().Property(x => x.Phone).HasMaxLength(11);
            modelBuilder.Entity<Employee>().Property(x => x.FirstName).IsRequired(true);
            modelBuilder.Entity<Employee>().Property(x => x.LastName).IsRequired(true);

            modelBuilder.Entity<Customer>().Property(x => x.FirstName).HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(x => x.LastName).HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(x => x.FirstName).IsRequired(true);
            modelBuilder.Entity<Customer>().Property(x => x.LastName).IsRequired(true);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-5TJ97HC\\SQLEXPRESS;database=McAdamDb;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }





    }
}
