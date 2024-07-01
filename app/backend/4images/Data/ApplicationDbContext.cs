using Microsoft.EntityFrameworkCore;
using _4images.Models;

namespace _4images.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Download> Downloads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }
    }
}
