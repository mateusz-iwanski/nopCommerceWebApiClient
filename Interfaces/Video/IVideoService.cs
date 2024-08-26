
using nopCommerceWebApiClient.Objects.Video;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Video
{
    public interface IVideoService
    {
        [Post("/api/video")]
        Task<VideoDto> CreateAsync(VideoCreateDto createVideoDto);

        [Delete("/api/video/{id}")]
        Task<HttpResponseMessage> DeleteAsync([AliasAs("id")] int id);

        [Get("/api/video")]
        Task<IEnumerable<VideoDto>> GetAllAsync();

        [Get("/api/video/{id}")]
        Task<VideoDto> GetByIdAsync([AliasAs("id")] int id);

        [Get("/api/video/url/{url}")]
        Task<VideoDto> GetByUrlAsync([AliasAs("url")] string url);

        [Put("/api/video")]
        Task<VideoDto> UpdateAsync(VideoUpdateDto updateVideoDto);
    }
}
