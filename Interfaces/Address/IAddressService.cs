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

        [Put("/api/address/update-with-nip")]
        Task<AddressDetails> UpdateWithNipAsync(AddressUpdatePolishEnterprise updateAddressDto);
        
        [Post("/api/address/add")]        
        Task<AddressDetails> CreateAsync(AddressCreate addressDto);

        [Delete("/api/address/{id}")]
        Task DeleteAsync([AliasAs("id")] int id);

        [Put("/api/address")]
        Task<Objects.Address.Address> UpdateAsync(AddressUpdate updateAddressDto);

        [Get("/api/address/{id}")]
        Task<AddressDetails> GetByIdAsync([AliasAs("id")] int id);
    }
}
