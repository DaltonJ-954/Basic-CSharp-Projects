using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace eBookShop.Models.Domain
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base (options)
        {
            
        }

        public DbSet<Genre> Genre { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
