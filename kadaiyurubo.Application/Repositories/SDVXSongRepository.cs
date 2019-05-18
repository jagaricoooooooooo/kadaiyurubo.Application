using System.Threading.Tasks;
using kadaiyurubo.Application.Domains;
using kadaiyurubo.Application.Domains.Entities;

namespace kadaiyurubo.Application.Repositories
{
    public class SDVXSongRepository : ISDVXSongRepository
    {
        public async Task<SongResponse> GetSongAsync(SongRequest request)
        {
            return await Task.Run(() =>
            {
                return new SongResponse
                {
                    Level = 1,
                    Name = "test song",
                    Difficulty = "MAXIMUM",
                    Version = "HEAVENLY HAVEN"
                };
            });
        }
    }
}
