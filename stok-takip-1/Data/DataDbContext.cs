using Microsoft.EntityFrameworkCore;
using stok_takip_1.Entites;
using System.Collections.Generic;

namespace stok_takip_1.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<Categories> Categories { get; set; }

        public DbSet<Orders> Orders{ get; set; }

        public DbSet<Product_Brands> Product_Brands{ get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Suppliers> Suppliers { get; set; }


    }
}
