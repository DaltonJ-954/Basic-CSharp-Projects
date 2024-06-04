using Microsoft.EntityFrameworkCore;

namespace eBookShop.Models.Domain
{
    public class DatabaseContext : DbContext
    {
        internal object Publishers;

        public DatabaseContext(DbContextOptions<DatabaseContext> options):base (options)
        {
            
        }

        public DbSet<Genre> Genre { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
