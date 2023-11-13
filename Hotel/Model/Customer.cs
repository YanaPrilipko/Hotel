using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Telefon { get; set; }

    }
}
