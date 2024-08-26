using nopCommerceWebApiClient.Objects.ProductTag;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Product
{
    public interface IProductTagService
    {
        [Post("/api/product/tag")]
        Task<ProductTagDto> CreateAsync(ProductTagCreateDto productTagDto);

        [Delete("/api/product/tag/{id}")]
        Task<HttpResponseMessage> DeleteAsync([AliasAs("id")]int id);

        [Get("/api/product/tag")]
        Task<IEnumerable<ProductTagDto>> GetAllAsync();

        [Get("/api/product/tag/details")]
        Task<IEnumerable<ProductTagDetailsDto>> GetAllDetailsAsync();

        [Get("/api/product/tag/{id}")]
        Task<ProductTagDto> GetByIdAsync([AliasAs("id")] int id);

        [Get("/api/product/tag/by-name/{tagName}")]
        Task<IEnumerable<ProductTagDto>> GetByTagAsync([AliasAs("tagName")] string tagName);

        [Put("/api/product/tag")]
        Task<HttpResponseMessage> UpdateAsync(ProductTagUpdateDto productTagDto);
    }
}
