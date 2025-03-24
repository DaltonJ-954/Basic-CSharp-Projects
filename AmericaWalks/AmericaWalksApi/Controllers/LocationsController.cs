using AmericaWalksApi.CustomActionFilters;
using AmericaWalksApi.Data;
using AmericaWalksApi.Models.Domain;
using AmericaWalksApi.Models.DTO;
using AmericaWalksApi.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmericaWalksApi.Controllers
{
    // https://localhost:7189/api/locations
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LocationsController : ControllerBase
    {
        private readonly AmericaWalksDbContext dbContext;
        private readonly ILocationRepository locationRepository;
        private readonly IMapper mapper;

        public LocationsController(AmericaWalksDbContext dbContext, ILocationRepository locationRepository,
            IMapper mapper)
        {
            this.dbContext = dbContext;
            this.locationRepository = locationRepository;
            this.mapper = mapper;
        }

        // GET ALL LOCATIONS
        // GET: https://localhost:portnumber/api/locations
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get Data From Database - Domain models
            var locationsDomain = await locationRepository.GetAllAsync();

            // Return DTOs
            return Ok(mapper.Map<List<LocationDto>>(locationsDomain));
        }


        // GET SINGLE LOCATION (Get Location By ID)
        // GET: https://localhost:portnumber/api/locations/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            // var location = dbContext.Locations.Find(id);
            // Get Location Domain Model From Database
            var locationsDomain = await locationRepository.GetByIdAsync(id);

            if (locationsDomain == null)
            {
                return NotFound();
            }

            // Return DTO back to Client
            return Ok(mapper.Map<LocationDto>(locationsDomain));
        }


        // Post To Create New Location
        // Post: https://localhost:portnumber/api/locations

        [HttpPost] // With a post method you receive a body from the client. Annotate the Create parameter with the [FromBody] method
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] AddLocationRequestDto addLocationRequestDto)
        {
            // Map/Convert DTO To Domain Model
            // AutoMapper is not a replacement of DTO to Domain, but alternately a different way to mapping models and vice-versa
            var locationDomModel = mapper.Map<Location>(addLocationRequestDto);

            // Use Domain Model to create a Location 
            locationDomModel = await locationRepository.CreateAsync(locationDomModel);

            // Map Domain Model back to DTO
            var locationDto = mapper.Map<LocationDto>(locationDomModel);

            return CreatedAtAction(nameof(GetById), new { id = locationDto.Id }, locationDto);
        }


        // Update Location
        // PUT: https://localhost:portnumber/api/locations/{id}

        [HttpPut]
        [Route("{id:Guid}")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateLocationRequestDto updateLocationRequestDto)
        {
            // Map DTO to Domain Model
            var locationDomModel = mapper.Map<Location>(updateLocationRequestDto);

            // Check if location exist
            locationDomModel = await locationRepository.UpdateAsync(id, locationDomModel);

            if (locationDomModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<LocationDto>(locationDomModel));
        }


        // Delete Location
        // DELETE: https://localhost:portnumber/api/locations/{id}
        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var locationDomModel = await locationRepository.DeleteAsync(id);

            if (locationDomModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<LocationDto>(locationDomModel));
        }
    }
}