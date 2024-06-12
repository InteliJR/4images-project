using Microsoft.EntityFrameworkCore;
using _4images.Models;

namespace _4images.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Curtida> Curtidas { get; set; }
    }
}
