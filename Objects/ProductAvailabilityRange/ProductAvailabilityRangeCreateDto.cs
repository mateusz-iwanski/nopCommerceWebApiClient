using System;

using System.Runtime.InteropServices.Marshalling;


namespace nopCommerceWebApiClient.Objects.ProductAvailabilityRange
{
    /// <summary>
    /// <c>ProductAvailabilityRangeCreateDto</c> uses for creating product availability range
    /// </summary>
    /// <remarks>
    /// Delivery dates are time ranges displaying approximate delivery time to a customer. 
    /// The delivery dates can be applied to products and displayed on the product details pages.
    /// Go to Configuration → Shipping → Dates and ranges.The two following panels will be displayed in the Dates and ranges window:
    /// </remarks>
    public record ProductAvailabilityRangeCreateDto : ProductAvailabilityRangeDto
    {
        public new int Id { get; }

        /// <summary>
        /// Set the display order
        /// </summary>
        //public new int DisplayOrder { get; }
    }
}
