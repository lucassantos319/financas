using FinancasUI.Components.Clients;

namespace FinancasUI.Components.Login
{
    public class LoginComponent : BaseComponent
    {
        public LoginClient loginClient { get; set; }
        public string emailUser { get; set; }
        public string passwordUser { get; set; }
        
        public bool sendLogin = false;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            loginClient = new LoginClient(_httpClient);
            StateHasChanged();
        }

        public async Task SendRequest()
        {
            sendLogin = true;
            await loginClient.GetLogin(emailUser, passwordUser);
            sendLogin = false;
        }
    }
}
