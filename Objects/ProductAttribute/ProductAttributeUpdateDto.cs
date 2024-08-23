

namespace nopCommerceWebApiClient.Objects.ProductAttribute
{
    public record ProductAttributeUpdateDto : ProductAttributeDto
    {
        public required new int Id { get; init; }   
    }
}
