

namespace nopCommerceWebApiClient.Objects.ProductPicture
{
    public record ProductPictureMappingDto
    {
        public virtual int Id { get; init; }

        /// <summary>
        /// ## PictureId
        /// ### Gets or sets the picture identifier
        /// </summary>
        public required virtual int PictureId { get; init; }

        /// <summary>
        /// ## ProductId
        /// ### Gets or sets the product identifier
        /// </summary>
        public required virtual int ProductId { get; init; }
         
        /// <summary>
        /// ## DisplayOrder
        /// ### Gets or sets the display order
        /// #### The attribute display order. 1 represents the first item in the list.
        /// *Default = 0*
        /// </summary>
        public virtual int DisplayOrder { get; init; }

    }
}
