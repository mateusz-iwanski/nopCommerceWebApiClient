using nopCommerceWebApiClient;
using nopCommerceWebApiClient.Objects.Address;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Address
{    
    public interface IAddressService
    {
        [Get("/api/address")]
        Task<IEnumerable<AddressDetails>> GetAllAsync();

        [Post("/api/address/add-with-nip")]
        Task<AddressDetails> CreateWithNipAsync(AddressCreatePolishEnterprise newAdressDto);

        [Post("/api/address/update-with-nip")]
        Task<AddressDetails> UpdateWithNipAsync(AddressUpdatePolishEnterpriseDto updateAddressDto);
        
        [Post("/api/address/add")]        
        Task<AddressDetails> CreateAsync(AddressCreate addressDto);

        [Delete("/api/address/{id}")]
        Task<bool> DeleteAsync(int id);

        [Put("/api/address")]
        Task<AddressDetails> UpdateAsync(AddressUpdateDto updateAddressDto);

        [Get("/api/address/{id}")]
        Task<AddressDetails> GetByIdAsync(int id);
    }
}
