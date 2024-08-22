namespace nopCommerceWebApiClient.Objects.Language
{
    /// <summary>
    /// Language Data Transfer Object
    /// </summary>
    /// <remarks>
    /// This object should be used only for the get method in controller
    /// </remarks>
    public record LanguageDto
    {
        public int Id { get; init; }

        /// <summary>
        /// Gets the name
        /// </summary>
        public string Name { get; init; } = null!;

        /// <summary>
        /// Gets the language culture
        /// </summary>
        public string LanguageCulture { get; init; } = null!;

        /// <summary>
        /// Gets the unique SEO code
        /// </summary>
        public string? UniqueSeoCode { get; init; }

        /// <summary>
        /// Gets the flag image file name
        /// </summary>
        public string? FlagImageFileName { get; init; }

        /// <summary>
        /// Gets a value indicating whether the language supports "Right-to-left"
        /// </summary>
        public bool Rtl { get; init; }

        /// <summary>
        /// Gets a value indicating whether the entity is limited/restricted to certain stores
        /// </summary>
        public bool LimitedToStores { get; init; }

        /// <summary>
        /// Gets the identifier of the default currency for this language; 0 is set when we use the default currency display order
        /// </summary>
        public int DefaultCurrencyId { get; init; }

        /// <summary>
        /// Gets a value indicating whether the language is published
        /// </summary>
        public bool Published { get; init; }

        /// <summary>
        /// Gets the display order
        /// </summary>
        public int DisplayOrder { get; init; }
    }
}
