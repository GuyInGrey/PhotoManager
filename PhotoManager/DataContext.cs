using Microsoft.EntityFrameworkCore;

using PhotoManager.Models;

namespace PhotoManager
{
    public class DataContext : DbContext
    {
        public DbSet<Photo> Photo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) { return; }
            optionsBuilder.UseSqlServer("Server=ARTANIS;Database=PhotoManager;Trusted_Connection=True;", options => { });
        }
    }
}
