//using DataBase.API.Models;
using ConsoleApp1;
using DataBaseAPI.Models;
using GymMenagmentApp.App.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Pages
{
    public partial class TrainerCreate
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public ITrainerDataService TrainerDataService { get; set; }
        public Trainer Trainer { get; set; } = new Trainer();
        public string Date { get; set; }
        public string SelectedSpeciality { get; set; }
        public string SelectedSport { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string bla { get; set; }

        protected string Msg = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;
        
        protected async override Task OnInitializedAsync()
        {
            bla = string.Empty;
            Saved = false;
            Trainer.DoB = DateTime.Now;
        }


        public void stringToDate(string date)
        {
            Trainer.DoB = DateTime.Parse(date);
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;
            if(SelectedSpeciality == string.Empty)
            {
                SelectedSpeciality = "4";
            }
            else if(SelectedSpeciality == "condition")
            {
                SelectedSpeciality = "1";
            }
            else if (SelectedSpeciality == "weightLos")
            {
                SelectedSpeciality = "2";
            }
            else if (SelectedSpeciality == "muscleBuilding")
            {
                SelectedSpeciality = "3";
            }
            else if (SelectedSpeciality == "multipleSpecialitys")
            {
                SelectedSpeciality = "4";
            }
            else
            {
                SelectedSpeciality = "4";
            }
            Trainer.Height = int.Parse(height);
            Trainer.Weight = int.Parse(weight);
            Trainer.Speciality = int.Parse(SelectedSpeciality);
            var res = await TrainerDataService.AddNewTrainer(Trainer);
            if (res != null && res.ErrorId == null)
            {
                StatusClass = "alert-success";
                Msg = localizer["trainerCreateSuccess"];
                Saved = true;
            }
        }

        public async Task CalculateTrainerSpeciality()
        {
            var req = new UdpServerRequest()
            {
                SportHistory = SelectedSport
            };

            using (var httpClient = new HttpClient())
            {
                var userJson = new StringContent(JsonSerializer.Serialize(req), Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("https://localhost:7019/WeatherForecast/claculate-udp", userJson);

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
            Msg = localizer["trainerCreateError"];
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/trainerOverview");
        }
    }
}
