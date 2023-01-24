using DataBase.API.Models;
using DataBaseAPI.Models;
using GymMenagmentApp.App.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Pages
{
    public partial class NewsLetter
    {
        public List<User> Users { get; set; }
        [Inject]
        public IUserDataService UserDataService { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        protected string Msg = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        protected async override Task OnInitializedAsync()
        {
            Saved = false;
            Body = string.Empty;
            Subject = string.Empty;
            Users = (await UserDataService.GetUsers()).Users;
        }

        public async void Send()
        {
            var listOfEmailAddresses = new List<string>();
            foreach(var user in Users)
            {
                listOfEmailAddresses.Add(user.Email);
            }
            var mailRequest = new MailRequest()
            {
                Subject = Subject,
                Body = Body,
                ListOfMailAddresses = listOfEmailAddresses
            };
            using (var httpClient = new HttpClient())
            {
                var mailJson = new StringContent(JsonSerializer.Serialize(mailRequest), Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("https://localhost:7019/WeatherForecast/post-mail", mailJson);

                
                if (response.IsSuccessStatusCode)
                {
                    StatusClass = "alert-success";
                    Msg = localizer["trainerCreateSuccess"];
                    Saved = true;
                }
            }
        }
    }
}
