using DataBase.API.Models;
using DataBaseAPI.Models;
using GymMenagmentApp.App.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Pages
{
    public partial class EmployeeCreate
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        public Employee Employee { get; set; } = new Employee();
        public string Date { get; set; }
        public FormFile Picture { get; set; }
        public string ProfilePicDataUrl { get; set; }
        public string LevelOfSecurity { get; set; }
        public byte[] Buffer { get; set; }

        protected string Msg = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;
        protected async override Task OnInitializedAsync()
        {
            Saved = false;
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;
            Employee.LevelOfSecurity = int.Parse(LevelOfSecurity);
            
            Employee.Image = Buffer;

            var stringData = "";
            var Url = "https://random.justyy.workers.dev/api/random/?cached&n=128";
            using (var httpClient = new HttpClient())
            {
                stringData = await System.Text.Json.JsonSerializer.DeserializeAsync<string>(
                    await httpClient.GetStreamAsync(Url), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
            Employee.salt = stringData;
            Console.WriteLine(stringData);
            var res = await EmployeeDataService.AddNewEmployee(Employee);
            if (res != null && res.ErrorId == null)
            {
                StatusClass = "alert-success";
                Msg = localizer["employeeCerateSucess"];
                Saved = true;
            }
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Msg = localizer["employeeCeratedError"];
        }

        private async Task OnInputFileChange(InputFileChangeEventArgs e)
        {
            //get the file
            var file = e.File;

            //read file in byte array
            Buffer = new byte[file.Size];
            await file.OpenReadStream().ReadAsync(Buffer);
            //convert array to base64
            ProfilePicDataUrl = $"data:image/png;base64,{Convert.ToBase64String(Buffer)}";
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/employeeOverview");
        }
    }
}
