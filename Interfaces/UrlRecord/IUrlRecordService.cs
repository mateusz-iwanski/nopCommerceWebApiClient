using nopCommerceWebApiClient.Objects.UrlRecord;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.UrlRecord
{
    public interface IUrlRecordService
    {
        [Post("/api/url-records")]
        Task<HttpResponseMessage> CreateAsync(UrlRecordCreateDto urlRecordCreateDto);

        [Delete("/api/url-records/{id}")]
        Task<HttpResponseMessage> DeleteAsync([AliasAs("id")] int id);

        [Get("/api/url-records")]
        Task<IEnumerable<UrlRecordDto>> GetAllAsync();

        [Get("/api/url-records/{id}")]
        Task<HttpResponseMessage> GetByIdAsync([AliasAs("id")] int id);

        [Put("/api/url-records/")]
        Task<HttpResponseMessage> UpdateAsync(UrlRecordUpdateDto urlRecordUpdateDto);
    }
}
