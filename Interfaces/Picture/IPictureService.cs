using nopCommerceWebApiClient.Objects.Picture;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Picture
{
    public interface IPictureService
    {
        [Post("/api/picture")]
        Task<PictureDto> CreateAsync(PictureCreateDto pictureCreateDto);

        [Delete("/api/picture/{id}")]
        Task<bool> DeleteAsync(int id);

        [Get("/api/picture")]
        Task<IEnumerable<PictureDto>> GetAllAsync();

        [Get("/api/picture/{id}")]
        Task<PictureDto> GetByIdAsync([AliasAs("id")] int id);

        [Put("/api/picture")]
        Task UpdateAsync(PictureUpdateDto pictureUpdateDto);

        [Get("/api/picture/proper-name/{pictureId}")]
        Task<string> ProperNameForPictureFileAsync(int pictureId);
    }
    
}
