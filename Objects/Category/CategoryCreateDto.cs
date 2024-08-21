

namespace nopCommerceWebApiClient.Objects.Category
{
    public record CategoryCreateDto : CategoryDto
    {
        public new int Id { get; } = 0;
    }
}
