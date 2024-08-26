

namespace nopCommerceWebApiClient.Objects.UrlRecord
{
    public record UrlRecordCreateDto : UrlRecordDto
    {
        public new int Id { get; } = 0;
    }
}
