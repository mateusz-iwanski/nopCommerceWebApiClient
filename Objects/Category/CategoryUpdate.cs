

namespace nopCommerceWebApiClient.Objects.Category
{
    public record CategoryUpdate : CategoryCreate
    {
        public required new int Id { get; init; }
        public override bool Deleted { get; init; } = false;
    }
}
