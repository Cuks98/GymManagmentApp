using DataBaseAPI.Models;
using GymMenagmentApp.App.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Pages
{
    public partial class TransactionOverview
    {
        public List<Transaction> Transactions { get; set; }

        [Inject]
        public ITransactionDataService TransactionDataService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Transactions = (await TransactionDataService.GetTransactionData());
        }
    }
}
