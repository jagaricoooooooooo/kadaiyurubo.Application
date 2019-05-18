using System.Threading.Tasks;
using kadaiyurubo.Application.Domains.Entities;

namespace kadaiyurubo.Application.Domains
{
    public class IIDXSongFetcher : IIIDXSongFetcher
    {
        private readonly IIIDXSongRepository _IIDXSongRepository;

        public IIDXSongFetcher(IIIDXSongRepository IIDXSongRepository)
        {
            _IIDXSongRepository = IIDXSongRepository;
        }

        public async Task<SongResponse> FetchSongAsync(SongRequest request)
        {
            var response = await _IIDXSongRepository.GetSongAsync(request);

            return response;
        }
    }
}
