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
                new IIDXSongs { Id = 1, Difficulty = 1, Level = 5, Name = "冥", Version = "HAPPYSKY" },
                new IIDXSongs { Id = 2, Difficulty = 2, Level = 10, Name = "冥", Version = "HAPPYSKY" },
                new IIDXSongs { Id = 3, Difficulty = 3, Level = 12, Name = "冥", Version = "HAPPYSKY" });
            await context.SaveChangesAsync();
        }
    }
}
