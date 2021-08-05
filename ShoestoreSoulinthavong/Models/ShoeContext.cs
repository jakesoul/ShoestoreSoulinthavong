using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoestoreSoulinthavong.Models
{
    public class ShoeContext : DbContext
    {
        public ShoeContext(DbContextOptions<ShoeContext> options) : base(options) { }

        public DbSet<Shoe> Shoes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shoe>().HasData(
                new Shoe
                {
                    ShoeId = 1,
                    Brand = "Adidas",
                    Style = "Sneaker",
                    Gender = "Men",
                    Color = "Black",
                    Size = 9.5,
                    RetailPrice = 180.00
                },
                new Shoe
                {
                    ShoeId = 2,
                    Brand = "Nike",
                    Style = "Sneaker",
                    Gender = "Women",
                    Color = "Grey",
                    Size = 6.5,
                    RetailPrice = 90.00
                },
                new Shoe
                {
                    ShoeId = 3,
                    Brand = "Converse",
                    Style = "Sneaker",
                    Gender = "Unisex",
                    Color = "White",
                    Size = 8.0,
                    RetailPrice = 44.99
                },
                new Shoe
                {
                    ShoeId = 4,
                    Brand = "Birkenstocks",
                    Style = "Sandal",
                    Gender = "Unisex",
                    Color = "Nude",
                    Size = 9.0,
                    RetailPrice = 99.95
                },
                new Shoe
                {
                    ShoeId = 5,
                    Brand = "Teva",
                    Style = "Sandal",
                    Gender = "Unisex",
                    Color = "Black",
                    Size = 5.0,
                    RetailPrice = 49.95
                },
                new Shoe
                {
                    ShoeId = 6,
                    Brand = "Timberland",
                    Style = "Boot",
                    Gender = "Men",
                    Color = "Yellow",
                    Size = 8.0,
                    RetailPrice = 165.99
                },
                new Shoe
                {
                    ShoeId = 7,
                    Brand = "Uggs",
                    Style = "Boot",
                    Gender = "Women",
                    Color = "Chestnut",
                    Size = 5.0,
                    RetailPrice = 205.99
                }
            );
        }
    }
}
