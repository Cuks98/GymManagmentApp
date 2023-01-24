using DataBaseAPI.Models;
using GymMenagmentApp.App.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; }
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetEmployees()).Employees;
        }
    }
}
