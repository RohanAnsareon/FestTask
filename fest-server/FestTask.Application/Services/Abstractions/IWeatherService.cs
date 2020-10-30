using FestTask.Application.DTOs.Weather;
using FestTask.Application.Enums;
using System.Threading.Tasks;

namespace FestTask.Application.Services.Abstractions
{
    public interface IWeatherService
    {
        Task<GetWeatherApiResponse> GetAsync(string zipCode, MeasureSystem units); 
    }
}
