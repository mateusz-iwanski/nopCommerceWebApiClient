using nopCommerceWebApiClient.Objects.ProductAttribute;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Product
{
    public interface IProductAttributeService
    {
        [Post("/api/product/attribute")]
        Task<HttpResponseMessage> CreateAsync(ProductAttributeWithMappingCreateDto productAttributeWithMappingCreateDto);

        [Get("/api/product/attribute")]
        Task<IEnumerable<ProductAttributeDto>> GetAllAsync();

        [Get("/api/product/attribute/{id}")]
        Task<ProductAttributeDto> GetByIdAsync([AliasAs("id")] int id);

        [Put("/api/product/attribute")]
        Task<HttpResponseMessage> UpdateAsync(ProductAttributeUpdateDto productAttributeDtoUpdate);
    }    
}
