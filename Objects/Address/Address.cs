namespace nopCommerceWebApiClient.Objects.Address
{
    /// <summary>
    /// Address Data 
    /// </summary>
    /// <remarks>
    /// This object should be used only for the get method in controller
    /// </remarks>
    public record Address
    {
        /// <summary>
        /// ## Id
        /// ### Gets or sets the entity identifier
        /// </summary>
        public virtual int Id { get; init; } 

        /// <summary>
        /// ## CountryId
        /// ### Gets or sets the country identifier
        /// </summary>
        public virtual int? CountryId { get; init; }

        /// <summary>
        /// ## StateProvinceId
        /// ### Gets or sets the state/province identifier
        /// *Defaul = null*
        /// </summary>
        public virtual int? StateProvinceId { get; init; }

        /// <summary>
        /// ## FirstName
        /// ### Gets or sets the first name
        /// *Defaul = null*
        /// </summary>
        public virtual string? FirstName { get; init; }

        /// <summary>
        /// ## LastName
        /// ### Gets or sets the last name
        /// *Defaul = null*
        /// </summary>
        public virtual string? LastName { get; init; }

        /// <summary>
        /// ## Email
        /// ## Gets or sets the email
        /// *Defaul = null*
        /// </summary>
        public virtual string? Email { get; init; }

        /// <summary>
        /// ## Company
        /// ### Gets or sets the company        
        /// *Defaul = null*
        /// </summary>
        public virtual string? Company { get; init; }

        /// <summary>
        /// ## County
        /// ### Gets or sets the county
        /// *Defaul = null*
        /// </summary>
        public virtual string? County { get; init; }

        /// <summary>
        /// ## City
        /// ### Gets or sets the city
        /// </summary>
        public virtual string? City { get; init; }

        /// <summary>
        /// ## Address1
        /// ### Gets or sets the address 1
        /// </summary>
        public virtual string? Address1 { get; init; }

        /// <summary>
        /// ## Address2
        /// ### Gets or sets the address 2
        /// *Defaul = null*
        /// </summary>
        public virtual string? Address2 { get; init; }

        /// <summary>
        /// ## ZipPostalCode
        /// ### Gets or sets the zip/postal code
        /// *Defaul = null*
        /// </summary>
        public virtual string? ZipPostalCode { get; init; }

        /// <summary>
        /// ## PhoneNumber
        /// ### Gets or sets the phone number
        /// *Defaul = null*
        /// </summary>
        public virtual string? PhoneNumber { get; init; }

        /// <summary>
        /// ## FaxNumber
        /// ### Gets or sets the fax number
        /// *Defaul = null*
        /// </summary>
        public virtual string? FaxNumber { get; init; }

        /// <summary>
        /// ## CreatedOnUtc        
        /// ### Gets or sets the date and time of instance creation
        /// *Defaul = DateTime.Now*
        /// </summary>
        public DateTime CreatedOnUtc { get; }
    }

}
