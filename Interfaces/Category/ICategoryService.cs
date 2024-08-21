using nopCommerceWebApiClient.Objects.Category;

using Refit;

namespace nopCommerceWebApiClient.Interfaces.Category
{
    public interface ICategoryService
    {
        [Post("/api/category")]
        Task<Objects.Category.Category> CreateAsync(CategoryCreate createCategoryDto);

        [Delete("/api/category/{id}")]
        Task DeleteAsync([AliasAs("id")] int id);

        [Get("/api/category")]
        Task<IEnumerable<Objects.Category.Category>> GetAllAsync();

        [Get("/api/category/{id}")]
        Task<Objects.Category.Category> GetByIdAsync([AliasAs("id")] int id);

        [Put("/api/category")]
        Task<Objects.Category.Category> UpdateAsync(CategoryUpdate updateCategoryDto);
    }
    
}
