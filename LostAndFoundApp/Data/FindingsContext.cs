using Microsoft.EntityFrameworkCore;

namespace LostAndFoundApp.Data
{
    public class FindingsContext : DbContext
    {
        public DbSet<Finding> Findings { get; private set; }
        public FindingsContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=LostAndFound.db");
        }
    }
}