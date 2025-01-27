using System.Text.Json.Serialization;

namespace nopCommerceWebApiClient.Objects.Picture
{
    public class PictureBinaryCreateDto : PictureBinaryDto
    {
        [JsonIgnore]
        public override int Id { get; set; }
    }
}
