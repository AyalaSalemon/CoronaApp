using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoronaApp.Dal.Models;
using CoronaApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoronaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        ILocationRepository _locationRepository;
        public LocationController(ILocationRepository locationRepository)
        {
            this._locationRepository = locationRepository;
        }
        [HttpGet]
        public async Task<ICollection<Location>> GetLocations([FromQuery] Services.Models.LocationSearch locationSearch)
        {
            return await _locationRepository.GetLocations(locationSearch);
        }
        [HttpGet("city")]
        public async Task<List<Location>> GetLocationsByCity([FromQuery] string city)
        {
            return await this._locationRepository.GetLocationsByCity(city);
        }
        [HttpGet("{patientId}")]
        public async Task<List<Location>> GetLocationsByPatientId(string patientId)
        {
            return await this._locationRepository.GetLocationsByPatientId(patientId);
        }

        /*[HttpGet("locationSearch")]
        public async Task<List<Location>> FilterLocations([FromQuery] Services.Models.LocationSearch locationSearch)
        {
            return await this.locationRepository.FilterLocations(locationSearch);

        }*/
        [HttpPost]
        public async Task PostLocation(Location location)
        {
            await this._locationRepository.PostLocation(location);
        }
        [HttpDelete("{patientId}/{locationId}")]
        public async Task Delete(string patientId, int locationId)
        {
            await this._locationRepository.Delete(patientId, locationId);
        }




    }
}
