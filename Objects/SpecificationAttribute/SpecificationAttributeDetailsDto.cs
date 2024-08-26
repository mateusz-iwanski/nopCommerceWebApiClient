using nopCommerceWebApiClient.Objects.SpecyficationAttribute;
using nopCommerceWebApiClient.Objects.SpecyficationAttributeGroup;

namespace nopCommerceWebApiClient.Objects.SpecificationAttribute
{
    public record SpecificationAttributeDetailsDto : SpecificationAttributeDto
    {
        public virtual SpecificationAttributeGroupDto? SpecificationAttributeGroup { get; init; }
        public virtual List<SpecificationAttributeOptionDto>? SpecificationAttributeOption { get; init; }
    }
}
