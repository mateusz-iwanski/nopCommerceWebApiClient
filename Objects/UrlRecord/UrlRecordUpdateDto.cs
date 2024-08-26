


namespace nopCommerceWebApiClient.Objects.UrlRecord
{
    public record UrlRecordUpdateDto : UrlRecordDto
    {
        public required override int Id { get; init; }
    }
}

