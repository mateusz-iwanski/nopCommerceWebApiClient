namespace nopCommerceWebApiClient.Objects.UrlRecord
{
    /// <summary>
    /// UrlRecord is used to store SEO-friendly URLs for entities with an SEO category.
    /// </summary>
    public record UrlRecordDto
    {
        public virtual int Id { get; init; }

        /// <summary>
        /// ## EntityName
        /// ### Gets or set the entity name
        /// #### Every entity which uses SEO friendly url, for example: Product, CategoryDto, Manufacturer, etc.
        /// </summary>
        public required virtual string EntityName { get; init; }

        /// <summary>
        /// ## Slug 
        /// ### Gets or set friendly url
        /// </summary>
        public required virtual string Slug { get; init; }

        /// <summary>
        /// ## EntityId
        /// ### Gets or set the entity id
        /// #### For example: if EntityName = "Product" then EntityId = ProductId
        /// </summary>
        public required virtual int EntityId { get; init; }

        /// <summary>
        /// ## IsActive 
        /// ### Gets or set a value indicating whether the url record is active
        /// *Default = false*
        /// </summary>
        public virtual bool IsActive { get; init; }

        /// <summary>
        /// ## LanguageId
        /// ### Gets or set the language identifier
        /// *Default = 0*
        /// </summary>
        public virtual int LanguageId { get; init; }        
    }
}
