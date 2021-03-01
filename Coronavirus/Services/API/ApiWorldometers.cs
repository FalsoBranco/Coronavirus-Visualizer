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
        public async Task<CovidAll> GetCovidAllAsync()
        {
            using (CoronavirusApiHttpClient client = new CoronavirusApiHttpClient())
            {
                string uri = "/covid-19/all";
                return await client.GetAsync<CovidAll>(uri);
            }
        }

        public async Task<List<CovidCountry>> GetCovidAllCountriesAsync()
        {
            using (CoronavirusApiHttpClient client = new CoronavirusApiHttpClient())
            {
                //countries? sort = cases
                //cases, todayCases, deaths, todayDeaths, recovered, active, critica
                string uri = "/v3/covid-19/countries";

                List<CovidCountry> covidCountries = await client.GetAsync<List<CovidCountry>>(uri);
                return covidCountries;
            }
        }
    }
}