using DataBase.API.Models;
using DataBaseAPI.Models;
using GymMenagmentApp.App.Services;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Pages
{
    public partial class UserEdit
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IUserDataService UserDataService { get; set; }
        [Inject]
        public ITransactionDataService TransactionDataService { get; set; }
        [Parameter]
        public string UserId { get; set; }
        
        public User User { get; set; } = new User();
        public ExtendMembershipRequest extendMembershipRequest{ get; set; }

        protected string Msg = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;
        public string SelectedNumberOfMonths = "0";
        protected async override Task OnInitializedAsync()
        {
            Saved = false;
            User = (await UserDataService.GetUser(int.Parse(UserId))).Users.FirstOrDefault();
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;
            extendMembershipRequest = new ExtendMembershipRequest() { Id = int.Parse(UserId), NumberOfMonths = int.Parse(SelectedNumberOfMonths)};
            //extendMembershipRequest.Id = int.Parse(UserId);
            //extendMembershipRequest.NumberOfMonths = int.Parse(SelectedNumberOfMonths);

            var res = await UserDataService.ExtendMembership(extendMembershipRequest);
            var res2 = await TransactionDataService.AddTransactionDataToJsonFile(extendMembershipRequest);
            if(res != null && res.ErrorId == null && res2 != false)
            {
                StatusClass = "alert-success";
                Msg = localizer["membershipExtendedSucces"];
                Saved = true;
            }
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Msg = localizer["membershipExtendedError"];
        }

        protected async Task DeleteUser()
        {
            var res = await UserDataService.DeleteUser(int.Parse(UserId));

            if(res != null && res.ErrorId == null)
            {
                StatusClass = "alert-success";
                Msg = "Deleted succesfully";
                Saved = true;
            }
            //Console.Write(id.ToString());
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/userOverview");
        }
        
    }
}
