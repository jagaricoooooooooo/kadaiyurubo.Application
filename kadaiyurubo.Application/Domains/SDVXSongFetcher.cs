using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kadaiyurubo.Application.Domains.Entities;
using kadaiyurubo.Application.Repositories;

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
