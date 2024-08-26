

using System.Runtime.CompilerServices;

namespace nopCommerceWebApiClient.Objects.ProductPicture
{
    public record ProductPictureMappingUpdateDto : ProductPictureMappingDto
    {
        public required override int Id { get; init; }
    }
}
