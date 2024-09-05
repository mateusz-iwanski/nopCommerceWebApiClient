

using nopCommerceWebApiClient.Objects.Address;
using nopCommerceWebApiClient.Objects.Country;
using nopCommerceWebApiClient.Objects.Currency;
using nopCommerceWebApiClient.Objects.Language;
using nopCommerceWebApiClient.Objects.State;


namespace nopCommerceWebApiClient.Objects.Customer
{
    public record CustomerDto
    {
        public virtual int Id { get; init; }  
        public virtual string? Username { get; init; }
        public virtual string Email { get; init; }
        public virtual DateTime CreatedOnUtc { get; init; }
        public virtual string? FirstName { get; init; }
        public virtual string? LastName { get; init; }
        public virtual string? Company { get; init; }
        public virtual string? StreetAddress { get; init; }
        public virtual string? StreetAddress2 { get; init; }
        public virtual string? ZipPostalCode { get; init; }
        public virtual string? City { get; init; }
        public virtual string? County { get; init; }
        public virtual string? Phone { get; init; }
        public virtual string? VatNumber { get; init; }
        public virtual string? SystemName { get; init; }
        public virtual bool IsSystemAccount { get; init; }

        public virtual Address.AddressDto? BillingAddress { get; init; }
        public virtual Address.AddressDto? ShippingAddress { get; init; }
        public virtual LanguageDto? Language { get; init; }
        public virtual Country.CountryDto? Country { get; init; }
        public virtual StateProvinceDto? StateProvince { get; init; }
        public virtual Currency.CurrencyDto? Currency { get; init; }
        public virtual Guid CustomerGuid { get; init; }
        public virtual bool IsTaxExempt { get; init; }
        public virtual int VendorId { get; init; }
        public virtual bool Active { get; init; } = true;
        public virtual bool Deleted { get; init; }

        public override string ToString()
        {
            return $"ID: {Id}, Username: {Username}, Email: {Email}, FirstName: {FirstName}, LastName: {LastName}, " +
                   $"Company: {Company}, StreetAddress: {StreetAddress}, StreetAddress2: {StreetAddress2}, " +
                   $"ZipPostalCode: {ZipPostalCode}, City: {City}, County: {County}, Phone: {Phone}, " +
                   $"IsTaxExempt: {IsTaxExempt}, VendorId: {VendorId}, Active: {Active}, Deleted: {Deleted}, " +
                   $"IsSystemAccount: {IsSystemAccount}";
        }
    }
}
