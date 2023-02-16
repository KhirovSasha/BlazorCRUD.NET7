using BlazorCRUD.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.Server.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BlazorCRUD;Trusted_Connection=True;");
        }
    }
}
