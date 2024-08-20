using System.Text.Json.Serialization;

namespace nopCommerceWebApiClient.Objects.Address
{
    /// <summary>
    /// <c>AddressCreatePolishEnterprise</c> uses for creating enterprise address with the NIP value as a custom attribute for Poland.
    /// </summary>
    /// <remarks>
    /// Default nopCommerce not have this feature.
    /// </remarks> 
    public record AddressCreatePolishEnterprise : Address
    {
        private string _nip;
        private string _city;
        private string _address1;

        public override int Id { get; init; } = 0;

        /// <summary>
        /// ## Company
        /// ### Sets the company
        /// </summary>
        ////[Required]
        public required override string Company
        {
            get => base.Company;
            init
            {
                base.Company = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Company cannot be null or empty");
            }
        }

        /// <summary>
        /// ## Nip
        /// ### Sets the Nip
        /// </summary>
        public required string Nip
        {
            get => _nip;
            set => _nip = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Nip cannot be null or empty");
        }

        /// <summary>
        /// ## City
        /// ### Gets or sets the city
        /// </summary>
        public override string City
        {
            get => _city;
            init => _city = !string.IsNullOrEmpty(value) ? value : throw new ArgumentNullException(nameof(City), "City cannot be null or empty");
        }

        /// <summary>
        /// ## Address1
        /// ### Gets or sets the address 1
        /// </summary>
        public override string Address1
        {
            get => _address1;
            init => _address1 = !string.IsNullOrEmpty(value) ? value : throw new ArgumentNullException(nameof(Address1), "Address1 cannot be null or empty");
        }

        /// <summary>
        /// It's always Poland
        /// </summary>
        public new int CountryId { get; } = 0;
    }
}
