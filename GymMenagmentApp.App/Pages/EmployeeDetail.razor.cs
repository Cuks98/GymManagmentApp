using DataBase.API.Models;
using DataBaseAPI.Models;
using GymMenagmentApp.App.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();
        public string imagePngDataURL { get; set; }
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employee = (await EmployeeDataService.GetEmployee(int.Parse(EmployeeId))).Employees.FirstOrDefault();
            var ProfilePicDataUrl = $"data:image/png;base64,{Convert.ToBase64String(Employee.Image)}";
            imagePngDataURL = ProfilePicDataUrl;   
        }
    }
}
