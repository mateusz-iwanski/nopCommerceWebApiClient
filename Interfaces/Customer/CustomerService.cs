﻿using nopCommerceWebApiClient.Objects.Customer;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Customer
{
    public class Password
    {
        public string password { get; set; }
    }

    public interface ICustomerService
    {
        [Get("/api/customer")]
        Task<IEnumerable<Objects.Customer.Customer>> GetAllAsync();

        [Post("/api/customer/pl")]
        Task<string> CreatePLAsync(CustomerCreatePL createCustomerDto);

        [Put("/api/customer/connect/address/{customerGuid}/{shippingAddressId}")]
        Task ConnectToAddressAsync([AliasAs("customerGuid")] Guid customerGuid, [AliasAs("shippingAddressId")] int addressId);

        [Put("/api/customer/update/pl")]
        Task<Objects.Customer.Customer> UpdatePLAsync(CustomerPLUpdate updateCustomerDto);

        [Put("/api/customer/update/password/{customerGuid}")]
        Task UpdatePasswordAsync([AliasAs("customerGuid")] Guid customerGuid, [Body] Password newPassword);
    }
}

