using System.Threading.Tasks;
using kadaiyurubo.Application.Domains.Entities;

namespace kadaiyurubo.Application.Domains
{
    public interface IIIDXSongRepository
    {
        Task<SongResponse> GetSongAsync(SongRequest request);
    }
}
