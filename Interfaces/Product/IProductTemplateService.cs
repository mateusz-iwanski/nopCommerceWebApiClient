using nopCommerceWebApiClient.Objects.ProductTemplate;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Product
{
    public interface IProductTemplateService
    {
        [Get("/api/product/template")]
        Task<IEnumerable<ProductTemplateDto>> GetAllAsync();
    }
}
