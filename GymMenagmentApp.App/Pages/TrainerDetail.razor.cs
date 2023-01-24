//using DataBase.API.Models;
//using DataBaseAPI.Models;
using ConsoleApp1;
using GymMenagmentApp.App.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Pages
{
    public partial class TrainerDetail
    {
        [Parameter]
        public string TrainerId { get; set; }
        public Trainer Trainer { get; set; } = new Trainer();
        [Inject]
        public ITrainerDataService TrainerDataService { get; set; }
        public string initialSpeciality = string.Empty;
        protected async override Task OnInitializedAsync()
        {
            Trainer = (await TrainerDataService.GetTrainer(int.Parse(TrainerId))).Trainers.FirstOrDefault();
            if (Trainer.Speciality == 1)
            {
                initialSpeciality = localizer["condition"];
            }
            else if (Trainer.Speciality == 2)
            {
                initialSpeciality = localizer["weightLos"];
            }
            else if (Trainer.Speciality == 3)
            {
                initialSpeciality = localizer["muscleBuilding"];
            }
            else
            {
                initialSpeciality = localizer["multipleSpecialitys"];
            }
        }
    }
}
