using DataBaseAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Services
{
    public interface ITransactionDataService
    {
        Task<bool> AddTransactionDataToJsonFile(ExtendMembershipRequest extendMembershipRequest);
        Task<List<Transaction>> GetTransactionData();
        Task<bool> UpdateTransaction(Transaction data);
        Task<bool> DeleteTransaction(int id);
        Task<Transaction> GetSingleTransactionData(int id);
    }
}
