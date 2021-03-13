using Coronavirus.Models;
using Coronavirus.Services;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coronavirus.WPF.ViewsModels
{
    public class CoronavirusCountriesChartViewModel
    {
        private const int AMOUNT_OF_COUNTRIES = 10;
        private readonly ICoronavirusCountriesServices _coronavirusCountriesServices;

        public ChartValues<int> CoronavirusCountriesCaseCount { get; set; }
        public string[] CoronavirusCountryNames { get; set; }

        public CoronavirusCountriesChartViewModel(ICoronavirusCountriesServices coronavirusCountriesServices)
        {
            _coronavirusCountriesServices = coronavirusCountriesServices;
        }

        public static CoronavirusCountriesChartViewModel LoadViewModel(ICoronavirusCountriesServices coronavirusCountriesServices, Action<Task> onLoaded = null)
        {
            CoronavirusCountriesChartViewModel viewModel = new CoronavirusCountriesChartViewModel(coronavirusCountriesServices);
            viewModel.Load().ContinueWith(t => onLoaded?.Invoke(t));
            return viewModel;
        }

        public async Task Load()
        {
            IEnumerable<CovidCountry> countries = await _coronavirusCountriesServices.GetTopCases(AMOUNT_OF_COUNTRIES);
            CoronavirusCountriesCaseCount = new ChartValues<int>(countries.Select(c => c.Cases));
            CoronavirusCountryNames = countries.Select(c => c.Country).ToArray();
        }
    }
}