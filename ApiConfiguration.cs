using Microsoft.Extensions.Logging;
using NLog;
using NLog.Web;
using nopCommerceWebApiClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace nopCommerceWebApiClient
{
    public class ApiConfiguration
    {
        protected Logger logger { get; set; }
        protected HttpClientHandler httpClientHandler { get; set; }
        protected CustomHttpClientHandler customHandler { get; set; }
        protected HttpClient httpClient { get; set; }

        public ApiConfiguration()
        {
            logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            httpClientHandler = new HttpClientHandler();
            customHandler = new CustomHttpClientHandler(httpClientHandler, logger);
            httpClient = new HttpClient(customHandler)
            {
                BaseAddress = new Uri("https://localhost:44326/")
            };
        } 
    }
}
