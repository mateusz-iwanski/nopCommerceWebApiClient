using nopCommerceWebApiClient.Objects.SpecificationAttribute;

namespace nopCommerceWebApiClient.Objects.SpecificationAttributeOption
{
    public record SpecificationAttributeOptionUpdateDto : SpecificationAttributeOptionDto
    {
        public required override int Id { get; init; }
    }
}
