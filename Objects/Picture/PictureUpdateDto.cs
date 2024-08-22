

namespace nopCommerceWebApiClient.Objects.Picture
{
    public record PictureUpdateDto : PictureDto
    {        
        public required new int Id { get; init; }
    }
}
