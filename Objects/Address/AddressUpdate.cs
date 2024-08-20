



namespace nopCommerceWebApiClient.Objects.Address
{
    /// <summary>
    /// Address Data Transfer Object for updating
    /// </summary>
    public record AddressUpdate : AddressCreate
    {
        public required override int Id { get; init; }
    }
}
