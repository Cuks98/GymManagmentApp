using DataBaseAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Services
{
    public interface IloginDataService
    {
        Task<LoginResponce> Login(string email, string password);
        Task<string> GetToken();
        Task<List<LoginData>> GetLoginData();
        Task<bool> UpdateLoginData(LoginData data);
        Task<bool> DeleteLoginData();
    }
}
