﻿using FestTask.Application.DTOs.TimeZone;
using FestTask.Application.Enums;
using FestTask.Application.Exceptions;
using FestTask.Application.Services.Abstractions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FestTask.Application.Services
{
    public class TimeZoneService : ITimeZoneService
    {
        private readonly HttpClient _client;

        public TimeZoneService(HttpClient client)
        {
            _client = client;
        }

        public async Task<GetTimeZoneResponse> GetAsync(string longitude, string latitude, string timestamp)
        {
            var response = await _client.GetAsync($"?location={longitude},{latitude}&timestamp={timestamp}");

            if (!response.IsSuccessStatusCode)
            {
                throw new BadRequestException(ErrorCodes.BADREQUEST_API_RESPONSE, "No information was found for the entered data");
            }

            var result = JsonConvert.DeserializeObject<GetTimeZoneResponse>(await response.Content.ReadAsStringAsync());

            return result;
        }
    }
}
