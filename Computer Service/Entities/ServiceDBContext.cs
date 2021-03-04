using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computer_Service.Entities
{
    public class ServiceDBContext : DbContext
    {
        private string _connectionString = "Server=DESKTOP-BKPI32S\\SQLEXPRESS;Database=ComputerServiceDB;Trusted_Connection=True;";
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(o => o.Description)
                .IsRequired();

            modelBuilder.Entity<Order>()
                .Property(o => o.Model)
                .IsRequired();

         
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
