

namespace nopCommerceWebApiClient.Objects.ProductTag
{
    /// <summary>
    /// Product tag Data Transfer Object
    /// </summary>
    /// <remarks>
    /// Should be used only for the get method in controller
    /// </remarks>
    public record ProductTagDto
    {
        public virtual int Id { get; init; }

        /// <summary>
        /// ## Name
        /// ### Gets or sets the name
        /// </summary>
        public required virtual string Name { get; init; }
    }
}
