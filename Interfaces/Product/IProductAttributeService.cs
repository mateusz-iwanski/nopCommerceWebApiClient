using nopCommerceWebApiClient.Objects.ProductAttribute;
using nopCommerceWebApiClient.Objects.ProductAttributeMapping;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Product
{
    public interface IProductAttributeService
    {
        [Post("/api/product-attributes")]
        Task<(ProductAttributeDto, ProductProductAttributeMappingDto)> CreateAsync(ProductAttributeWithMappingCreateDto productAttributeWithMappingCreateDto);

        [Get("/api/product-attributes")]
        Task<IEnumerable<ProductAttributeDto>> GetAllAsync();

        [Get("/api/product-attributes/{id}")]
        Task<ProductAttributeDto> GetByIdAsync(int id);

        [Put("/api/product-attributes")]
        Task UpdateAsync(ProductAttributeUpdateDto productAttributeDtoUpdate);
    }    
}
