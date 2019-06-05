using Microsoft.EntityFrameworkCore;

namespace kadaiyurubo.Application.Infrastructures
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
             : base(options) { }

        public DbSet<IIDXSongs> IIDXSongs { get; set; }
        public DbSet<SDVXSongs> SDVXSongs { get; set; }
    }
}
