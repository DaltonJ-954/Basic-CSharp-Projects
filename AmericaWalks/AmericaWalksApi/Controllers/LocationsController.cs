using AmericaWalksApi.Data;
using AmericaWalksApi.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmericaWalksApi.Controllers
{
    // https://localhost:7189/api/locations
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly AmericaWalksDbContext dbContext;

        public LocationsController(AmericaWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET ALL LOCATIONS
        // https://localhost:portnumber/api/locations
        [HttpGet]
        public IActionResult GetAll()
        {
            var locations =  dbContext.Locations.ToList();

            return Ok(locations);
        }
    }
}
