

namespace nopCommerceWebApiClient.Objects.Product
{
    public record ProductUpdateBlockShippingDto
    {
        /// <summary>
        /// ## IsShipEnabled
        /// ### Set a value indicating whether the entity is ship enabled.
        /// #### Check if the product can be shipped. You can manage shipping settings by selecting Configuration > Shipping.
        /// *Default = true*
        /// </remaks>
        public virtual bool IsShipEnabled { get; init; }

        /// <summary>
        /// ## IsFreeShipping
        /// ### Set a value indicating whether the entity is free shipping.
        /// #### Check if this product comes with FREE shipping.
        /// *Default = false*
        /// </summary>
        public virtual bool IsFreeShipping { get; init; }

        /// <summary>
        /// ## ShipSeparately
        /// ### Set a value this product should be shipped separately (each item).
        /// #### Check if the product should be shipped separately from other products (in single box). 
        /// #### But notice that if the order includes several items of this product, 
        /// #### all of them will be shipped in single box.
        /// *Default = false*
        /// </summary>
        public virtual bool ShipSeparately { get; init; }

        /// <summary>
        /// ## AdditionalShippingCharge
        /// ### Set the additional shipping charge.
        /// *Default = 10m.*
        /// </summary>
        public virtual decimal AdditionalShippingCharge { get; init; }

        /// <summary>
        /// ## DeliveryDateId
        /// ### Set a delivery date identifier
        /// #### Choose a delivery date which will be displayed in the public store. 
        /// #### You can manage delivery dates by selecting Configuration > Shipping > Dates and ranges.
        /// *Default = 0*
        /// </summary>
        public virtual int DeliveryDateId { get; init; }

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
