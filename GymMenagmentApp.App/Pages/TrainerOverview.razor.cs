using DataBase.API.Models;
using GymMenagmentApp.App.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleApp1;

namespace GymMenagmentApp.App.Pages
{
    public partial class TrainerOverview
    {
        public List<ConsoleApp1.Trainer> Trainers { get; set; }

        [Inject]
        public ITrainerDataService TrainerDataService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Trainers = (await TrainerDataService.GetTrainers()).Trainers;
        }

    }
}
