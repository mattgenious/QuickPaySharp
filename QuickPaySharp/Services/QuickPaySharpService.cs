using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Polly;
using Polly.Retry;

namespace QuickPaySharp.Services
{
    public class QuickPaySharpService
    {
        protected readonly AsyncRetryPolicy<HttpResponseMessage> AsyncRetryPolicy;

        private readonly ILogger<QuickPaySharpService> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly QuickPaySharpServiceOptions _quickPaySharpServiceOptions;
        private readonly HttpClient _client;
        protected QuickPaySharpService(ILogger<QuickPaySharpService> logger, IHttpClientFactory httpClientFactory, IOptions<QuickPaySharpServiceOptions> quickPaySharpServiceOptions)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _quickPaySharpServiceOptions = quickPaySharpServiceOptions.Value;

            var apiKey = _quickPaySharpServiceOptions.GetApiKey();

            _client = _httpClientFactory.CreateClient("QuickPaySharpClient");
            if (_client.DefaultRequestHeaders.Contains("Authorization"))
            {
                _client.DefaultRequestHeaders.Remove("Authorization");
            }
            _client.DefaultRequestHeaders.Add($"Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($":{apiKey}"))}");

            AsyncRetryPolicy = Policy.HandleResult<HttpResponseMessage>(x =>
            {
                if (!x.IsSuccessStatusCode)
                {
                    _logger.LogError(x.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                    if ((int)x.StatusCode == 401)
                    {
                        throw new UnauthorizedAccessException($"Api key starts with: {apiKey.Take(4)} was unauthorized");
                    }
                    if (x.StatusCode == HttpStatusCode.TooManyRequests)
                    {
                        var newApiKey = _quickPaySharpServiceOptions.GetApiKey();
                        _client.DefaultRequestHeaders.Remove("Authorization");
                        _client.DefaultRequestHeaders.Add("Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($":{apiKey}"))}");
                        _logger.LogInformation($"changed apikey to: {newApiKey}");
                        return true;
                    }
                    if ((int)x.StatusCode > 399 && x.StatusCode != HttpStatusCode.TooManyRequests && (x.StatusCode != HttpStatusCode.NotFound && x.RequestMessage.Method != HttpMethod.Get))
                    {
                        throw new Exception(x.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                    }

                    if (x.StatusCode == HttpStatusCode.NotFound)
                    {
                        throw new Exception("Returned 404");
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }).WaitAndRetryForeverAsync(
                retryAttempt =>
                    TimeSpan.FromSeconds(3));
        }

        protected Task<HttpResponseMessage> GetAsync(string path)
        {
            _logger.LogInformation($"QuickPaySharp GET: {path}");
            return AsyncRetryPolicy.ExecuteAsync(async () => await _client.GetAsync(path));
        }
        protected Task<HttpResponseMessage> PutAsJsonAsync(string path, string jsonData)
        {
            _logger.LogInformation($"QuickPaySharp PUT: {path}\r\nJSONDATA: {jsonData}");
            var content = new StringContent(jsonData);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return AsyncRetryPolicy.ExecuteAsync(async () => await _client.PutAsync(path, content));
        }
        protected Task<HttpResponseMessage> PostAsJsonAsync(string path, string jsonData)
        {
            _logger.LogInformation($"QuickPaySharp POST: {path}\r\nJSONDATA: {jsonData}");
            var content = new StringContent(jsonData);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return AsyncRetryPolicy.ExecuteAsync(async () => await _client.PostAsync(path, content));
        }
        protected Task<HttpResponseMessage> DeleteAsync(string path)
        {
            _logger.LogInformation($"QuickPaySharp DELETE: {path}");
            return AsyncRetryPolicy.ExecuteAsync(async () => await _client.DeleteAsync(path));
        }

        protected void ValidateModel(object objectToValidate)
        {
            var context = new ValidationContext(objectToValidate);
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateObject(objectToValidate, context, results, true))
            {
                throw new ArgumentException(string.Join(", ", results), nameof(objectToValidate));
            }
        }
    }
}
