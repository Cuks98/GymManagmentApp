using Blazored.LocalStorage;
using DataBase.API.Models;
using DataBaseAPI.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace GymMenagmentApp.App.Services
{
    public class UserDataService : IUserDataService
    {
        private readonly HttpClient _httpClient;
        private readonly IloginDataService _loginDataService;


        public UserDataService(HttpClient httpClient, IloginDataService loginDataService)
        {
            _httpClient = httpClient;
            _loginDataService = loginDataService;
            //_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", );
        }

        public async Task<UserResponse> AddNewUser(User user)
        {
            var token = await _loginDataService.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            var userJson = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("register-new-user", userJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<UserResponse>(await response.Content.ReadAsStreamAsync());
            }
            return null;
        }

        public async Task<UserResponse> DeleteUser(int id)
        {
            var token = await _loginDataService.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            var response = await _httpClient.DeleteAsync($"remove-user?id={id}");

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<UserResponse>(await response.Content.ReadAsStreamAsync());
            }
            return null;
        }

        public async Task<UserResponse> ExtendMembership(ExtendMembershipRequest extendMembershipRequest)
        {
            var token = await _loginDataService.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            var requestJson = new StringContent(JsonSerializer.Serialize(extendMembershipRequest), Encoding.UTF8, "application/json");

            var responce = await _httpClient.PutAsync($"extend-membership", requestJson);

            if (responce.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<UserResponse>(await responce.Content.ReadAsStreamAsync());
            }
            return null;
        }

        public async Task<UserResponse> GetUser(int id)
        {
            var token = await _loginDataService.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            return await JsonSerializer.DeserializeAsync<UserResponse>(
                await _httpClient.GetStreamAsync($"get-user?id={id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<UserResponse> GetUsers()
        {
            var token = await _loginDataService.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            return await JsonSerializer.DeserializeAsync<UserResponse>(
                await _httpClient.GetStreamAsync($"get-users/"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
