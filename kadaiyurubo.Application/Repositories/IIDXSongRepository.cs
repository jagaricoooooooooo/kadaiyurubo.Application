using System.Threading.Tasks;
using kadaiyurubo.Application.Domains;
using kadaiyurubo.Application.Domains.Entities;

namespace kadaiyurubo.Application.Repositories
{
    public class IIDXSongRepository : IIIDXSongRepository
    {
        public async Task<SongResponse> GetSongAsync(SongRequest request)
        {
            return await Task.Run(() =>
            {
                return new SongResponse
                {
                    Level = 12,
                    Name = "冥",
                    Difficulty = "Another",
                    Version = "12 HAPPY SKY"
                };
            });
        }
    }
}
