using nopCommerceWebApiClient.Objects.AddressAttribute;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Address
{
    public interface IAddressAttributeService
    {
        [Get("/api/addressattribute")]
        Task<IEnumerable<AddressAttributeDto>> GetAllAsync();
    }

    
}
