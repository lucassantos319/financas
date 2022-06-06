using FinancasUI.Components.Clients;
using FinancasUI.ViewModels.Enums;

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
            try
            {
                sendLogin = true;

                var userInfos = await loginClient.GetLogin(emailUser, passwordUser);
                await SaveItemInStorage(userInfos, "userInfos");
                Navigation.NavigateTo("/dashboard");

                sendLogin = false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message,ex.InnerException);
            }
        }


    }
}
