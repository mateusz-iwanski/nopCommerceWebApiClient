


namespace nopCommerceWebApiClient.Objects.Country
{
    /// <summary>
    /// CountryDto Data Transfer Object
    /// </summary>
    /// <remarks>
    /// This object should be used only for the get method in controller
    /// </remarks>
    public record CountryDto
    {
        public virtual int Id { get; init; }
        /// <summary>
        /// ## Name
        /// ### Gets the name
        /// </summary>
        public required virtual string Name { get; init; }

        /// <summary>
        /// ## TwoLetterIsoCode
        /// ### Gets a value indicating whether billing is allowed to this country
        /// </summary>
        //[Required]
        public required virtual string TwoLetterIsoCode { get; init; }

        /// <summary>
        /// ## ThreeLetterIsoCode
        /// ### Gets a value indicating whether shipping is allowed to this country
        /// *Defaul = null*
        /// </summary>
        public virtual string? ThreeLetterIsoCode { get; init; }

        /// <summary>
        /// ## AllowsBilling
        /// ### Gets the two letter ISO code
        /// *Default = true*
        /// </summary>
        public virtual bool AllowsBilling { get; init; }

        /// <summary>
        /// ## AllowsShipping
        /// ### Gets the three letter ISO code
        /// *Default = false*
        /// </summary>
        public virtual bool AllowsShipping { get; init; }

        /// <summary>
        /// ## NumericIsoCode
        /// ### Gets the numeric ISO code
        /// </summary>
        public virtual int NumericIsoCode { get; init; }

        /// <summary>
        /// ## SubjectToVat
        /// ### Gets a value indicating whether customers in this country must be charged EU VAT
        /// </summary>
        public virtual bool SubjectToVat { get; init; }

        /// <summary>
        /// ## Published
        /// ### Gets a value indicating whether the entity is published
        /// </summary>
        public virtual bool Published { get; init; }

        /// <summary>
        /// ## DisplayOrder
        /// ### Gets the display order
        /// *Default = 1*
        /// </summary>
        public virtual int DisplayOrder { get; init; }

        /// <summary>
        /// ## LimitedToStores
        /// ### Gets a value indicating whether the entity is limited/restricted to certain stores
        /// *Default = 0*
        /// </summary>
        public virtual bool LimitedToStores { get; init; }
    }
}
