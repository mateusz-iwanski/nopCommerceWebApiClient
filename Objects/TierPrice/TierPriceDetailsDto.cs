using nopCommerceWebApiClient.Objects.Customer;
using nopCommerceWebApiClient.Objects.Product;

namespace nopCommerceWebApiClient.Objects.TierPrice
{
    public record TierPriceDetailsDto : TierPriceDto
    {
        public virtual CustomerRoleDto? CustomerRole { get; init; }
        public virtual ProductDto Product { get; init; }
    }
}
