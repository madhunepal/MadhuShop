using MadhuShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadhuShop.DataLayer
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser> 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {

        }
        public DbSet<Cloth> Clothes { get; set; }
        public DbSet<Category> Catogory { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category           {
                CategoryId =1, CategoryName = "Pant", CategoryDescription="belly bottom pant for male"});
            //modelBuilder.Entity<Cloth>().HasData(new Category
            //{
            //    CategoryId = 2,
            //    CategoryName = "Shirt",
            //    CategoryDescription = "Full sleeve for male"
            //});
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 2,
                CategoryName = "Hat",
                CategoryDescription = "Cow Boy Hat"
            });
            modelBuilder.Entity<Cloth>().HasData(new Cloth
            {
                ClothId = 1,
                Name = "Soft Jeans",
                Price = 45.95,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.",
                CategoryId = 1,
                ImageUrl = "\\images\\jeans",
                ImageThumbNailUrl = "\\Images\\jeans",
                IsOnStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Cloth>().HasData(new Cloth
            {
                ClothId = 2,
                Name = "Cow boy hat",
                Price = 45.95,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.",
                CategoryId = 2,
                ImageUrl = "\\images\\hat",
                ImageThumbNailUrl = "\\Images\\hat",
                IsOnStock = true,
                IsOnSale = false
            });
        }
    }
}
