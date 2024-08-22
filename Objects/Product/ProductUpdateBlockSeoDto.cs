namespace nopCommerceWebApiClient.Objects.Product
{
    public record ProductUpdateBlockSeoDto
    {
        /// <summary>
        /// ## MetaKeywords 
        /// ### Set the meta keywords.
        /// </summary>
        public virtual string? MetaKeywords { get; init; }

        /// <summary>
        /// ## MetaTitle
        /// ### Set the meta description.
        /// </summary>
        public virtual string? MetaTitle { get; init; }

        /// <summary>
        /// ## MetaDescription
        /// ### Meta description to be added to product page header.
        /// </summary>
        public virtual string? MetaDescription { get; init; }
    }
}
