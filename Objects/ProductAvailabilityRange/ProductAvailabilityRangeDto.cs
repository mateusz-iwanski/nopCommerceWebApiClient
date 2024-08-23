

namespace nopCommerceWebApiClient.Objects.ProductAvailabilityRange
{
    /// <summary>
    /// Represents a product availability range
    /// </summary>
    /// <remarks>
    /// Delivery dates are time ranges displaying approximate delivery time to a customer. 
    /// The delivery dates can be applied to products and displayed on the product details pages.
    /// Go to Configuration → Shipping → Dates and ranges.The two following panels will be displayed in the Dates and ranges window:
    /// </remarks>
    public record ProductAvailabilityRangeDto
    {
        public virtual int Id { get; set; }

        /// <summary>
        /// ## Name
        /// ### Gets or sets the name
        /// </summary>
        public required virtual string Name { get; set; }

        /// <summary>
        /// ## DisplayOrder
        /// ### Gets or sets the display order
        /// </summary>
        public virtual int DisplayOrder { get; set; }
    }
}
