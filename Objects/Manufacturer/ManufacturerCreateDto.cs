

namespace nopCommerceWebApiClient.Objects.Manufacturer
{
    public record ManufacturerCreateDto : ManufacturerDto
    {
        public new int Id { get; } = 0;
        
        public new DateTime CreatedOnUtc { get; } = DateTime.Now;

        public new DateTime UpdatedOnUtc { get; } = DateTime.Now;
    }
}
