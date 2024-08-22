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
        Task<HttpResponseMessage> CreateWithNipAsync(AddressCreatePolishEnterpriseDto newAdressDto);

        [Put("/api/address/update-with-nip")]
        Task<AddressDetailsDto> UpdateWithNipAsync(AddressUpdatePolishEnterpriseDto updateAddressDto);
        
        [Post("/api/address/add")]        
        Task<AddressDetailsDto> CreateAsync(AddressCreateDto addressDto);

        [Delete("/api/address/{id}")]
        Task<HttpResponseMessage> DeleteAsync([AliasAs("id")] int id);

        [Put("/api/address")]
        Task<Objects.Address.AddressDto> UpdateAsync(AddressUpdateDto updateAddressDto);

        [Get("/api/address/{id}")]
        Task<AddressDetailsDto> GetByIdAsync([AliasAs("id")] int id);
    }
}
