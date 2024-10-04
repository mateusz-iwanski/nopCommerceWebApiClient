using nopCommerceWebApiClient.Objects.SpecificationAttribute;
using nopCommerceWebApiClient.Objects.SpecyficationAttribute;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.SpecificationAttribute
{
    public interface ISpecificationAttributeService
    {
        [Post("/api/specification-attribute")]
        Task<HttpResponseMessage> CreateAsync(SpecificationAttributeCreateDto specificationAttributeCreateDto);

        [Get("/api/specification-attribute")]
        Task<IEnumerable<SpecificationAttributeDto>> GetAllAsync();

        [Get("/api/specification-attribute/{id}")]
        Task<SpecificationAttributeDto> GetByIdAsync([AliasAs("id")] int id);

        [Get("/api/specification-attribute/name/{name}")]
        Task<SpecificationAttributeDto> GetByNameAsync([AliasAs("name")] string name);

        [Put("/api/specification-attribute")]   
        Task<HttpResponseMessage> UpdateAsync(SpecificationAttributeUpdateDto specificationAttributeUpdateDto);

        [Delete("/api/specification-attribute/{id}")]
        Task<HttpResponseMessage> DeleteAsync([AliasAs("id")] int id);

        [Get("/api/specification-attribute/detail")]
        Task<IEnumerable<SpecificationAttributeDetailsDto>> GetAllDetailAsync();
    }
}
