using System.ComponentModel.DataAnnotations;
using kadaiyurubo.Application.Domains.Entities;

namespace kadaiyurubo.Application.Infrastructures
{
    public class IIDXSongDbModel : IIDXSong
    {
        [Key]
        public int Id { get; set; }
    }
}
