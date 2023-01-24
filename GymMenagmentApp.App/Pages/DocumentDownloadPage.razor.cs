using DataBase.API.Models;
using DataBaseAPI.Models;
using GymMenagmentApp.App.PDF;
using GymMenagmentApp.App.Services;
using GymMenagmentApp.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Pages
{
    public partial class DocumentDownloadPage
    {
        [Inject]
        public IUserDataService UserDataService { get; set; }
        [Inject]
        public ITransactionDataService TransactionDataService { get; set; }
        public List<ReportData> ReportDataList { get; set; } = new List<ReportData>();
        public List<User> Users { get; set; }
        public List<Transaction> Transactions { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Users = (await UserDataService.GetUsers()).Users;
            //foreach(var user in Users)
            //{
            //    Console.WriteLine("User id:");
            //    Console.WriteLine(user.Id);
            //}
            Transactions = (await TransactionDataService.GetTransactionData());
            foreach (var transaction in Transactions)
            {
                //Console.WriteLine("Transaction id:");
                //Console.WriteLine(transaction.Id);
                var user = Users.Where(x => x.Id == transaction.UserId).FirstOrDefault();
                if(user != null)
                {
                    //Console.WriteLine("Pronadeni user: " + user.Id);
                    var reportData = new ReportData()
                    {
                        Id = transaction.Id,
                        UserId = user.Id,
                        Name = user.FirstName,
                        LastName = user.LastName,
                        Date = transaction.Date.ToShortDateString(),
                        Amount = transaction.Amount
                    };
                    ReportDataList.Add(reportData);
                }


            }
        }
        private async Task DownloadServerFile()
        {
            var userJson = new StringContent(JsonSerializer.Serialize(ReportDataList), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://localhost:7019/WeatherForecast/create-rtf", userJson);

            if (response.IsSuccessStatusCode)
            {
                var result = await JsonSerializer.DeserializeAsync<bool>(await response.Content.ReadAsStreamAsync());
            }

            var httpResponseMessage = await _httpClient.GetAsync("https://localhost:7019/WeatherForecast/get-rtf");
            var base64String = httpResponseMessage.Content.ReadAsStringAsync().Result;

            await JSRuntime.InvokeVoidAsync("downloadRtf", "application/rtf", base64String, "document.rtf");
        }

        private async Task DownloadServerFilePdf()
        {
            var userJson = new StringContent(JsonSerializer.Serialize(ReportDataList), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://localhost:7019/WeatherForecast/create-pdf", userJson);

            if (response.IsSuccessStatusCode)
            {
                var result = await JsonSerializer.DeserializeAsync<bool>(await response.Content.ReadAsStreamAsync());
            }

            var httpResponseMessage = await _httpClient.GetAsync("https://localhost:7019/WeatherForecast/get-pdf");
            var base64String = httpResponseMessage.Content.ReadAsStringAsync().Result;

            await JSRuntime.InvokeVoidAsync("downloadPdf", "application/pdf", base64String, "document.pdf");
        }
    }
}
