

namespace nopCommerceWebApiClient.Objects.ProductCategory
{
    /// <summary>
    /// Product category mapping DTO
    /// </summary>
    /// <remarks>
    /// Associate a product with a category
    /// </remarks>
    public record ProductCategoryMappingDto
    {

        public virtual int Id { get; init; }

        /// <summary>
        /// Gets or set the category identifier
        /// </summary>
        public required virtual int CategoryId { get; init; }

        /// <summary>
        /// Gets or set the product identifier
        /// </summary>
        public required virtual int ProductId { get; init; }

        /// <summary>
        /// Gets or set a value indicating whether the product is featured
        /// *Default = false*
        /// </summary>
        public virtual bool IsFeaturedProduct { get; init; }

        /// <summary>
        /// Gets or set the display order        
        /// </summary>
        /// <remarks>
        /// *Default = false*
        /// </remarks>
        public virtual int DisplayOrder { get; init; }

    }
}
