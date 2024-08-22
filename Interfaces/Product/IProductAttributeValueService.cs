using nopCommerceWebApiClient.Objects.ProductAttributeValue;
using Refit;
using System;

namespace nopCommerceWebApiClient.Interfaces.Product
{
    public interface IProductAttributeValueService
    {
        [Post("/api/product/attribute/value/add-to-attribute/{attributeId}")]
        Task<HttpResponseMessage> CreateAsync([AliasAs("attributeId")] int attributeId, ProductAttributeValueCreateDto productAttributeValueCreateDto);

        [Delete("/api/product/attribute/value/{id}")]
        Task<HttpResponseMessage> DeleteAsync([AliasAs("id")] int id);

        [Get("/api/product/attribute/value")]
        Task<IEnumerable<ProductAttributeValueDto>> GetAllAsync();

        [Get("/api/product/attribute/value/{id}")]
        Task<ProductAttributeValueDto> GetByIdAsync([AliasAs("id")] int id);

        [Put("/api/product/attribute/value")]
        Task<HttpResponseMessage> UpdateAsync(ProductAttributeValueUpdateDto productAttributeValueUpdateDto);
    }
}
