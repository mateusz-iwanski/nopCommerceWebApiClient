




namespace nopCommerceWebApiClient.Objects.ProductManufacturer
{
    public record ProductManufacturerMappingDto
    {
        public virtual int Id { get; init; }

        /// <summary>
        /// ## ManufacturerId
        /// ### Gets or sets the manufacturer identifier
        /// </summary>
        public required virtual int ManufacturerId { get; init; }

        /// <summary>
        /// ## ProductId
        /// ### Gets or sets the product identifier
        /// </summary>
        public required virtual int ProductId { get; init; }

        /// <summary>
        /// ## IsFeaturedProduct
        /// ### Gets or sets a value indicating whether the product is a featured product
        /// *Default = false*
        /// </summary>
        public virtual bool IsFeaturedProduct { get; init; }

        /// <summary>
        /// ## DisplayOrder
        /// ### Gets or sets the display order
        /// *Default = 0*
        /// </summary>
        public virtual int DisplayOrder { get; init; }
    }
}
