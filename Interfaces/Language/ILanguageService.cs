using nopCommerceWebApiClient.Objects.Language;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Language
{
    public interface ILanguageService
    {
        [Get("/api/language")]
        Task<IEnumerable<LanguageDto>> GetAllAsync();
    }
}
