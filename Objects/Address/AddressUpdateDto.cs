



namespace nopCommerceWebApiClient.Objects.Address
{
    /// <summary>
    /// AddressDto Data Transfer Object for updating
    /// </summary>
    public record AddressUpdateDto : AddressCreateDto
    {
        public required new int Id { get; init; }
    }
}
