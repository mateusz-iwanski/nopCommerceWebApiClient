


using System.ComponentModel.DataAnnotations;

namespace nopCommerceWebApiClient.Objects.Customer
{
    public interface ICustomerCreatePLDto
    {
        string? City { get; init; }
        string? Company { get; init; }
        string? County { get; init; }
        string Email { get; init; }
        string? FirstName { get; init; }
        string? LastName { get; init; }
        string Password { get; init; }
        string? Phone { get; init; }
        string? StreetAddress { get; init; }
        string? StreetAddress2 { get; init; }
        string Username { get; init; }
        string? ZipPostalCode { get; init; }
    }

    /// <summary>
    /// <c>CustomerCreatePLDto</c> uses for creating nopCommerce customer
    /// </summary>
    public record CustomerCreatePLDto : ICustomerCreatePLDto
    {
        private bool _isTaxExempt = false; // every PL customer is not tax exempt
        private int _vendorId = 0; // disable multi-vendor option
        private bool _active = true; // when we create PL customer it should be active
        private bool _deleted = false; // we create customer so is not deleted 
        private bool _isSystemAccount = false; // we create customer so is not system account

        /// <summary>
        /// ## Username
        /// ### Sets the username
        /// </summary>
        public required string Username { get; init; }

        /// <summary>
        /// ## Password
        /// ### Sets the password
        /// </summary>
        public required virtual string Password { get; init; }

        /// <summary>
        /// ## Email
        /// ### Sets the email
        /// </summary>
        [EmailAddress]
        public required string Email { get; init; }

        /// <summary>
        /// ## FirstName
        /// ### Gets or sets the first name
        /// </summary>
        public string? FirstName { get; init; }

        /// <summary>
        /// ## LastName
        /// ### Gets or sets the last name
        /// </summary>
        public string? LastName { get; init; }

        /// <summary>
        /// ## Company
        /// ### Gets or sets the company name
        /// </summary>
        public string? Company { get; init; }

        /// <summary>
        /// ## StreetAddress
        /// ### Gets or sets the street address
        /// </summary>
        public virtual string? StreetAddress { get; init; }

        /// <summary>
        /// ## StreetAddress2
        /// ### Gets or sets the street address 2
        /// </summary>
        public virtual string? StreetAddress2 { get; init; }

        /// <summary>
        /// ## ZipPostalCode
        /// ### Gets or sets the zip
        /// </summary>
        public virtual string? ZipPostalCode { get; init; }

        /// <summary>
        /// ## City
        /// ### Gets or sets the city
        /// </summary>
        public virtual string? City { get; init; }

        /// <summary>
        /// ## County
        /// ### Gets or sets the county
        /// </summary>
        public virtual string? County { get; init; }

        /// <summary>
        /// ## Phone
        /// ### Gets or sets the phone number
        /// </summary>
        public virtual string? Phone { get; init; }

        //[JsonIgnore]
        public bool IsTaxExempt
        {
            get => _isTaxExempt;
            set { }
        }

        //[JsonIgnore]
        public int VendorId
        {
            get => _vendorId;
            set { }
        }

        //[JsonIgnore]
        public bool Active
        {
            get => _active;
            set { }
        }

        //[JsonIgnore]
        public bool Deleted
        {
            get => _deleted;
            set { }
        }

        //[JsonIgnore]
        public bool IsSystemAccount
        {
            get => _isSystemAccount;
            set { }
        }

        public override string ToString()
        {
            return $"Username: {Username}, Email: {Email}, FirstName: {FirstName}, LastName: {LastName}, " +
                   $"Company: {Company}, StreetAddress: {StreetAddress}, StreetAddress2: {StreetAddress2}, " +
                   $"ZipPostalCode: {ZipPostalCode}, City: {City}, County: {County}, Phone: {Phone}, " +
                   $"IsTaxExempt: {IsTaxExempt}, VendorId: {VendorId}, Active: {Active}, Deleted: {Deleted}, " +
                   $"IsSystemAccount: {IsSystemAccount}";
        }

    }
}
