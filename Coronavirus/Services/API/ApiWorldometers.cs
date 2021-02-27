using Coronavirus.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Coronavirus.Services.API
{
    public class ApiWorldometers
    {
        private readonly HttpClient _client;

        public ApiWorldometers()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://disease.sh")
            };
        }

        public async Task<CovidAll> GetCovidAllAsync()
        {
            using (_client)
            {
                HttpResponseMessage responseMessage = await _client.GetAsync("/v3/covid-19/all");
                if (responseMessage.IsSuccessStatusCode)
                {
                    string jsonResponse = await responseMessage.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<CovidAll>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                else
                {
                    return null;
                }
            }
        }
    }
}