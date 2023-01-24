using DataBaseAPI.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Services
{
    public class XmlDataService : IXmlDataService
    {
        private readonly HttpClient _httpClient;
        private readonly IloginDataService _loginDataService;

        public XmlDataService(HttpClient httpClient, IloginDataService loginDataService)
        {
            _httpClient = httpClient;
            _loginDataService = loginDataService;
        }
        public async Task<bool> AddRecordToXml(Employee employee)
        {
            var userJson = new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("add-record-to-xml", userJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<bool>(await response.Content.ReadAsStreamAsync());
            }
            return false;
        }

        public async Task<bool> DeleteDataFromXml()
        {
            var response = await _httpClient.DeleteAsync($"delete-login-data");

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<bool>(await response.Content.ReadAsStreamAsync());
            }
            return false;
        }

        public async Task<bool> EditXml(LoginData data)
        {
            var userJson = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("update-login-data", userJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<bool>(await response.Content.ReadAsStreamAsync());
            }
            return false;
        }

        public async Task<List<LoginData>> GetAllXmlData()
        {
            return await JsonSerializer.DeserializeAsync<List<LoginData>>(
                await _httpClient.GetStreamAsync($"get-login-data/"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<LoginData> GetSingleXmlData(int id)
        {
            return await JsonSerializer.DeserializeAsync<LoginData>(
                await _httpClient.GetStreamAsync($"get-single-login-data?id={id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
