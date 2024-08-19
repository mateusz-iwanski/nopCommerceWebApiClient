using nopCommerceWebApiClient;
using nopCommerceWebApiClient.Objects.Address;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Address
{    
    public interface IAddressService
    {
        [Get("/api/address")]
        Task<IEnumerable<AddressDetailsDto>> GetAllAsync();

        [Post("/api/address/add-with-nip")]
        Task<AddressCreatePolishEnterpriseDto> CreateWithNipAsync(AddressCreatePolishEnterpriseDto newAdressDto);

        [Post("/api/address/update-with-nip")]
        Task<Objects.Address.Address> UpdateWithNipAsync(AddressUpdatePolishEnterpriseDto updateAddressDto);
        
        [Post("/api/address/add")]        
        Task<Objects.Address.Address> CreateAsync(AddressCreate addressDto);

        [Delete("/api/address/{id}")]
        Task<bool> DeleteAsync(int id);

        [Put("/api/address")]
        Task<Objects.Address.Address> UpdateAsync(AddressUpdateDto updateAddressDto);

        [Get("/api/address/{id}")]
        Task<AddressDetailsDto> GetByIdAsync(int id);
    }
}
