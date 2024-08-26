

namespace nopCommerceWebApiClient.Objects.SpecyficationAttribute
{
    public record SpecificationAttributeUpdateDto : SpecificationAttributeDto
    {
        public required override int Id { get; init; }  
    }
}
