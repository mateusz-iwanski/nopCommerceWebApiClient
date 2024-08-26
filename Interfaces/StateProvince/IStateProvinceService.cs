using nopCommerceWebApiClient.Objects.State;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.StateProvince
{
    public interface IStateProvinceService
    {
        [Get("/api/state-province")]
        Task<IEnumerable<StateProvinceDto>> GetAllAsync();
    }
}
