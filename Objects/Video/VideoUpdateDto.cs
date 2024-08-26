

namespace nopCommerceWebApiClient.Objects.Video
{
    public record VideoUpdateDto : VideoDto
    {
        public required override int Id { get; init; }
    }
}
