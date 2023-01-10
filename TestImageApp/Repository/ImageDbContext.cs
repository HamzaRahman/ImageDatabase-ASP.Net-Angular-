using Microsoft.EntityFrameworkCore;
using TestImageApp.Models;

namespace TestImageApp.Repository
{
    public class ImageDbContext:DbContext
    {
        public ImageDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ImageDatabase;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public DbSet<Image> Images { get; set; }
    }
}
