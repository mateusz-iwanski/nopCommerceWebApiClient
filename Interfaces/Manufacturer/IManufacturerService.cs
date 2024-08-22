
using nopCommerceWebApiClient.Objects.Manufacturer;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Manufacturer
{
    public interface IManufacturerService
    {
        [Post("/api/manufacturer")]
        Task<ManufacturerDto> CreateAsync(ManufacturerCreateDto manufacturerCreateDto);

        [Get("/api/manufacturer")]
        Task<IEnumerable<ManufacturerDto>> GetAllAsync();

        [Put("/api/manufacturer")]
        Task<ManufacturerDto> UpdateAsync(ManufacturerUpdateDto manufacturerUpdateDto);

        [Get("/api/manufacturer/{id}")]
        Task<ManufacturerDto> GetByIdAsync([AliasAs("id")] int id);

        [Delete("/api/manufacturer/{id}")]
        Task<HttpResponseMessage> DeleteAsync([AliasAs("id")] int id);
    }
}
