using nopCommerceWebApiClient.Objects.Category;

using Refit;

namespace nopCommerceWebApiClient.Interfaces.Category
{
    public interface ICategoryService
    {
        [Post("/api/category")]
        Task<Objects.Category.CategoryDto> CreateAsync(CategoryCreateDto createCategoryDto);

        [Delete("/api/category/{id}")]
        Task DeleteAsync([AliasAs("id")] int id);

        [Get("/api/category")]
        Task<IEnumerable<Objects.Category.CategoryDto>> GetAllAsync();

        [Get("/api/category/{id}")]
        Task<Objects.Category.CategoryDto> GetByIdAsync([AliasAs("id")] int id);

        [Put("/api/category")]
        Task<Objects.Category.CategoryDto> UpdateAsync(CategoryUpdateDto updateCategoryDto);
    }
    
}
