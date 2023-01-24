//using DataBase.API.Models;
//using DataBaseAPI.Models;
using ConsoleApp1;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Services
{
    public interface ITrainerDataService
    {
        Task<TrainerResponse> GetTrainers();
        Task<TrainerResponse> GetTrainer(int id);
        Task<TrainerResponse> AddNewTrainer(Trainer trainer);
        Task<TrainerResponse> UpdateTrainer(Trainer trainer);
        Task<TrainerResponse> RemoveTrainer(int id);
    }
}
