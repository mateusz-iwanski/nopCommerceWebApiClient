using nopCommerceWebApiClient.Objects.ProductManufacturer;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Product
{
    public interface IProductManufaturerMappingService
    {
        [Post("/api/manufacturer/mapping")]
        Task<HttpResponseMessage> CreateAsync(ProductManufacturerMappingCreateDto productManufacturerMappingCreateDto);

        [Delete("/api/manufacturer/mapping/{id}")]
        Task<HttpResponseMessage> DeleteAsync([AliasAs("id")] int id);

        [Get("/api/manufacturer/mapping")]
        Task<IEnumerable<ProductManufacturerMappingDto>> GetAllAsync();

        [Get("/api/manufacturer/mapping/{id}")]
        Task<ProductManufacturerMappingDto> GetByIdAsync([AliasAs("id")] int id);

        [Get("/api/manufacturer/mapping/manufacturer/{manufacturerId}")]
        Task<IEnumerable<ProductManufacturerMappingDto>> GetByManufacturerId([AliasAs("manufacturerId")] int manufacturerId);

        [Get("/api/manufacturer/mapping/product/{productId}")]
        Task<IEnumerable<ProductManufacturerMappingDto>> GetByProductId([AliasAs("productId")] int productId);
    }
}
