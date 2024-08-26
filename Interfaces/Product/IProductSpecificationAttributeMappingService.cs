using nopCommerceWebApiClient.Objects.ProductSpecificationAttributeMapping;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Product
{
    public interface IProductSpecificationAttributeMappingService
    {
        [Post("/api/product/specification-attribute/mapping")]
        Task<HttpResponseMessage> CreateAsync(ProductSpecificationAttributeMappingCreateDto productSpecificationAttributeMappingCreateDto);

        [Delete("/api/product/specification-attribute/mapping/{id}")]
        Task<HttpResponseMessage> DeleteAsync([AliasAs("id")] int id);

        [Get("/api/product/specification-attribute/mapping")]
        Task<IEnumerable<ProductSpecificationAttributeMappingDto>> GetAllAsync();

        [Get("/api/product/specification-attribute/mapping/{id}")]
        Task<ProductSpecificationAttributeMappingDto> GetByIdAsync([AliasAs("id")] int id);

        [Get("/api/product/specification-attribute/mapping/product/{productId}")]
        Task<IEnumerable<ProductSpecificationAttributeMappingDto>> GetByProductIdAsync([AliasAs("productId")] int productId);

        [Put("/api/product/specification-attribute/mapping/")]
        Task<HttpResponseMessage> UpdateAsync(ProductSpecificationAttributeMappingUpdateDto productSpecificationAttributeMappingUpdateDto);
    }
}
