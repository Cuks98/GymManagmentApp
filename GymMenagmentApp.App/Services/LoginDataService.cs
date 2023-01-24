using Blazored.LocalStorage;
using DataBaseAPI.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Services
{
    public class LoginDataService : IloginDataService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;

        public LoginDataService(HttpClient httpClient, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
        }

        public async Task<string> GetToken()
        {
            string token = await _localStorage.GetItemAsStringAsync("token");

            if (string.IsNullOrEmpty(token)) { return null; }

            return token.Replace("\"", "");
        }

        public async Task<LoginResponce> Login(string email, string password)
        {
            //return await _httpClient.GetStringAsync($"get-login?email={email}&password={password}");
            return await JsonSerializer.DeserializeAsync<LoginResponce>(
                await _httpClient.GetStreamAsync($"get-login?email={email}&password={password}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<List<LoginData>> GetLoginData()
        {
            var token = await this.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.ToString());
            }

            return await JsonSerializer.DeserializeAsync<List<LoginData>>(
                await _httpClient.GetStreamAsync($"get-login-data/"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<bool> UpdateLoginData(LoginData data)
        {
            var token = await this.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.ToString());
            }

            var userJson = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("update-login-data", userJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<bool>(await response.Content.ReadAsStreamAsync());
            }
            return false;
        }

        public async Task<bool> DeleteLoginData()
        {
            var token = this.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.ToString());
            }

            var response = await _httpClient.DeleteAsync($"delete-login-data");

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<bool>(await response.Content.ReadAsStreamAsync());
            }
            return false;
        }
    }
}
