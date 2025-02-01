using AmericaWalksApi.Data;
using AmericaWalksApi.Models.Domain;
using AmericaWalksApi.Models.DTO;
using AmericaWalksApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmericaWalksApi.Controllers
{
    // https://localhost:7189/api/locations
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly AmericaWalksDbContext dbContext;
        private readonly ILocationRepository locationRepository;

        public LocationsController(AmericaWalksDbContext dbContext, ILocationRepository locationRepository)
        {
            this.dbContext = dbContext;
            this.locationRepository = locationRepository;
        }

        // GET ALL LOCATIONS
        // GET: https://localhost:portnumber/api/locations
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get Data From Database - Domain models
            var locationsDomain = await locationRepository.GetAllAsync();

            //Map Domain Models to DTOs
            var locationsDto = new List<LocationDto>();
            foreach (var locationDomain in locationsDomain)
            {
                locationsDto.Add(new LocationDto()
                {
                    Id = locationDomain.Id,
                    Code = locationDomain.Code,
                    WalkLocation = locationDomain.WalkLocation,
                    LocationImageUrl = locationDomain.LocationImageUrl,
                });
            }

            // Return DTOs
            return Ok(locationsDto);
        }


        // GET SINGLE LOCATION (Get Location By ID)
        // GET: https://localhost:portnumber/api/locations/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            // var location = dbContext.Locations.Find(id);
            // Get Location Domain Model From Database
            var locationsDomain = await locationRepository.GetById(id);

            if (locationsDomain == null)
            {
                return NotFound();
            }

            // Map/Convert Locatio Domain Model to Location DTO
            //
            var locationsDto = new LocationDto
            {
                Id = locationsDomain.Id,
                Code = locationsDomain.Code,
                WalkLocation = locationsDomain.WalkLocation,
                LocationImageUrl = locationsDomain.LocationImageUrl,
            };

            // Return DTO back to Client
            return Ok(locationsDto);
        }


        // Post To Create New Location
        // Post: https://localhost:portnumber/api/locations

        [HttpPost] // With a post method you receive a body from the client. Annotate the Create parameter with the [FromBody] method
        public async Task<IActionResult> Create([FromBody] AddLocationRequestDto addLocationRequestDto)
        {
            // Map/Convert DTO To Domain Model
            var locationDomModel = new Location
            {
                Code = addLocationRequestDto.Code,
                WalkLocation = addLocationRequestDto.WalkLocation,
                LocationImageUrl = addLocationRequestDto.LocationImageUrl,
            };


            // Use Domain Model to create a Location 
            await dbContext.Locations.AddAsync(locationDomModel);
            await dbContext.SaveChangesAsync();

            // Map Domain Model back to DTO
            var locationDto = new LocationDto
            {
                Id = locationDomModel.Id,
                Code = locationDomModel.Code,
                WalkLocation = locationDomModel.WalkLocation,
                LocationImageUrl = locationDomModel.LocationImageUrl,
            };

            return CreatedAtAction(nameof(GetById), new { id = locationDto.Id }, locationDto);
        }


        // Update Location
        // PUT: https://localhost:portnumber/api/locations/{id}

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionRequestDto updateRegionRequestDto)
        {
            // Check if location exist
            var locationDomModel = await dbContext.Locations.FirstOrDefaultAsync(x => x.Id == id);

            if (locationDomModel == null)
            {
                return NotFound();
            }

            // Map DTO to Dmain model
            locationDomModel.Code = updateRegionRequestDto.Code;
            locationDomModel.WalkLocation = updateRegionRequestDto.WalkLocation;
            locationDomModel.LocationImageUrl = updateRegionRequestDto.LocationImageUrl;

            await dbContext.SaveChangesAsync();

            // Convert Domain Model to DTO
            var locationDto = new LocationDto
            {
                Id = locationDomModel.Id,
                Code = locationDomModel.Code,
                WalkLocation = locationDomModel.WalkLocation,
                LocationImageUrl = locationDomModel.LocationImageUrl,
            };

            return Ok(locationDto);
        }


        // Delete Location
        // DELETE: https://localhost:portnumber/api/locations/{id}
        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var locationDomModel = await dbContext.Locations.FirstOrDefaultAsync(x => x.Id == id);

            if (locationDomModel == null)
            {
                return NotFound();
            }

            // Delete location
            dbContext.Locations.Remove(locationDomModel);
            await dbContext.SaveChangesAsync();

            // Return Deleted Location back
            // Map Domain Model to DTO
            var locationDto = new LocationDto
            {
                Id = locationDomModel.Id,
                Code = locationDomModel.Code,
                WalkLocation = locationDomModel.WalkLocation,
                LocationImageUrl = locationDomModel.LocationImageUrl,
            };

            return Ok(locationDto);
        }
    }
}
