using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kadaiyurubo.Application.Domains.Entities;

namespace kadaiyurubo.Application.Repositories
{
    public interface ISDVXSongRepository
    {
        Task<SongResponse> GetSongAsync(SongRequest request);
    }
}
