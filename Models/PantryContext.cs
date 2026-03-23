using Microsoft.EntityFrameworkCore;

namespace PantryProApi.Models
{
    public class PantryContext : DbContext
    {



        public PantryContext(DbContextOptions<PantryContext> options) : base(options)
        {

        }

        public DbSet<Pantry> Pantries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LargeTextData> LargeTextData { get; set; }

    }
}
