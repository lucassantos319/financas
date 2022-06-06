
using System.Text;
using System.Text.Json;



namespace FinancasUI.Components.Clients
{
    public class BaseClient
    {
        public readonly string _serverUrl;
        private readonly HttpClient _httpClient;

        private const string ContentType = "application/json";

        protected BaseClient(HttpClient httpClient)
        {
            _serverUrl = "https://localhost:5001/api";
            _httpClient = httpClient;
        }

        protected async Task<HttpResponseMessage> DeleteAsync(string url, string errorMessage)
        {
            HttpRequestMessage request = BuildRequest<object>(url, HttpMethod.Delete, null);
            return await SendAsync(request, errorMessage).ConfigureAwait(false);
        }

        protected async Task<HttpResponseMessage> PostAsync<T>(string url, T data, string errorMessage) where T : class
        {
            HttpRequestMessage request = BuildRequest<T>(url, HttpMethod.Post, data);
            return await SendAsync(request, errorMessage).ConfigureAwait(false);
        }

        public async Task<HttpResponseMessage> PutAsync<T>(string url, T data, string errorMessage) where T : class
        {
            HttpRequestMessage request = BuildRequest<T>(url, HttpMethod.Put, data);
            return await SendAsync(request, errorMessage).ConfigureAwait(false);
        }

        private HttpRequestMessage BuildRequest<T>(string url, HttpMethod method, T data) where T : class
        {
            return new HttpRequestMessage(method, url)
            {
                Content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, ContentType)
            };
        }

        private async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, string errorMessage)
        {
            try
            {
                return await _httpClient.SendAsync(request).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new Exception(errorMessage ?? e.Message, e);
            }
        }

    }
}
