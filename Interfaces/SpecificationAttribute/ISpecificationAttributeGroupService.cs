using nopCommerceWebApiClient.Objects.SpecyficationAttributeGroup;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.SpecificationAttribute
{
    public interface ISpecificationAttributeGroupService
    {
        [Post("/api/specification-attribute/group")]
        Task<SpecificationAttributeGroupDto> CreateAsync(SpecificationAttributeGroupCreateDto specificationAttributeGroupCreateDto);

        [Delete("/api/specification-attribute/group/{id}")]
        Task<HttpResponseMessage> DeleteAsync([AliasAs("id")] int id);

        [Get("/api/specification-attribute/group")]
        Task<IEnumerable<SpecificationAttributeGroupDto>> GetAllAsync();

        [Get("/api/specification-attribute/group/{id}")]
        Task<SpecificationAttributeGroupDto> GetByIdAsync([AliasAs("id")] int id);

        [Get("/api/specification-attribute/group/name/{name}")]
        Task<SpecificationAttributeGroupDto> GetByNameAsync(string name);

        [Put("/api/specification-attribute/group")]
        Task<HttpResponseMessage> UpdateAsync(SpecificationAttributeGroupUpdateDto specificationAttributeGroupUpdateDto);
    }
}
