using nopCommerceWebApiClient.Objects.Picture;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nopCommerceWebApiClient.Interfaces.Picture
{
    public interface IPictureBinaryService
    {
        [Post("/api/picture-binary")]
        Task<HttpResponseMessage> CreateAsync(PictureBinaryCreateDto pictureCreateDto);

        [Delete("/api/picture-binary/{id}")]
        Task<HttpResponseMessage> DeleteAsync(int id);

        [Get("/api/picture-binary")]
        Task<IEnumerable<PictureDto>> GetAllAsync();

        [Get("/api/picture-binary/{id}")]
        Task<PictureDto> GetByIdAsync([AliasAs("id")] int id);

        [Put("/api/picture-binary")]
        Task<HttpResponseMessage> UpdateAsync(PictureBinaryUpdateDto pictureUpdateDto);
    }
}
