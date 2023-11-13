using Hotel.Hotel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace Hotel.Model
{
    public class Photo
    {
        public int Id { get; set; }
        public House? House { get; set; } = new House();
        public int? Hauseid { get; set; }
        public byte[] Image { get; set; }
    }
}
