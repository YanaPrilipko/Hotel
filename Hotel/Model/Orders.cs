using Hotel.Hotel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Model
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime DataOfArrival { get; set; }
        public DateTime DataOfDeparture { get; set; }
        public House? House { get; set; } = new House();
        public int? Hauseid { get; set; }
        public Customer? Customer { get; set; } = new Customer();
        public int? CustomerId { get; set; }
        public string Description { get; set; }

    }
}
