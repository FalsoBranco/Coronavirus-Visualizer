using Coronavirus.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Linq;

namespace Coronavirus.Services.API
{
    public class ApiWorldometers : ICoronavirusCountriesServices
    {
        public async Task<IEnumerable<CovidCountry>> GetTopCases(int Amount)
        {
            using (CoronavirusApiHttpClient client = new CoronavirusApiHttpClient())
            {
                //countries? sort = cases
                //cases, todayCases, deaths, todayDeaths, recovered, active, critica
                string uri = "/v3/covid-19/countries?sort=cases";

                IEnumerable<CovidCountry> covidCountries = await client.GetAsync<IEnumerable<CovidCountry>>(uri);
                return covidCountries.Take(Amount);
            }
        }
    }
}