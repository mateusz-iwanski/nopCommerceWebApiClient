using System.Text.Json.Serialization;

namespace nopCommerceWebApiClient.Objects.Product
{
    /// <summary>
    /// ProductCreateMinimalDto uses for creating a new product
    /// </summary>
    /// <remarks>
    /// Only the required properties are included in this DTO
    /// </remarks>
    public record ProductCreateMinimalDto //: ProductCreateDefault
    {
        /// <summary>
        /// Set the name
        /// </summary>
        public required string Name { get; init; }

        /// <summary>
        /// Set the SKU
        /// </summary>
        public required string Sku { get; init; }

        /// <summary>
        /// Set the price
        /// The price of the product. You can manage currency by selecting Configuration > Currencies.
        /// </summary>
        public required decimal Price { get; init; }

        /// <summary>
        /// Set the tax category identifier
        /// Look on TaxCategory schema for more details.        
        /// </summary>
        /// <remarks>
        /// We can set the tax category after the object is initialized.
        /// </remarks>
        public required int TaxCategoryId { get; init; }

        /// <summary>
        /// Set the weight
        /// To set mesasures go to Configuration → Shipping → Measures 
        /// </summary>
        public required decimal Weight { get; init; }

        /// <summary>
        /// Set the length
        /// To set mesasures go to Configuration → Shipping → Measures 
        /// </summary>
        public required decimal Length { get; init; }

        /// <summary>
        /// Set the width
        /// To set mesasures go to Configuration → Shipping → Measures 
        /// </summary>
        public required decimal Width { get; init; }

        /// <summary>
        /// Set the height (depth)
        /// To set mesasures go to Configuration → Shipping → Measures 
        /// </summary>
        public required decimal Height { get; init; }

        /// <summary>
        /// Set the Global Trade Item Number (GTIN). 
        /// These identifiers include UPC (in North America), EAN (in Europe), JAN (in Japan), and ISBN (for books).
        /// *Default = null*
        /// </summary>
        /// <remarks>
        /// When created by ProductCreateMinimalDto (this DTO), Gtin is always set to null.
        /// It is only used inside this replicator.
        public required string? Gtin { get; init; }

        [JsonIgnore]
        /// <summary>
        /// Virtual field used to read the correct category from the nopCommerce database.  
        /// This value is set by external service data.
        /// </summary>
        public decimal? VatValue { get; init; }

        [JsonIgnore]
        /// <summary>
        /// Virtual field used to read the correct price, etc from subiekt gt.  
        /// </summary>
        public int? SubiektGtId { get; init; }
    }
}
