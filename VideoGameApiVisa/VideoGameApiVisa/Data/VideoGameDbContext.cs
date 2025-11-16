using Microsoft.EntityFrameworkCore;
using VideoGameApiVisa.Entities;

namespace VideoGameApiVisa.Data
{
    public class VideoGameDbContext : DbContext
    {
        public VideoGameDbContext(DbContextOptions<VideoGameDbContext> options) : base(options)
        { 
        }

        public DbSet<VideoGame> VideoGames { get; set; }
    }
}
