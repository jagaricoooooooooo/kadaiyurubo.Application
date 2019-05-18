using System.Threading.Tasks;
using kadaiyurubo.Application.Domains.Entities;

namespace kadaiyurubo.Application.Domains
{
    public interface IIIDXSongFetcher
    {
        Task<SongResponse> FetchSongAsync(SongRequest request);
    }
}
