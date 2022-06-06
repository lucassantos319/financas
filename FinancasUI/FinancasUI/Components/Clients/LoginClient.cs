using FinancasUI.ViewModels.Enums;
using System.Net.Http.Json;

namespace FinancasUI.Components.Clients
{
    public class LoginClient : BaseClient
    {

        public string _baseUrl;
        public readonly HttpClient _httpClient;

        public LoginClient(HttpClient httpClient) : base(httpClient) 
        {
            _baseUrl = _serverUrl + "/User/";
            _httpClient = httpClient;
        }

        public async Task<LoginUserViewModel> GetLogin(string email, string password)
        {
            var path = _baseUrl + "login";
            var loginObj = new
            {
                Email = email,
                Password = password
            };

            var response = await PostAsync<object>(path,loginObj,"");
            var loginUser = await response.Content.ReadFromJsonAsync<LoginUserViewModel>();
            
            return loginUser;
        }

    }
}
