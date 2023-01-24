using DataBaseAPI.Models;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Services
{
    public interface IEmployeeDataService
    {
        Task<EmployeeResponse> GetEmployees();
        Task<EmployeeResponse> GetEmployee(int id);
        Task<EmployeeResponse> AddNewEmployee(Employee employee);
        Task<EmployeeResponse> UpdateEmployee(Employee employee);
        Task<EmployeeResponse> RemoveEmployee(int id);
    }
}
