using FestTask.Application.DTOs.Weather;
using FestTask.Application.Enums;
using FestTask.Application.Exceptions;
using FestTask.Application.Services.Abstractions;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace FestTask.Application.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _client;

        public WeatherService(HttpClient client)
        {
            _client = client;
        }

        public async Task<GetWeatherApiResponse> GetAsync(string zipCode, MeasureSystem units)
        {
            var response = await _client.GetAsync($"weather?zip={zipCode}&units={units.ToStringName()}");

            if (!response.IsSuccessStatusCode)
            {
                throw new BadRequestException(ErrorCodes.BADREQUEST_API_RESPONSE, "No information was found for the entered data");
            }

            var result = JsonConvert.DeserializeObject<GetWeatherApiResponse>(await response.Content.ReadAsStringAsync());

            return result;
        }
    }
}
