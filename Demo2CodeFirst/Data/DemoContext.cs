using Demo2CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2CodeFirst.Data
{
    internal class DemoContext : DbContext
    {

        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourseRel> StudentCourseRel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Demo2CodeFirst;Trusted_Connection=True;" +
                "TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourseRel>()
                .HasKey(scr => new { scr.StdId, scr.CrsId }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
