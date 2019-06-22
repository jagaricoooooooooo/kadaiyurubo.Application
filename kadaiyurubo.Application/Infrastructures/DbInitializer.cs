using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using kadaiyurubo.Application.Domains.Entities;

namespace kadaiyurubo.Application.Infrastructures
{
    public class DbInitializer
    {
        public static async Task InitAsync(DatabaseContext context)
        {
            await context.Database.EnsureCreatedAsync();
            if (await context.IIDXSongs.AnyAsync())
            {
                return;
            }
            await context.IIDXSongs.AddRangeAsync(
                new IIDXSong { Difficulty = 1, Level = 5, Name = "冥", Version = "HAPPYSKY" },
                new IIDXSong { Difficulty = 2, Level = 10, Name = "冥", Version = "HAPPYSKY" },
                new IIDXSong { Difficulty = 3, Level = 12, Name = "冥", Version = "HAPPYSKY" });
            await context.SaveChangesAsync();
        }
    }
}
