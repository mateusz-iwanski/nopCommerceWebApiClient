

namespace nopCommerceWebApiClient.Objects.TierPrice
{
    public record TierPriceUpdateDto : TierPriceDto
    {
        public required override int Id { get; init; }
    }
}
