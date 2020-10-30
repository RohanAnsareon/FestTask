using FestTask.Application.Enums;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace FestTask.Api.DTOs
{
    public class GetWeatherRequest
    {
        public string ZipCode { get; set; }
        public MeasureSystem Units { get; set; }
    }
}
