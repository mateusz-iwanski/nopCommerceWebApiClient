using Microsoft.AspNetCore.Mvc;
using nopCommerceWebApiClient.Objects.TaxCategory;
using Refit;

namespace nopCommerceWebApiClient.Interfaces
{
    public interface ITaxCategoryService
    {
        [Get("/api/taxcategory")]
        Task<IEnumerable<TaxCategoryDto>> GetAllAsync();

        [Get("/api/taxcategory/{name}")]
        Task<TaxCategoryDto> GetByName([AliasAs("name")] string name);
    }    
}
