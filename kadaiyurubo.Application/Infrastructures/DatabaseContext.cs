using Microsoft.EntityFrameworkCore;

namespace kadaiyurubo.Application.Infrastructures
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
             : base(options) { }

        public DbSet<IIDXSongDbModel> IIDXSongs { get; set; }
        public DbSet<SDVXSongDbModel> SDVXSongs { get; set; }
    }
}
