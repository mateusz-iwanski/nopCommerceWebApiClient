

namespace nopCommerceWebApiClient.Objects.Category
{
    public record CategoryCreate : Category
    {
        public new int Id { get; } = 0;
    }
}
