using Microsoft.EntityFrameworkCore;

namespace Plonaria.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public object Products { get; internal set; }
        public object Slides { get; internal set; }
    }
}
