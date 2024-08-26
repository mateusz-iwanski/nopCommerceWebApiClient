namespace nopCommerceWebApiClient.Objects.ProductSpecificationAttributeMapping
{
    public record ProductSpecificationAttributeMappingUpdateDto : ProductSpecificationAttributeMappingDto
    {
        public required override int Id { get; init; }
    }
}
