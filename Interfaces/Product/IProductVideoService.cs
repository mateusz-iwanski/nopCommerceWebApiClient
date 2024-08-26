using nopCommerceWebApiClient.Objects.ProductVideo;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Product
{
    public interface IProductVideoService
    {
        [Post("/api/product/videos")]
        Task<ProductVideoDto> CreateAsync(ProductVideoCreateDto productVideoCreateDto);

        [Delete("/api/product/videos/{id}")]
        Task<HttpResponseMessage> DeleteAsync([AliasAs("id")] int id);

        [Get("/api/product/videos")]
        Task<IEnumerable<ProductVideoDto>> GetAllAsync();

        [Get("/api/product/videos/{id}")]
        Task<ProductVideoDto> GetByIdAsync([AliasAs("id")] int id);

        [Get("/api/product/videos/product/{productId}")]
        Task<ProductVideoDto> GetByProductIdAsync([AliasAs("productId")] int productId);

        [Get("/api/product/videos/video/{videoId}")]
        Task<ProductVideoDto> GetByVideoIdAsync([AliasAs("videoId")] int videoId);

        [Put("/api/product/videos")]
        Task<HttpResponseMessage> UpdateAsync(ProductVideoUpdateDto productVideoUpdateDto);
    }
}
