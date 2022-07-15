using WebApp.Interfaces;
using WebApp.Models;

namespace WebApp.Services
{

    public class CountryService : ICountryService
    {
        [HttpGet]


        public async Task<CountryModel> GetCountry()
        {
            CountryModelcountryObject = new CountryModel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://restcountries.com/v3.1/all"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    countryObject = JsonConvert.DeserializeObject<CountryModel>(apiResponse);
                }
            }
            return countryObject;
        }
    }
}
