//using DataBase.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Components;
using System.Linq;
using GymMenagmentApp.App.Services;
//using DataBaseAPI.Models;
//using DataBaseAPI;
using DataBase.API.Models;
using DataBaseAPI.Models;
using ConsoleApp1;

namespace GymMenagmentApp.App.Pages
{
    public partial class UserDetail
    {
        [Parameter]
        public string UserId { get; set; }
        public List<User> Users { get; set; }
        public UserResponse UserResponce { get; set; }
        public User User { get; set; } = new User();
        [Inject]
        public IUserDataService UserDataService { get; set; }
        protected async override Task OnInitializedAsync()
        {
            User = (await UserDataService.GetUser(int.Parse(UserId))).Users.FirstOrDefault();
            //Console.WriteLine("Pozdrav iz dll-a");

            
            //User = Users.Where(x => x.Id == int.Parse(UserId)).FirstOrDefault();
        }
    }
}

