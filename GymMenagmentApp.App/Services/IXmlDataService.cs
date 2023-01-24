using DataBaseAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Services
{
    public interface IXmlDataService
    {
        Task<List<LoginData>> GetAllXmlData();
        Task<LoginData> GetSingleXmlData(int id);
        Task<bool> AddRecordToXml(Employee employee);
        Task<bool> EditXml(LoginData data);
        Task<bool> DeleteDataFromXml();
    }
}
