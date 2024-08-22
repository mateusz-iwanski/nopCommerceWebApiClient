using nopCommerceWebApiClient.Objects.Product;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Product
{
    public interface IProductService
    {
        [Get("/api/product")]
        Task<IEnumerable<ProductDto>> GetAllAsync();

        [Get("/api/product/{id}")]
        Task<ProductDto> GetByIdAsync(int id);

        [Post("/api/product/add/minimal")]
        Task<ProductDto> CreateMinimalAsync(ProductCreateMinimalDto productDto);

        [Post("/api/product/{id}")]
        Task<HttpResponseMessage> DeleteAsync([AliasAs("id")] int id);

        [Put("/api/product/update/block/information/{id}")]
        Task<HttpResponseMessage> UpdateBlockInformationAsync([AliasAs("id")] int id, ProductUpdateBlockInformationDto productDto);

        [Put("/api/product/update/block/seo/{id}")]
        Task<HttpResponseMessage> UpdateBlockSeoAsync([AliasAs("id")] int id, ProductUpdateBlockSeoDto productDto);

        [Put("/api/product/update/block/rating/{id}")]
        Task<HttpResponseMessage> UpdateBlockRatingAsync([AliasAs("id")] int id, ProductUpdateBlockRatingDto productDto);

        [Put("/api/product/update/block/reviews/{id}")]
        Task<HttpResponseMessage> UpdateBlockReviewsAsync([AliasAs("id")] int id, ProductUpdateBlockReviewsDto productDto);

        [Put("/api/product/update/block/stock/{id}")]
        Task<HttpResponseMessage> UpdateBlockGiftCardAsync([AliasAs("id")] int id, ProductUpdateBlockGiftCardDto productDto);

        [Put("/api/product/update/block/giftcard/{id}")]
        Task<HttpResponseMessage> UpdateBlockDownloadAsync([AliasAs("id")] int id, ProductUpdateBlockDownloadDto productDto);

        [Put("/api/product/update/block/recurring/{id}")]
        Task<HttpResponseMessage> UpdateBlockRecurringAsync([AliasAs("id")] int id, ProductUpdateBlockRecurringDto productDto);

        [Put("/api/product/update/block/rental/{id}")]
        Task<HttpResponseMessage> UpdateBlockRentalPriceAsync([AliasAs("id")] int id, ProductUpdateBlockRentalPriceDto productDto);

        [Put("/api/product/update/block/shipping/{id}")]
        Task<HttpResponseMessage> UpdateBlockShippingAsync([AliasAs("id")] int id, ProductUpdateBlockShippingDto productDto);

        [Put("/api/product/update/block/inventory/{id}")]
        Task<HttpResponseMessage> UpdateBlockInventoryAsync([AliasAs("id")] int id, ProductUpdateBlockInventoryDto productDto);

        [Put("/api/product/update/block/attribute/{id}")]
        Task<HttpResponseMessage> UpdateBlockAttributeAsync([AliasAs("id")] int id, ProductUpdateBlockAttributeDto productDto);

        [Put("/api/product/update/block/price/{id}")]
        Task<HttpResponseMessage> UpdateBlockPriceAsync([AliasAs("id")] int id, ProductUpdateBlockPriceDto productDto);

        [Put("/api/product/{productId}/unlink/category/{categoryId}")]
        Task<HttpResponseMessage> UnAssociateCategoryAsync([AliasAs("productId")] int productId, [AliasAs("categoryId")] int categoryId);

        [Put("/api/product/{productId}/link/category/{categoryId}")]
        Task<HttpResponseMessage> AssociateCategoryAsync([AliasAs("productId")] int productId, int categoryId);
    }
}
