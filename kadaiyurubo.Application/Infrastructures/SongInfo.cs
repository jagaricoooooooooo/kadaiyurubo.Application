using System.ComponentModel.DataAnnotations;

namespace kadaiyurubo.Application.Infrastructures
{
    public class SongInfo
    {
        [Key]
        public int Id { get; set; }
        public int Difficulty { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
    }
}
