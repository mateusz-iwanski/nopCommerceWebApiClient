

namespace nopCommerceWebApiClient.Objects.Category
{
    public record CategoryUpdateDto : CategoryCreateDto
    {
        public required new int Id { get; init; }
        public override bool Deleted { get; init; } = false;
    }
}
