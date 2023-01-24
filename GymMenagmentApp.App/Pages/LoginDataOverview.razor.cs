using DataBase.API.Models;
using DataBaseAPI.Models;
using GymMenagmentApp.App.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Pages
{
    public partial class LoginDataOverview
    {
        public List<LoginData> LoginData { get; set; }

        [Inject]
        public IXmlDataService XmlDataService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            LoginData = (await XmlDataService.GetAllXmlData());
        }
        public async void Delete()
        {
            var res = (await XmlDataService.DeleteDataFromXml());
        }
    }
}
