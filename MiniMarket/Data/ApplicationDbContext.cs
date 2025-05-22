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
    }
}
