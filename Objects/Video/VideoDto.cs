

namespace nopCommerceWebApiClient.Objects.Video
{
    public record VideoDto
    {
        public virtual int Id { get; init; }

        /// <summary>
        /// ## VideoUrl
        /// ### Gets or sets the video URL
        /// </summary>
        public required virtual string VideoUrl { get; init; }
    }
}
