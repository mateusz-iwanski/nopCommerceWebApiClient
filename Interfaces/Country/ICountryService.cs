
using nopCommerceWebApiClient.Objects.Country;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Country
{
    public interface ICountryService
    {
        [Get("/api/country")]
        Task<IEnumerable<Objects.Country.Country>> GetAllAsync();
    }

}
