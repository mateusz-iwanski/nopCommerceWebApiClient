using nopCommerceWebApiClient.Objects.Picture;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Picture
{
    public interface IPictureService
    {
        [Post("/api/picture")]
        Task<HttpResponseMessage> CreateAsync(PictureCreateDto pictureCreateDto);

        [Delete("/api/picture/{id}")]
        Task<HttpResponseMessage> DeleteAsync(int id);

        [Get("/api/picture")]
        Task<IEnumerable<PictureDto>> GetAllAsync();

        [Get("/api/picture/{id}")]
        Task<PictureDto> GetByIdAsync([AliasAs("id")] int id);

        [Put("/api/picture")]
        Task<HttpResponseMessage> UpdateAsync(PictureUpdateDto pictureUpdateDto);

        [Get("/api/picture/proper-name/{pictureId}")]
        Task<string> ProperNameForPictureFileAsync(int pictureId);
    }
    
}
