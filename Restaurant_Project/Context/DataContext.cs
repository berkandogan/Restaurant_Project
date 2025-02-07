using Microsoft.EntityFrameworkCore;
using Restaurant_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Project.Context
{
    internal class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-G4FMHV0\\SQLEXPRESS01;Database=RestaurantDB;Integrated Security = true;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuFood>()
                .HasKey(mf => new { mf.MenuId, mf.FoodId });

            modelBuilder.Entity<OrderFood>()
                .HasKey(of => new { of.OrderId, of.FoodId });

            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Order)
                .WithOne(o => o.Payment)
                .HasForeignKey<Payment>(p => p.OrderId);
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<MenuFood> MenuFoods { get; set; }
        public DbSet<OrderFood> OrderFoods { get; set; }
    }
}
