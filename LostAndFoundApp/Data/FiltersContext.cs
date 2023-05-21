using Microsoft.EntityFrameworkCore;

namespace LostAndFoundApp.Data
{
    public class FiltersContext : DbContext
    {
        public DbSet<Filter> Filters { get; private set; }
        public FiltersContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=LostAndFoundFilters.db");
        }
    }
}
