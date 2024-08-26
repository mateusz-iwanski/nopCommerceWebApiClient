


namespace nopCommerceWebApiClient.Objects.ProductSpecificationAttributeMapping
{
    /// <summary>
    /// Product specification attribute mapping DTO
    /// </summary>
    /// <reamarks>
    /// Note: Specification attribute need to have value! If not, it will be ignored in Product.
    /// For example: Product (specification attribute group) -> color (specification attribute) -> red, blue, green (specification attribute option)
    /// </reamarks>
    public record ProductSpecificationAttributeMappingDto
    {
        public virtual int Id { get; init; }

        /// <summary>
        /// ## CustomValue
        /// #### I don't know what this is for, always set to null
        /// *Default = null*
        /// </summary>
        public virtual string? CustomValue { get; init; } 

        /// <summary>
        /// ## ProductId
        /// ### Gets or sets the product identifier
        /// </summary>
        public required virtual int ProductId { get; init; }

        /// <summary>
        /// ## SpecificationAttributeOptionId
        /// ### Gets or sets the specification attribute option identifier
        /// #### Note: Specification attribute need to have value! If not, it will be ignored in Product.
        /// #### For example: Product (specification attribute group) -> color (specification attribute) -> red, blue, green (specification attribute option)
        /// </summary>
        public required virtual int SpecificationAttributeOptionId { get; init; }

        /// <summary>
        /// ## AttributeTypeId
        /// ### Gets or sets the attribute type identifier
        /// #### If is 0, it will set as Option type
        /// #### Always set to 0
        /// *Default = 0*
        /// </summary>
        public virtual int AttributeTypeId { get; } = 0;

        /// <summary>
        /// ## AllowFiltering
        /// ### Gets or sets a value indicating whether the product attribute is allowed to filter
        /// #### Allow product filtering by this attribute.
        /// *Default = false*
        /// </summary>
        public virtual bool AllowFiltering { get; init; }

        /// <summary>
        /// ## ShowOnProductPage
        /// ### Gets or sets a value indicating whether the product attribute is shown on the product page
        /// #### The value of the specification attribute. Be visible on the product page.
        /// *Default = false*
        /// </summary>
        public virtual bool ShowOnProductPage { get; init; }

        /// <summary>
        /// ## DisplayOrder
        /// ### Gets or sets the display order
        /// #### 1 represents the top of the list
        /// *Default = 0*
        /// </summary>
        public virtual int DisplayOrder { get; init; }

    }
}
