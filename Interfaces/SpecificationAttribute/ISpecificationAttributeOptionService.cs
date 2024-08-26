using nopCommerceWebApiClient.Objects.SpecificationAttribute;
using nopCommerceWebApiClient.Objects.SpecificationAttributeOption;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.SpecificationAttribute
{
    public interface ISpecificationAttributeOptionService
    {
        [Post("/api/specification-attribute/option")]
        Task<SpecificationAttributeOptionDto> CreateAsync(SpecificationAttributeOptionCreateDto specificationAttributeOptionCreateDto);

        [Delete("/api/specification-attribute/option/{id}")]
        Task DeleteAsync([AliasAs("id")] int id);

        [Get("/api/specification-attribute/option")]
        Task<List<SpecificationAttributeOptionDto>> GetAllAsync();

        [Get("/api/specification-attribute/option/specification-attribute/{specificationAttributeId}")]
        Task<List<SpecificationAttributeOptionDto>> GetAllBySpecificationAttributeIdAsync(int specificationAttributeId);

        [Get("/api/specification-attribute/option/{id}")]
        Task<SpecificationAttributeOptionDto> GetByIdAsync([AliasAs("id")] int id);

        [Put("/api/specification-attribute/option")]
        Task<SpecificationAttributeOptionDto> UpdateAsync(SpecificationAttributeOptionUpdateDto specificationAttributeOptionUpdateDto);
    }
}
