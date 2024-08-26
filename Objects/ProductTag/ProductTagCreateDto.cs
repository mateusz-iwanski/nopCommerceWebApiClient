

namespace nopCommerceWebApiClient.Objects.ProductTag
{
    /// <summary>
    /// Product tag create Data Transfer Object
    /// </summary>
    public record ProductTagCreateDto : ProductTagDto
    {
        public new int Id { get; } = 0;
    }
}
