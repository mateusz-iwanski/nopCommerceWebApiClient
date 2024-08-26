

namespace nopCommerceWebApiClient.Objects.SpecyficationAttributeGroup
{
    public record SpecificationAttributeGroupDto
    {
        public virtual int Id { get; init; }

        /// <summary>
        /// ## Name
        /// ### Gets or sets the name
        /// </summary>
        public required string Name { get; init; }

        /// <summary>
        /// ## DisplayOrder
        /// ### Gets or sets the display order
        /// #### 1 represents the top of the list
        /// *Default = 0*
        /// </summary>
        public int DisplayOrder { get; init; }
    }
}
