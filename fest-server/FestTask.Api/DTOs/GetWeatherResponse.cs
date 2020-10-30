using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FestTask.Api.DTOs
{
    public class GetWeatherResponse
    {
        public string City { get; set; }
        public float Temperature { get; set; }
        public string TimeZone { get; set; }
    }
}
