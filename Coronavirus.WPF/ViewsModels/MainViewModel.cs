using Coronavirus.Services;
using Coronavirus.Services.API;
using Coronavirus.WPF.ViewsModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coronavirus.WPF
{
    public class MainViewModel
    {
        public CoronavirusCountriesChartViewModel CoronavirusCountriesChartViewModel { get; set; }

        public MainViewModel()
        {
            ICoronavirusCountriesServices coronavirusCountriesServices = new ApiWorldometers();
            CoronavirusCountriesChartViewModel = CoronavirusCountriesChartViewModel.LoadViewModel(coronavirusCountriesServices);
        }
    }
}