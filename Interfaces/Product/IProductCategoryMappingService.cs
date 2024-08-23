using nopCommerceWebApiClient.Objects.ProductCategory;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Product
{
    public interface IProductCategoryMappingService
    {
        [Post("/api/category/mapping")]
        Task<ProductCategoryMappingDto> CreateAsync(ProductCategoryMappingCreateDto productCategoryMappingCreateDto);

        [Delete("/api/category/mapping/product/{productId}/category/{categoryId}")]
        Task<HttpResponseMessage> DeleteAsync([AliasAs("productId")] int productId,[AliasAs("categoryId")] int categoryId);

        [Get("/api/category/mapping")]
        Task<IEnumerable<ProductCategoryMappingDto>> GetAllAsync();

        [Get("/api/category/mapping/product/{productId}")]
        Task<IEnumerable<ProductCategoryMappingDto>> GetAllAssociateWithProductAsync([AliasAs("productId")] int productId);

        [Get("/api/category/mapping/category/{categoryId}")]
        Task<IEnumerable<ProductCategoryMappingDto>> GetAllAssociateWithCategoryAsync([AliasAs("categoryId")] int categoryId);
    }
}
