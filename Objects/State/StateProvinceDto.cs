using nopCommerceWebApiClient.Objects.Country;

namespace nopCommerceWebApiClient.Objects.State
{
    /// <summary>
    /// StateProvince Data Transfer Object
    /// </summary>
    /// <remarks>
    /// This object should be used only for the get method in controller
    /// </remarks>
    public record StateProvinceDto
    {
        public virtual int Id { get; init; }

        /// <summary>
        /// Gets the name
        /// </summary>
        public virtual string Name { get; init; }

        /// <summary>
        /// Gets the abbreviation
        /// </summary>
        public virtual string? Abbreviation { get; init; }

        /// <summary>
        /// Gets the country identifier
        /// </summary>
        public virtual int CountryId { get; init; }

        /// <summary>
        /// Gets a value indicating whether the entity is published
        /// </summary>
        public virtual bool Published { get; init; }

        /// <summary>
        /// Gets the display order
        /// </summary>
        public virtual int DisplayOrder { get; init; }

        /// <summary>
        /// Gets country object
        /// </summary>
        public virtual Country.CountryDto Country { get; init; }
    }
}
