using System.ComponentModel.DataAnnotations;
using kadaiyurubo.Application.Domains;

namespace kadaiyurubo.Application.Infrastructures
{
    public class SongInfo : Song
    {
        [Key]
        public int Id { get; set; }
    }
}
