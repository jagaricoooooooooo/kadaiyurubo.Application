using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kadaiyurubo.Application.Domains.Entities;
using kadaiyurubo.Application.Domains;

namespace kadaiyurubo.Application.Controllers
{
    [Route("/v1/[controller]/[action]")]
    [ApiController]
    public class SDVXController : Controller
    {
        private readonly ISDVXSongFetcher _SDVXSongFetcher;

        public SDVXController(ISDVXSongFetcher SDVXSongFetcher)
        {
            _SDVXSongFetcher = SDVXSongFetcher;
        }

        [HttpGet]
        public async Task<SongResponse> Kadai([FromQuery]SongRequest request)
        {
            var response = await _SDVXSongFetcher.FetchSongAsync(request);

            return response;
        }
    }
}
