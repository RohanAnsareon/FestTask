using AutoMapper;
using FestTask.Api.DTOs;
using FestTask.Application.DTOs.TimeZone;
using FestTask.Application.DTOs.Weather;

namespace FestTask.Api.Profiles
{
    public class WeatherProfile : Profile
    {
        public WeatherProfile()
        {
            CreateMap<GetWeatherApiResponse, GetWeatherResponse>()
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.Temperature, opt => opt.MapFrom(src => src.main.temp))
                .ForMember(dest => dest.TimeZone, opt => opt.Ignore());
        }
    }
}
