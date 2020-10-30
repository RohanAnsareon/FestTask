using FestTask.Application.Options;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace FestTask.Api.HttpDelegates
{
    public class TimeZoneHttpDelegate : DelegatingHandler
    {
        private readonly TimeZoneApiOptions _options;

        public TimeZoneHttpDelegate(IOptions<TimeZoneApiOptions> options)
        {
            _options = options.Value;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            UriBuilder builder = new UriBuilder(request.RequestUri);

            var query = HttpUtility.ParseQueryString(builder.Query);

            query["key"] = _options.ApiKey;

            builder.Query = query.ToString();

            request.RequestUri = builder.Uri;

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
