using DataBaseAPI.Models;
using GymMenagmentApp.App.Services;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Pages
{
    public partial class EmployeeEdit
    {
        [Parameter]
        public string EmployeeID { get; set; }
        public EmployeeResponse EmployeeResponse { get; set; } = new EmployeeResponse();
        public Employee Employee { get; set; } = new Employee();
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        //[Inject]
        //public IStringLocalizer localizer { get; set; }
        public string SelectedSpeciality { get; set; }

        protected string Msg = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;
        public string initialSpeciality = string.Empty;
        protected async override Task OnInitializedAsync()
        {
            Saved = false;
            Employee = (await EmployeeDataService.GetEmployee(int.Parse(EmployeeID))).Employees.FirstOrDefault();
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;
            var res = await EmployeeDataService.UpdateEmployee(Employee);
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

        protected async Task DeleteUser()
        {
            var res = await EmployeeDataService.RemoveEmployee(int.Parse(EmployeeID));

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
            NavigationManager.NavigateTo("/employeeOverview");
        }
    }
}
