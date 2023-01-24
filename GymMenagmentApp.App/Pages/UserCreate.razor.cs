using ConsoleApp1;
using DataBase.API.Models;
using DataBaseAPI.Models;
using GymMenagmentApp.App.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Pages
{
    public partial class UserCreate
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IUserDataService UserDataService { get; set; }
        public User User { get; set; } = new User();
        public string Date { get; set; }
        public string SelectedSpeciality { get; set; }
        public string SelectedSport { get; set; }
        public string gender { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string bla { get; set; }
        protected string Msg = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;
        protected async override Task OnInitializedAsync()
        {
            //gender = "M";
            //height = "201";
            //weight = "100";
            Saved = false;
            User.DoB = DateTime.Now;
        }
        

        public void stringToDate(string date)
        {
            User.DoB = DateTime.Parse(date);
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;
            //extendMembershipRequest = new ExtendMembershipRequest() { Id = int.Parse(UserId), NumberOfMonths = int.Parse(SelectedNumberOfMonths) };
            //extendMembershipRequest.Id = int.Parse(UserId);
            //extendMembershipRequest.NumberOfMonths = int.Parse(SelectedNumberOfMonths);
            User.FirstRegistered = DateTime.Now;
            User.RegisteredTo = DateTime.Now;
            User.Height = int.Parse(height);
            User.Weight = int.Parse(weight);
            User.RecomendedProgram = bla;

            var res = await UserDataService.AddNewUser(User);
            if (res != null && res.ErrorId == null)
            {
                StatusClass = "alert-success";
                Msg = localizer["userCreateSuccess"];
                Saved = true;
            }
        }

        public async Task Calculate()
        {
            var req = new TcpServerRequest()
            {
                Height=height,
                Weight=weight,
                Gender = User.Gender,
                //SportHistory = SelectedSport
            };

            using (var httpClient = new HttpClient())
            {
                var userJson = new StringContent(JsonSerializer.Serialize(req), Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("https://localhost:7019/WeatherForecast/claculate-tcp", userJson);

                if (response.IsSuccessStatusCode)
                {
                    var result = await JsonSerializer.DeserializeAsync<UdpResponce>(await response.Content.ReadAsStreamAsync());
                    SelectedSpeciality = result.responce;
                    bla = localizer[SelectedSpeciality];
                }
            }

            Console.WriteLine(SelectedSpeciality);
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Msg = localizer["userCreateError"];
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/userOverview");
        }
    }
}
