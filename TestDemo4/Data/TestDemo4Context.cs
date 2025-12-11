using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo4.Models;

namespace TestDemo4.Data
{
    internal class TestDemo4Context : DbContext
    {
 
        public DbSet<Person> People { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Emp> Emps { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TestDemo4Db;Trusted_Connection=True;TrustServerCertificate=True;"
);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(p =>
            {
                p.UseTpcMappingStrategy();
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
