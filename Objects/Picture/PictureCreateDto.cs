

using System.Text.Json.Serialization;

namespace nopCommerceWebApiClient.Objects.Picture
{
    public record PictureCreateDto : PictureDto
    {
        public new int Id { get; } = 0;
    }
}
