using nopCommerceWebApiClient.Objects.ProductAvailabilityRange;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Product
{
    public interface IProductAvailabilityRangeService
    {
        [Post("/api/product/availabilityrange")]
        Task<HttpResponseMessage> CreateAsync(ProductAvailabilityRangeCreateDto productAvailabilityRangeDto);

        [Get("/api/product/availabilityrange")]
        Task<IEnumerable<ProductAvailabilityRangeDto>> GetAllAsync();

        [Get("/api/product/availabilityrange/{id}")]
        Task<ProductAvailabilityRangeDto> GetByIdAsync([AliasAs("id")] int id);

        [Delete("/api/product/availabilityrange/{id}")]
        Task<HttpResponseMessage> DeleteAsync(int id);
    }
}
