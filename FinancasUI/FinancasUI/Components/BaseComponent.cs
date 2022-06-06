using Blazored.LocalStorage;
using FinancasUI.ViewModels.Enums;
using Microsoft.AspNetCore.Components;

namespace FinancasUI.Components
{
    public class BaseComponent : ComponentBase
    {

        [Inject]
        protected HttpClient _httpClient { get; set; } = new HttpClient();

        protected ILocalStorageService LocalStorage;

        protected NavigationManager Navigation;

        protected async Task SaveItemInStorage(object item,string itemName) 
        {
            await LocalStorage.SetItemAsync(itemName,item);
        }
        
        protected async Task<T> GetItemInStorage<T>(string itemName) where T: class
        {
            return await LocalStorage.GetItemAsync<T>(itemName);
        }

    }
}
