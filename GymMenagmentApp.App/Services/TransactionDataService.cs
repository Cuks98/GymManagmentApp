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
    public class TransactionDataService : ITransactionDataService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private readonly IloginDataService _loginDataService;

        public TransactionDataService(HttpClient httpClient, ILocalStorageService localStorage, IloginDataService loginDataService)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
            _loginDataService = loginDataService;
        }

        public async Task<bool> AddTransactionDataToJsonFile(ExtendMembershipRequest extendMembershipRequest)
        {
            var userJson = new StringContent(JsonSerializer.Serialize(extendMembershipRequest), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("add-transacton-data-to-json", userJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<bool>(await response.Content.ReadAsStreamAsync());
            }
            return false;
        }

        public async Task<bool> DeleteTransaction(int id)
        {
            //var token = await _loginDataService.GetToken();
            //if (token != null)
            //{
            //    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            //}

            var response = await _httpClient.DeleteAsync($"remove-transaction-data?id={id}");

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<bool>(await response.Content.ReadAsStreamAsync());
            }
            return false;
        }

        public async Task<Transaction> GetSingleTransactionData(int id)
        {
            return await JsonSerializer.DeserializeAsync<Transaction>(
                await _httpClient.GetStreamAsync($"get-single-transaction-data?id={id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<List<Transaction>> GetTransactionData()
        {
            //var token = await _loginDataService.GetToken();
            //if (token != null)
            //{
            //    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            //}
            return await JsonSerializer.DeserializeAsync<List<Transaction>>(
                await _httpClient.GetStreamAsync($"get-transaction-data/"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<bool> UpdateTransaction(Transaction data)
        {
            //var token = await _loginDataService.GetToken();
            //if (token != null)
            //{
            //    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            //}

            var userJson = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("update-transaction-data", userJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<bool>(await response.Content.ReadAsStreamAsync());
            }
            return false;
        }

    }
}
