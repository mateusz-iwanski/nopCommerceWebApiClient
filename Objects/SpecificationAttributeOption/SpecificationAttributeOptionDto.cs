

namespace nopCommerceWebApiClient.Objects.SpecificationAttribute
{
    /// <summary>
    /// Option of specification attribute
    /// </summary>
    /// <remarks>
    /// Doc: https://docs.nopcommerce.com/en/running-your-store/catalog/products/specification-attributes.html
    /// Catalog → Attributes → Specification attributes.
    /// Note: Specification attribute need to have option! If not, it will be ignored.
    /// For example: Product (specification attribute group) -> color (specification attribute) -> red, blue, green (specification attribute option)
    /// </remarks>
    public record SpecificationAttributeOptionDto
    {
        public virtual int Id { get; init; }

        /// <summary>
        /// ## Name
        /// ### Get or set the name
        /// #### The Name of the specification attribute option.
        /// </summary>
        public required virtual string Name { get; init; }

        /// <summary>
        /// ## ColorSquaresRgb
        /// ### Get or set the color squares RGB
        /// #### Select the Specify color checkbox to choose the color to be used instead of the option's text name 
        /// #### Choose the RGB color that will be displayed to customers.
        /// *Default = null*
        /// </summary>
        public virtual string? ColorSquaresRgb { get; init; }

        /// <summary>
        /// ## SpecificationAttributeId
        /// ### Get or set the specification attribute identifier
        /// </summary>
        public required virtual int SpecificationAttributeId { get; init; }
        
        /// <summary>
        /// ## DisplayOrder
        /// ### Get or set the display order
        /// #### 1 represents the top of the list
        /// </summary>
        public virtual int DisplayOrder { get; init; }
    }
}
