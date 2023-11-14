using Hotel.Hotel;
using Hotel.Model;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Hotel
{
    public class HotelDbContext:DbContext
    {

        public DbSet<Users> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Photo> Photo { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<House> House { get; set; }
        public DbSet<Customer> Customer { get; set; }

        public HotelDbContext()
                : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
             optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=1111;Database=Hotel;");
        }
    }
}
