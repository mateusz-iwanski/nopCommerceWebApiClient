using nopCommerceWebApiClient.Objects.Customer;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Customer
{
    public interface ICustomerRoleService
    {
        [Get("/api/customer/role")]
        Task<IEnumerable<CustomerRoleDto>> GetAllAsync();
    }
}
