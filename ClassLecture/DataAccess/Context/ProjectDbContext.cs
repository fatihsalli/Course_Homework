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
        public DbSet<Student> Students { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property(x => x.FirstName).IsRequired(true);
            modelBuilder.Entity<Student>().Property(x => x.FirstName).HasMaxLength(50);
            modelBuilder.Entity<Student>().Property(x => x.Lastname).IsRequired(true);
            modelBuilder.Entity<Student>().Property(x => x.Lastname).HasMaxLength(50);

            modelBuilder.Entity<Topic>().Property(x => x.TopicName).IsRequired(true);
            modelBuilder.Entity<Topic>().Property(x => x.TopicName).HasMaxLength(250);

            modelBuilder.Entity<Student>().Property(x => x.LectureDate).IsRequired(false);
            modelBuilder.Entity<Student>().Property(x => x.IsLecture).IsRequired(false);


            base.OnModelCreating(modelBuilder);
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-5TJ97HC\\SQLEXPRESS;Database=ClassLectureDb;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

    }
}
