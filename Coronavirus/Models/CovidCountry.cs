using System;
using System.Collections.Generic;
using System.Text;

namespace Coronavirus.Models
{
    public class CovidCountry : Content
    {
        public string Country { get; set; }
        public Countryinfo CountryInfo { get; set; }

        public long TodayCases { get; set; }

        public long TodayDeaths { get; set; }

        public string Continent { get; set; }
    }

    public class Countryinfo
    {
        public string Iso2 { get; set; }
        public string Iso3 { get; set; }
        public string Flag { get; set; }
    }
}