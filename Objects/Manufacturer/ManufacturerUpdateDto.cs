

namespace nopCommerceWebApiClient.Objects.Manufacturer
{
    public record ManufacturerUpdateDto : ManufacturerDto
    {        
        public required new int Id { get; init; }
        public override DateTime CreatedOnUtc { get; init; }

        public new DateTime UpdatedOnUtc { get; } = DateTime.Now;
    }
}
