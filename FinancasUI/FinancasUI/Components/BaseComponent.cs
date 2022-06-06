using Microsoft.AspNetCore.Components;

namespace FinancasUI.Components
{
    public class BaseComponent : ComponentBase
    {

        [Inject]
        public static HttpClient _httpClient { get; set; } = new HttpClient();

    }
}
