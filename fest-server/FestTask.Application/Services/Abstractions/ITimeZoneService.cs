using FestTask.Application.DTOs.TimeZone;
using System.Threading.Tasks;

namespace FestTask.Application.Services.Abstractions
{
    public interface ITimeZoneService
    {
        Task<GetTimeZoneResponse> GetAsync(string longitude, string latitude, string timestamp);
    }
}
