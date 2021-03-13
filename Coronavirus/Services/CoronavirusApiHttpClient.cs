using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Coronavirus
{
    public class CoronavirusApiHttpClient : HttpClient
    {
        public CoronavirusApiHttpClient()
        {
            BaseAddress = new Uri("https://disease.sh/v3");
        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            HttpResponseMessage responseMessage = await GetAsync(endpoint);
            string jsonResponse = await responseMessage.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(jsonResponse, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}