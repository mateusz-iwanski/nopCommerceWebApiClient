


namespace nopCommerceWebApiClient.Objects.Address
{
    /// <summary>
    /// AddressDto update Data Transfer Object for Polish Enterprise updating
    /// </summary>
    public record AddressUpdatePolishEnterpriseDto : AddressCreatePolishEnterpriseDto
    {
        public required new int Id { get; init; }
    }
}