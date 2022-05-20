using Microsoft.AspNetCore.Components;

namespace FinancasUI.Components
{
    public class BaseComponent : ComponentBase
    {
       
        [Inject]
        public HttpClient _httpClient { get; set; }


    }
}
