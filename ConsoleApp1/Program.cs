using Coronavirus.Models;
using Coronavirus.Services.API;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        private static async System.Threading.Tasks.Task Main(string[] args)
        {
            ApiWorldometers covid = new ApiWorldometers();

            var covidAll = await covid.GetCovidAllCountriesAsync();
            Console.WriteLine(covidAll);
        }
    }
}