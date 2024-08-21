namespace nopCommerceWebApiClient.Objects.Currency
{
    public record Currency 
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public string CurrencyCode { get; init; }

        public string? DisplayLocale { get; init; }

        public string? CustomFormatting { get; init; }

        public decimal Rate { get; init; }

        public bool LimitedToStores { get; init; }

        public bool Published { get; init; }

        public int DisplayOrder { get; init; }

        public DateTime CreatedOnUtc { get; init; }

        public DateTime UpdatedOnUtc { get; init; }

        public int RoundingTypeId { get; init; }        
    }
}
