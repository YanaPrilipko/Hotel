using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly ILogger<HotelController> _logger;
        private readonly HotelDbContext _libraryContext;

        public HotelController(HotelDbContext libraryContext, ILogger<HotelDbContext> logger)
        {
            //_logger = logger;
            _libraryContext = libraryContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
        {
            return Ok(new
            {
                ñustomer = _libraryContext.Customer.ToArray(),
                users = _libraryContext.Users.ToArray(),
                role = _libraryContext.Role.ToArray(),
                orders = _libraryContext.Orders.ToArray(),
                house = _libraryContext.House.ToArray(),
                photo = _libraryContext.Photo.ToArray(),
            });
        }
    }
}
