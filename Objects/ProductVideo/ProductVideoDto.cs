

namespace nopCommerceWebApiClient.Objects.ProductVideo
{
    /// <summary>
    /// Associate video url with product
    /// </summary>
    public record ProductVideoDto
    {
        public virtual int Id { get; init; }

        /// <summary>
        /// ## VideoId
        /// ### Gets or set the video identifier
        /// </summary>
        public required virtual int VideoId { get; init; }

        /// <summary>
        /// ## ProductId
        /// ### Gets or set the product identifier
        /// </summary>
        public required virtual int ProductId { get; init; }

        /// <summary>
        /// ## DisplayOrder
        /// ### Gets or set the display order`
        /// #### 1 represents the top of the list
        /// *Default = 0*
        /// </summary>
        public virtual int DisplayOrder { get; init; }
    }
}
