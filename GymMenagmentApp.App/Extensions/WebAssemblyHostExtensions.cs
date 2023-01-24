using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using System.Globalization;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Extensions
{
    public static class WebAssemblyHostExtensions
    {
        public async static Task SetDefaultCulture(this WebAssemblyHost host)
        {
            var localstorage = host.Services.GetRequiredService<ILocalStorageService>();
            var cultureFromLs = await localstorage.GetItemAsync<string>("culture");

            CultureInfo culture;

            if (cultureFromLs != null)
            {
                culture = new CultureInfo(cultureFromLs);
            }
            else
            {
                culture = new CultureInfo("en-US");
            }

            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
        }
    }
}
