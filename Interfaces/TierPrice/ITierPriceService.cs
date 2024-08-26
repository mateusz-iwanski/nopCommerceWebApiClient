using nopCommerceWebApiClient.Objects.TierPrice;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.TierPrice
{
    public interface ITierPriceService
    {
        [Post("/api/tierprice")]
        Task<TierPriceDto> CreateAsync(TierPriceCreateDto tierPriceDto);

        [Delete("/api/tierprice/{id}")]
        Task<HttpResponseMessage> DeleteAsync([AliasAs("id")] int id);

        [Get("/api/tierprice")]
        Task<IEnumerable<TierPriceDto>> GetAllAsync();

        [Get("/api/tierprice/details")]
        Task<IEnumerable<TierPriceDetailsDto>> GetAllDetailsAsync();

        [Get("/api/tierprice/{id}")]
        Task<TierPriceDto> GetByIdAsync([AliasAs("id")] int id);

        [Get("/api/tierprice")]
        Task<HttpResponseMessage> UpdateAsync(TierPriceUpdateDto tierPriceDto);
    }    
}
