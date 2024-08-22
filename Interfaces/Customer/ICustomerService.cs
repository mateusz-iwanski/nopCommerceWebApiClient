using nopCommerceWebApiClient.Objects.Customer;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Customer
{
    public record Password (string password);

    public interface ICustomerService
    {
        [Get("/api/customer")]
        Task<IEnumerable<Objects.Customer.CustomerDto>> GetAllAsync();

        [Get("/api/customer/{id}")]
        Task<CustomerDto> GetByIdAsync([AliasAs("id")] int id);

        [Post("/api/customer/pl")]
        Task<HttpResponseMessage> CreatePLAsync(CustomerCreatePLDto createCustomerDto);

        [Put("/api/customer/connect/address/{customerGuid}/{shippingAddressId}")]
        Task<HttpResponseMessage> ConnectToAddressAsync([AliasAs("customerGuid")] Guid customerGuid, [AliasAs("shippingAddressId")] int addressId);

        [Put("/api/customer/update/pl")]
        Task<Objects.Customer.CustomerDto> UpdatePLAsync(CustomerPLUpdateDto updateCustomerDto);

        [Put("/api/customer/update/password/{customerGuid}")]
        Task<HttpResponseMessage> UpdatePasswordAsync([AliasAs("customerGuid")] Guid customerGuid, [Body] Password newPassword);
    }
}

