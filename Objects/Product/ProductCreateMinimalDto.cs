

namespace nopCommerceWebApiClient.Objects.Product
{
    /// <summary>
    /// ProductCreateMinimalDto uses for creating a new product
    /// </summary>
    /// <remarks>
    /// Only the required properties are included in this DTO
    /// </remarks>
    public record ProductCreateMinimalDto : ProductCreateDefault
    {
        /// <summary>
        /// ## Name
        /// ### Set the name
        /// </summary>
        //[Required]
        public string Name { get; init; }

        /// <summary>
        /// ## SKU
        /// ### Set the SKU
        /// </summary>
        //[Required]
        public string Sku { get; init; }

        /// <summary>
        /// ## Price
        /// ### Set the price
        /// #### The price of the product. You can manage currency by selecting Configuration > Currencies.
        /// </summary>
        //[Required]
        public decimal Price { get; init; }

        /// <summary>
        /// ## TaxCategoryId
        /// ### Set the tax category identifier
        /// #### Look on TaxCategory schema for more details.
        /// </summary>
        //[Required]
        public int TaxCategoryId { get; init; }

        /// <summary>
        /// ## Weight
        /// ### Set the weight
        /// #### To set mesasures go to Configuration → Shipping → Measures 
        /// </summary>
        //[Required]
        public decimal Weight { get; init; }

        /// <summary>
        /// ## Length
        /// ### Set the length
        /// #### To set mesasures go to Configuration → Shipping → Measures 
        /// </summary>
        //[Required]
        public decimal Length { get; init; }

        /// <summary>
        /// ## Width
        /// ### Set the width
        /// #### To set mesasures go to Configuration → Shipping → Measures 
        /// </summary>
        //[Required]
        public decimal Width { get; init; }

        /// <summary>
        /// ## Height
        /// ### Set the height
        /// #### To set mesasures go to Configuration → Shipping → Measures 
        /// </summary>
        //[Required]
        public decimal Height { get; init; }

    }
}
