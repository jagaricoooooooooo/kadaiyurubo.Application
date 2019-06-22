using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
                new IIDXSongDbModel { Difficulty = 1, Level = 5, Name = "冥", Version = "HAPPYSKY" },
                new IIDXSongDbModel { Difficulty = 2, Level = 10, Name = "冥", Version = "HAPPYSKY" },
                new IIDXSongDbModel { Difficulty = 3, Level = 12, Name = "冥", Version = "HAPPYSKY" });
            await context.SaveChangesAsync();
        }
    }
}
