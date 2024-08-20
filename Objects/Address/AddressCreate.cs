


using System.Text.Json.Serialization;

namespace nopCommerceWebApiClient.Objects.Address
{
    /// <summary>
    /// CreateAddress uses for creating address for individual person
    /// </summary>
    public record AddressCreate : Address
    {
        private string _city;
        private string _address1;
        private int _countryId;

        public override int Id { get; init; } = 0;
        public required override string City
        {
            get => _city;
            init
            {
                _city = string.IsNullOrEmpty(value) ? throw new ArgumentNullException(nameof(City), "City cannot be null or empty") : value;
            }
        }
        public required override string Address1
        {
            get => _address1;
            init
            {
                _address1 = string.IsNullOrEmpty(value) ? throw new ArgumentNullException(nameof(Address1), "Address1 cannot be null or empty") : value;
            }
        }
        public required new int CountryId
        {
            get => _countryId;
            init
            {
                _countryId = value <= 0 ? throw new ArgumentOutOfRangeException(nameof(CountryId), "CountryId must be greater than 0") : value;
            }
        }
    }
}
