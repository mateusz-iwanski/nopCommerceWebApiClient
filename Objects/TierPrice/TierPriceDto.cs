



namespace nopCommerceWebApiClient.Objects.TierPrice
{
    public record TierPriceDto
    {
        public virtual int Id { get; init; }

        /// <summary>
        /// ## CustomerRoleId
        /// ### If null, applies to all customer roles.
        /// </summary>
        public virtual int? CustomerRoleId { get; init; }

        /// <summary>
        /// ## ProductId
        /// ### Gets or sets the product identifier.
        /// </summary>
        public required virtual int ProductId { get; init; }

        /// <summary>
        /// ## StoreId
        /// ### Leave empty if not multi-store. Default storeId is 0.
        /// *default value: 0*
        /// </summary>
        public required virtual int? StoreId { get; init; }

        /// <summary>
        /// ## Quantity
        /// ### Gets or sets the quantity.
        /// </summary>
        public required virtual int Quantity { get; init; }

        /// <summary>
        /// ## Price
        /// ### Gets or sets the price.
        /// </summary>
        public required virtual decimal Price { get; init; }

        /// <summary>
        /// ## StartDateTimeUtc 
        /// ### Gets or sets the start date and time in UTC.
        /// #### Can be null. Represents the start date and time in UTC.
        /// </summary>
        public virtual DateTime? StartDateTimeUtc { get; init; }

        /// <summary>
        /// ## EndDateTimeUtc
        /// ### Gets or sets the end date and time in UTC.
        /// #### Can be null. Represents the end date and time in UTC.
        /// </summary>
        public virtual DateTime? EndDateTimeUtc { get; init; }
    }
}
