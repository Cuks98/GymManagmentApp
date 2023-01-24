//using DataBase.API.Models;
//using DataBaseAPI.Models;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ConsoleApp1;

namespace GymMenagmentApp.App.Services
{
    public class TrainerDataService : ITrainerDataService
    {
        private readonly HttpClient _httpClient;
        private readonly IloginDataService _loginDataService;

        public TrainerDataService(HttpClient httpClient, IloginDataService loginDataService)
        {
            _httpClient = httpClient;
            _loginDataService = loginDataService;
        }
        public async Task<TrainerResponse> AddNewTrainer(Trainer trainer)
        {
            var token = await _loginDataService.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            var userJson = new StringContent(JsonSerializer.Serialize(trainer), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("register-new-trainer", userJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<TrainerResponse>(await response.Content.ReadAsStreamAsync());
            }
            return null;
        }

        public async Task<TrainerResponse> RemoveTrainer(int id)
        {
            var token = await _loginDataService.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            var response = await _httpClient.DeleteAsync($"remove-trainer?id={id}");

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<TrainerResponse>(await response.Content.ReadAsStreamAsync());
            }
            return null;
        }

        public async Task<TrainerResponse> UpdateTrainer(Trainer trainer)
        {
            var token = await _loginDataService.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            var requestJson = new StringContent(JsonSerializer.Serialize(trainer), Encoding.UTF8, "application/json");

            var responce = await _httpClient.PutAsync($"update-trainer", requestJson);

            if (responce.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<TrainerResponse>(await responce.Content.ReadAsStreamAsync());
            }
            return null;
        }

        public async Task<TrainerResponse> GetTrainer(int id)
        {
            var token = await _loginDataService.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            return await JsonSerializer.DeserializeAsync<TrainerResponse>(
                await _httpClient.GetStreamAsync($"get-trainer?id={id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<TrainerResponse> GetTrainers()
        {
            //var soapTrainer = new TrainerSoapService.SoapServiceClient();
            //var trainers = await soapTrainer.GetTrainersAsync();
            //return new TrainerResponse
            //{
            //    Trainers = trainers.Body.GetTrainersResult.Trainers.Select(x => new Trainer { 
            //        DoB = x.DoB,
            //        FirstName = x.FirstName,
            //        Gender = x.Gender,
            //        Height = x.Height,
            //        Id = x.Id,
            //        LastName = x.LastName,
            //        PhoneNumber = x.PhoneNumber,
            //        Speciality = x.Speciality,
            //        SportHistory = x.SportHistory,
            //        Weight = x.Weight
            //    }).ToList(),
            //    ErrorId = trainers.Body.GetTrainersResult.ErrorId,
            //    ErrorMsg = trainers.Body.GetTrainersResult.ErrorMsg
            //};
            var token = await _loginDataService.GetToken();
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            return await JsonSerializer.DeserializeAsync<TrainerResponse>(
                await _httpClient.GetStreamAsync($"get-trainers/"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
