using nopCommerceWebApiClient.Objects.TaxCategory;
using Refit;

namespace nopCommerceWebApiClient.Interfaces
{
    public interface ITaxCategoryService
    {
        [Get("/api/taxcategory")]
        Task<IEnumerable<TaxCategoryDto>> GetAllAsync();
    }    
}
