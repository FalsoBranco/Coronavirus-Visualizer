using System;
using System.Collections.Generic;
using System.Text;

namespace Coronavirus.Models
{
    public class CovidCountry : Content
    {
        public string country { get; set; }
        public Countryinfo countryInfo { get; set; }

        public int todayCases { get; set; }

        public int todayDeaths { get; set; }

        public int continent { get; set; }
    }

    public class Countryinfo
    {
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public string flag { get; set; }
    }
}