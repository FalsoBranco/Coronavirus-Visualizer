using System;
using System.Collections.Generic;
using System.Text;

namespace Coronavirus.Models
{
    public class CovidCountry
    {
        public int updated { get; set; }
        public string country { get; set; }
        public Countryinfo countryInfo { get; set; }
        public int cases { get; set; }
        public int todayCases { get; set; }
        public int deaths { get; set; }
        public int todayDeaths { get; set; }
        public int recovered { get; set; }
        public int todayRecovered { get; set; }
        public int active { get; set; }
        public int critical { get; set; }

        public int tests { get; set; }
        public int population { get; set; }
        public int continent { get; set; }
    }

    public class Countryinfo
    {
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public string flag { get; set; }
    }
}