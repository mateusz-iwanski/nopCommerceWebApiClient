using NLog;
using System.Diagnostics;
using System.Text.Json;
using System.Net.Http;
using System.Threading;

namespace nopCommerceWebApiClient.Helpers
{
    /// <summary>
    /// <c>CustomHttpClientHandler</c> class.
    /// 
    /// Handler for HttpClient.
    /// </summary>
    /// <remarks>
    /// A handler used to log request and response information.
    /// </remarks>
    public class CustomHttpClientHandler : DelegatingHandler
    {

        private readonly ILogger _logger;

        public CustomHttpClientHandler(HttpMessageHandler innerHandler, ILogger logger) : base(innerHandler) 
        { 
            _logger = logger;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var processId = Guid.NewGuid().ToString("N").Substring(0, 8);

            _logger.Info($"{processId} {processId} Request: {request.Method} {request.RequestUri}");

            try
            {
                var response = await base.SendAsync(request, cancellationToken);

                _logger.Info($"{processId} Response: {response.StatusCode}");
                _logger.Info($"{processId} Request uri: {request.RequestUri}");
                _logger.Info($"{processId} Request method: {request.Method}");
                _logger.Info($"{processId} Response status code: {response.StatusCode}");

                if (request.Content != null)
                { 
                    var requestContent = await request.Content.ReadAsStringAsync();
                    if (requestContent != null) _logger.Info($"{processId} Request payload: {requestContent}");
                }

                if (!response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        try
                        {
                            _logger.Error($"{processId} Request uri: {request.RequestUri}");
                            _logger.Error($"{processId} Request method: {request.Method}");
                            _logger.Error($"{processId} Response status code: {response.StatusCode}");
                            _logger.Info($"{processId} Response payload: {content}");

                            var errorContent = JsonSerializer.Deserialize<ValidationErrorResponse>(content);
                            if (errorContent?.Errors != null && errorContent.Errors.Count > 0)
                            {
                                foreach (var error in errorContent.Errors)
                                {
                                    _logger.Error($"{processId} Response validation: {string.Join(", ", error.Value)}");
                                }
                            }
                            else
                            {
                                _logger.Error($"{processId} Error content is null or does not contain validation errors.");
                            }
                        }
                        catch (JsonException jsonEx)
                        {
                            _logger.Error($"{processId} JSON Exception: {jsonEx.Message}");
                            _logger.Error($"{processId} Raw JSON response: {content}");
                        }
                    }
                    else
                    {
                        _logger.Error($"{processId} Error: {response.ReasonPhrase}");
                    }
                }

                return response;
            }
            catch (Exception ex)
            {
                _logger.Error($"{processId} Exception: {ex.Message}");
                throw;
            }            
        }
    }
}
