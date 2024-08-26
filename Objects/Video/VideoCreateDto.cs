

namespace nopCommerceWebApiClient.Objects.Video
{
    public record VideoCreateDto : VideoDto
    {
        public new int Id { get; } = 0;
    }
}
