using kadaiyurubo.Application.Domains.Entities;
using Microsoft.EntityFrameworkCore;

namespace kadaiyurubo.Application.Infrastructures
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
             : base(options) { }

        public DbSet<IIDXSong> IIDXSongs { get; set; }
        public DbSet<SDVXSong> SDVXSongs { get; set; }
    }
}
