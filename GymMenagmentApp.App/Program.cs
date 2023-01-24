using GymMenagmentApp.App.Extensions;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using GymMenagmentApp.App.Services;
using Syncfusion.Blazor;

namespace GymMenagmentApp.App
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzAwODY0QDMyMzAyZTMyMmUzMFBnRnBhbGZscUNFZitGSGI1YnFlcms5Y0JSUEZzSTdDdFNrWGlmb0s3VkE9");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddLocalization();
            builder.Services.AddBlazoredLocalStorage();
            //builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7267/DataBase/") });

            //TESTNI API

            //builder.Services.AddHttpClient<IUserDataService, UserDataService>(client => client.BaseAddress = new Uri("https://localhost:7267/DataBase/"));
            //builder.Services.AddHttpClient<ITrainerDataService, TrainerDataService>(client => client.BaseAddress = new Uri("https://localhost:7267/DataBase/"));
            //builder.Services.AddHttpClient<IEmployeeDataService, EmployeeDataService>(client => client.BaseAddress = new Uri("https://localhost:7267/DataBase/"));
            //builder.Services.AddHttpClient<IloginDataService, LoginDataService>(client => client.BaseAddress = new Uri("https://localhost:7267/DataBase/"));
            builder.Services.AddHttpClient<ITransactionDataService, TransactionDataService>(client => client.BaseAddress = new Uri("https://localhost:7019/WeatherForecast/"));
            builder.Services.AddHttpClient<IXmlDataService, XmlDataService>(client => client.BaseAddress = new Uri("https://localhost:7019/WeatherForecast/"));
            //await builder.Build().RunAsync();


            //LIVE API

            builder.Services.AddHttpClient<IUserDataService, UserDataService>(client => client.BaseAddress = new Uri("http://localhost:90/DataBase/"));
            builder.Services.AddHttpClient<ITrainerDataService, TrainerDataService>(client => client.BaseAddress = new Uri("https://localhost:7019/WeatherForecast/"));
            builder.Services.AddHttpClient<IEmployeeDataService, EmployeeDataService>(client => client.BaseAddress = new Uri("http://localhost:90/DataBase/"));
            builder.Services.AddHttpClient<IloginDataService, LoginDataService>(client => client.BaseAddress = new Uri("http://localhost:90/DataBase/"));
            //builder.Services.AddHttpClient<ITransactionDataService, TransactionDataService>(client => client.BaseAddress = new Uri("https://localhost:90/DataBase/"));

            var host = builder.Build();
            await host.SetDefaultCulture();
            await host.RunAsync();
        }
    }
}
