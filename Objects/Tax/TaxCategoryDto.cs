namespace nopCommerceWebApiClient.Objects.TaxCategory
{
    /// <summary>
    /// Tax Cateogry Data Transfer Object
    /// </summary>
    /// <remarks>
    /// This object should be used only for the get method in controller
    /// </remarks>
    public record TaxCategoryDto
    {

        public int Id { get; init; }

        /// <summary>
        /// Gets the name
        /// </summary>
        public string Name { get; init; }

        /// <summary>
        /// Gets the display order
        /// </summary>
        public int DisplayOrder { get; init; }
    }
}
