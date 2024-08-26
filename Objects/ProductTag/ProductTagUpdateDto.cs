namespace nopCommerceWebApiClient.Objects.ProductTag
{
    public record ProductTagUpdateDto : ProductTagDto
    {
        public required override int Id { get; init; }
    }
}
