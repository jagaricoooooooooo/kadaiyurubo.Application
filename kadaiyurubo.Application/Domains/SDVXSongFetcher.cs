using System.Threading.Tasks;
using kadaiyurubo.Application.Repositories;
using kadaiyurubo.Application.Domains.Entities;

namespace kadaiyurubo.Application.Domains
{
    public class SDVXSongFetcher : ISDVXSongFetcher
    {
        private readonly ISDVXSongRepository _SDVXSongRepository;

        public SDVXSongFetcher(ISDVXSongRepository SDVXSongRepository)
        {
            _SDVXSongRepository = SDVXSongRepository;
        }

        public async Task<SongResponse> FetchSongAsync(SongRequest request)
        {
            var response = await _SDVXSongRepository.GetSongAsync(request);

            return response;
        }
    }
}
