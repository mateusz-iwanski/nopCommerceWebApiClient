using nopCommerceWebApiClient.Objects.ProductPicture;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Product
{
    public interface IProductPictureMappingService
    {
        [Post("/api/picture/mapping")]
        Task<ProductPictureMappingDto> Create(ProductPictureMappingCreateDto ProductPictureMappingCreateDto);

        [Delete("/api/picture/mapping/{id}")]
        Task<HttpResponseMessage> Delete([AliasAs("id")] int id);

        [Get("/api/picture/mapping")]
        Task<IEnumerable<ProductPictureMappingDto>> GetAll();

        [Get("/api/picture/mapping/{id}")]
        Task<ProductPictureMappingDto> GetById([AliasAs("id")] int id);

        [Put("/api/picture/mapping")]
        Task<HttpResponseMessage> Update(ProductPictureMappingUpdateDto ProductPictureMappingUpdateDto);

        [Get("/api/picture/mapping/product/{productId}")]
        Task<IEnumerable<ProductPictureMappingDto>> GetByProductId([AliasAs("productId")] int productId);
    }
    
}
