using DataBaseAPI.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Services
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly HttpClient _httpClient;
        private readonly IloginDataService _loginDataService;

        public EmployeeDataService(HttpClient httpClient, IloginDataService loginDataService)
        {
            _httpClient = httpClient;
            _loginDataService = loginDataService;
        }
        public async Task<EmployeeResponse> AddNewEmployee(Employee employee)
        {
            var token = await _loginDataService.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            var userJson = new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("register-new-employee", userJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<EmployeeResponse>(await response.Content.ReadAsStreamAsync());
            }
            return null;
        }

        public async Task<EmployeeResponse> GetEmployee(int id)
        {
            var token = await _loginDataService.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            return await JsonSerializer.DeserializeAsync<EmployeeResponse>(
                await _httpClient.GetStreamAsync($"get-employee?id={id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<EmployeeResponse> GetEmployees()
        {
            var token = await _loginDataService.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            return await JsonSerializer.DeserializeAsync<EmployeeResponse>(
                await _httpClient.GetStreamAsync($"get-employees/"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<EmployeeResponse> RemoveEmployee(int id)
        {
            var token = await _loginDataService.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            var response = await _httpClient.DeleteAsync($"remove-employee?id={id}");

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<EmployeeResponse>(await response.Content.ReadAsStreamAsync());
            }
            return null;
        }

        public async Task<EmployeeResponse> UpdateEmployee(Employee employee)
        {
            var token = await _loginDataService.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            var requestJson = new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");

            var responce = await _httpClient.PutAsync($"update-employee", requestJson);

            if (responce.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<EmployeeResponse>(await responce.Content.ReadAsStreamAsync());
            }
            return null;
        }
    }
}
