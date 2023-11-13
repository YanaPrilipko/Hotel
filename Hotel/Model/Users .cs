using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Model
{

    public class Users
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public Role? Role { get; set; } = new Role();

        public int? RoleId { get; set; }
    }
}
