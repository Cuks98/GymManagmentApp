using DataBase.API.Models;
using DataBaseAPI.Models;
using GymMenagmentApp.App.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Pages
{
    public partial class TransactionEdit
    {
        [Parameter]
        public string TransactionId { get; set; }
        [Inject]
        public ITransactionDataService TransactionDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public Transaction Transaction { get; set; } 

        protected string Msg = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;
        public string initialSpeciality = string.Empty;
        public int amount = 0;
        protected async override Task OnInitializedAsync()
        {
            Saved = false;
            Transaction = (await TransactionDataService.GetSingleTransactionData(int.Parse(TransactionId)));
            amount = int.Parse(Transaction.Amount);
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;
            //Transaction = new Transaction()
            //{
            //    Id = int.Parse(TransactionId),
            //    UserId = int.Parse(UserId),
            //    Date = DateTime.Parse(TransactionDateTime),
            //    Amount = amount.ToString()
            //};
            Transaction.Amount = amount.ToString();
            var res = await TransactionDataService.UpdateTransaction(Transaction);
            if (res == true)
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
            var res = await TransactionDataService.DeleteTransaction(int.Parse(TransactionId));

            if (res == true)
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
            NavigationManager.NavigateTo("/transactionOverview");
        }
    }
}
