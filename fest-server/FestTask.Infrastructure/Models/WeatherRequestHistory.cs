using System;

namespace FestTask.Infrastructure.Models
{
    public class WeatherRequestHistory
    {
        public Guid Id { get; set; }

        public string ZipCode { get; set; }
        public string Temperature { get; set; }
        public string City { get; set; }

        public DateTime RequestTime { get; set; }
        //public string IpAddress { get; set; }
    }
}
