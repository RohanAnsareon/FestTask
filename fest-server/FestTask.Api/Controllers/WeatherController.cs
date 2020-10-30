using System.Threading.Tasks;
using AutoMapper;
using FestTask.Api.DTOs;
using FestTask.Application.Exceptions;
using FestTask.Application.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FestTask.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IWeatherService _weatherService;
        private readonly ITimeZoneService _timeZoneService;

        public WeatherController(IMapper mapper, IWeatherService weatherService, ITimeZoneService timeZoneService)
        {
            _mapper = mapper;
            _weatherService = weatherService;
            _timeZoneService = timeZoneService;
        }

        /// <summary>
        /// Gets city name, current temperature and time zone by ZIP-code
        /// </summary>
        /// <param name="request">ZIP code</param>
        /// <returns>City name, current temperature and time zone</returns>
        /// <example>AZ1050</example>
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(GetWeatherResponse))]
        public async Task<GetWeatherResponse> Get([FromQuery] GetWeatherRequest request)
        {
            var weatherResponse = await _weatherService.GetAsync(request.ZipCode, request.Units);

            var timeZoneResponse = await _timeZoneService.GetAsync(
                weatherResponse.coord.lon.ToString(), 
                weatherResponse.coord.lat.ToString(), 
                weatherResponse.dt.ToString());

            var result = _mapper.Map<GetWeatherResponse>(weatherResponse);

            result.TimeZone = timeZoneResponse.timeZoneName;

            return result;
        }
    }
}
