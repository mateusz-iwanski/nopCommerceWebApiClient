using nopCommerceWebApiClient.Objects.SpecificationAttribute;
using nopCommerceWebApiClient.Objects.SpecyficationAttribute;

namespace nopCommerceWebApiClient.Objects.SpecificationAttributeOption
{
    public record SpecificationAttributeOptionDetailsDto : SpecificationAttributeOptionDto
    {
        public virtual SpecificationAttributeDto? SpecificationAttribute { get; init;  }
    }
}
