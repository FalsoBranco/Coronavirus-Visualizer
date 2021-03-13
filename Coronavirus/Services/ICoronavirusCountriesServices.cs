using Coronavirus.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coronavirus.Services
{
    public interface ICoronavirusCountriesServices
    {
        Task<IEnumerable<CovidCountry>> GetTopCases(int Amount);
    }
}