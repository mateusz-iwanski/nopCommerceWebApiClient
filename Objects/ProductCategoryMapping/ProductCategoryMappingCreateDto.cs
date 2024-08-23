

namespace nopCommerceWebApiClient.Objects.ProductCategory
{
    public record ProductCategoryMappingCreateDto : ProductCategoryMappingDto
    {
        public new int Id { get; } = 0;
    }
}
