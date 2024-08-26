

namespace nopCommerceWebApiClient.Objects.SpecyficationAttributeGroup
{
    public record SpecificationAttributeGroupUpdateDto : SpecificationAttributeGroupDto
    {        
        public required override int Id { get; init; }
    }
}
