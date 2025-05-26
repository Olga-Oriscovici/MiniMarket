using Microsoft.EntityFrameworkCore;
using MiniMarket.Models;

namespace MiniMarket.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        

        public DbSet<Product> products { get; set; }
        public DbSet<Order>orders { get; set; }
        public DbSet<Buyer> buyers { get; set; }
        public DbSet<Seller> sellers { get; set; }


    }
}
