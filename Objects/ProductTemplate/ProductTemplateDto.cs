namespace nopCommerceWebApiClient.Objects.ProductTemplate
{
    /// <summary>
    /// Represents a product template.
    /// </summary>
    /// <remarks>
    /// In nopCommerce, you can specify an alternate layout template for a category, manufacturer, 
    /// product, and topic. You can see a list of the existing templates on the System → Templates page.
    /// Doc: https://docs.nopcommerce.com/en/running-your-store/system-administration/templates.html
    /// </remarks>
    public record ProductTemplateDto
    {
        public virtual int Id { get; init; }

        /// <summary>
        /// ## Name
        /// ### Gets or sets the template name
        /// </summary>
        public virtual string Name { get; init; }

        /// <summary>
        /// ## View path
        /// ### Gets or sets the view path
        /// </summary>
        public virtual string ViewPath { get; init; }

        /// <summary>
        /// ## Display order
        /// ### Gets or sets the display order
        /// </summary>
        public virtual int DisplayOrder { get; init; }

        /// <summary>
        /// ## IgnoredProductTypes
        /// ### Sets a comma-separated list of product type identifiers NOT supported by this template
        /// </summary>
        public virtual string IgnoredProductTypes { get; init; }

    }
}
