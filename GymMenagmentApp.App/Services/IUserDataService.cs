using DataBase.API.Models;
using DataBaseAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Services
{
    public interface IUserDataService
    {
        Task<UserResponse> GetUsers();
        Task<UserResponse> GetUser(int id);
        Task<UserResponse> AddNewUser(User user);
        Task<UserResponse> ExtendMembership(ExtendMembershipRequest extendMembershipRequest);
        Task<UserResponse> DeleteUser(int id);
    }
}
