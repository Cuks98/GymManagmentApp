//using DataBase.API.Models;
//using DataBaseAPI.Models;
using ConsoleApp1;
using DataBaseAPI.Models;
using GymMenagmentApp.App.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Pages
{
    public partial class TrainerEdit
    {
        [Parameter]
        public string TrainerID { get; set; }
        public TrainerResponse TrainerResponse { get; set; } = new TrainerResponse();
        public Trainer Trainer { get; set; } = new Trainer();
        [Inject]
        public ITrainerDataService TrainerDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        //[Inject]
        //public IStringLocalizer localizer { get; set; }
        public string SelectedSpeciality { get; set; }
        public string SelectedSport { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string bla { get; set; }

        protected string Msg = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;
        public string initialSpeciality = string.Empty;
        protected async override Task OnInitializedAsync()
        {
            Saved = false;
            TrainerResponse = await TrainerDataService.GetTrainer(int.Parse(TrainerID));
            //User = (await UserDataService.GetUser(int.Parse(UserId))).Users.FirstOrDefault();
            Trainer = (await TrainerDataService.GetTrainer(int.Parse(TrainerID))).Trainers.FirstOrDefault();
            if (Trainer.Speciality == 1)
            {
                initialSpeciality = "condition";
            }
            else if(Trainer.Speciality == 2)
            {
                initialSpeciality = "weightLos";
            }
            else if(Trainer.Speciality == 3)
            {
                initialSpeciality = "muscleBuilding";
            }
            else
            {
                initialSpeciality = "multipleSpecialitys";
            }
            SelectedSport = "0";
            height = Trainer.Height.ToString();
            weight = Trainer.Weight.ToString();
            bla = initialSpeciality;
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;
            if (SelectedSpeciality == string.Empty)
            {
                SelectedSpeciality = "4";
            }
            else if (SelectedSpeciality == "condition")
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
            var res = await TrainerDataService.UpdateTrainer(Trainer);
            if (res != null && res.ErrorId == null)
            {
                StatusClass = "alert-success";
                Msg = localizer["trainerEditSuccess"];
                Saved = true;
            }
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Msg = localizer["trainerEditError"];
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

        protected async Task DeleteUser()
        {
            var res = await TrainerDataService.RemoveTrainer(int.Parse(TrainerID));

            if (res != null && res.ErrorId == null)
            {
                StatusClass = "alert-success";
                Msg = localizer["deleteSuccess"];
                Saved = true;
            }
            else
            {
                StatusClass = "alert-error";
                Msg = localizer["deleteError"];
                Saved = true;
            }
            //Console.Write(id.ToString());
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/trainerOverview");
        }
    }
}
