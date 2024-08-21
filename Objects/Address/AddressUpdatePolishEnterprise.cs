


namespace nopCommerceWebApiClient.Objects.Address
{
    /// <summary>
    /// Address update Data Transfer Object for Polish Enterprise updating
    /// </summary>
    public record AddressUpdatePolishEnterprise : AddressCreatePolishEnterprise
    {
        public required new int Id { get; init; }
    }
}