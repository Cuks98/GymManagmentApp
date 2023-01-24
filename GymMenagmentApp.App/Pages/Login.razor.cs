using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System;
using Microsoft.AspNetCore.Components;
using GymMenagmentApp.App.Services;
using Blazored.LocalStorage;

namespace GymMenagmentApp.App.Pages
{
    public partial class Login
    {
        public string imgSrc { get; set; }
        public string token { get; set; }
        private string email { get; set; }
        [Inject]
        private ILocalStorageService localstorage { get; set; }
        private string password { get; set; }
        [Inject]
        public IloginDataService LoginDataService { get; set; }

        [Inject]
        public IXmlDataService XmlDataService { get; set; }
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }
        private async void LogIn()
        {
            var responce = (await LoginDataService.Login(email.ToString(), password.ToString()));
            token = responce.Token;
            var employee = responce.Employee;
            var res = await XmlDataService.AddRecordToXml(employee);
            if (token != "")
            {
                await localstorage.SetItemAsync<string>("token", token);
                await localstorage.SetItemAsync<string>("security", employee.LevelOfSecurity.ToString());
                await localstorage.SetItemAsync<string>("name", employee.FirstName.ToString());
                NavManager.NavigateTo("home");
            }
        }

        async Task GetPngImage()
        {
            //od api image atribut ide u this.imgSrc
            //imagePngDataURL = string.Format("data:image/png;base64,{0}", this.imgSrc);
        }
        public void Generate()
        {
            
        }
    }
}
