using WebApp.Models;

namespace WebApp.Interfaces
{
    public interface ICountryService
    {
        Task<CountryModel> GetCountry();
    }
}
