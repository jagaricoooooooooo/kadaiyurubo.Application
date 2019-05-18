using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kadaiyurubo.Application.Domains;
using kadaiyurubo.Application.Domains.Entities;

namespace kadaiyurubo.Application.Controllers
{
    [Route("/v1/[controller]/[action]")]
    [ApiController]
    public class IIDXController : Controller
    {
        private readonly IIIDXSongFetcher _IIDXSongFetcher;

        public IIDXController(IIIDXSongFetcher IIDXSongFetcher)
        {
            _IIDXSongFetcher = IIDXSongFetcher;
        }

        [HttpGet]
        public async Task<SongResponse> Kadai([FromQuery]SongRequest request)
        {
            var response = await _IIDXSongFetcher.FetchSongAsync(request);

            return response;
        }
    }
}