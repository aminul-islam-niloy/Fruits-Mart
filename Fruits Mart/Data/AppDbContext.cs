using Fruits_Mart.Models;
using Microsoft.EntityFrameworkCore;

namespace Fruits_Mart.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) { }
       
        public DbSet<Item> Items { get; set; }

    }

}
