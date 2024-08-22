

namespace nopCommerceWebApiClient.Objects.Customer
{
    /// <summary>
    /// The customer roles in nopCommerce enable you to form groups of your web store users. 
    /// You can create various groups, such as store admins, shoppers, vendors, and others. 
    /// 
    /// If you don't need this option just leave this field empty. 
    /// In order to use this functionality, you have to disable the following 
    /// setting: Configuration > Settings > Catalog > Ignore ACL rules (sitewide).
    /// </summary>

    public record CustomerRoleDto
    {
        public int Id { get; init; }
        public string Name { get; init; } = null!;
        public string? SystemName { get; init; }
        public bool FreeShipping {  get; set; }
        public bool TaxExempt { get; init; }
        public bool Active { get; init; }
        public bool IsSystemRole { get; init; }
        public bool EnablePasswordLifetime { get; init; }
        public bool OverrideTaxDisplayType { get; init; }
        public int DefaultTaxDisplayTypeId { get; init; }
        public int PurchasedWithProductId { get; init; }
    }
}
