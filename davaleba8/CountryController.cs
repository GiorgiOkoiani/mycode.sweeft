using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CountryController : Controller
    {

        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }
        [HttpGet("getCountry")]
        public async Task<CountryModel> GetCountry() => await _countryService.GetCountry();

    }
}
