using DataBase.API.Models;
using DataBaseAPI.Models;
using GymMenagmentApp.App.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Pages
{
    public partial class LoginDataEdit
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IXmlDataService XmlDataService { get; set; }
        [Parameter]
        public string id { get; set; }
        public LoginData LoginData { get; set; }

        protected string Msg = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;
        protected async override Task OnInitializedAsync()
        {
            Saved = false;
            LoginData = (await XmlDataService.GetSingleXmlData(int.Parse(id)));
            var bla = LoginData.DateTime.ToShortDateString();
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;
            //extendMembershipRequest = new ExtendMembershipRequest() { Id = int.Parse(UserId), NumberOfMonths = int.Parse(SelectedNumberOfMonths) };
            //extendMembershipRequest.Id = int.Parse(UserId);
            //extendMembershipRequest.NumberOfMonths = int.Parse(SelectedNumberOfMonths);

            //var res = await UserDataService.ExtendMembership(extendMembershipRequest);
            var res = await XmlDataService.EditXml(LoginData);
            if (res != false)
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

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/loginDataOverview");
        }

    }
}
