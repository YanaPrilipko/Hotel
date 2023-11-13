using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
