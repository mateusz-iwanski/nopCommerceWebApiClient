﻿using nopCommerceWebApiClient.Objects.Country;
using nopCommerceWebApiClient.Objects.State;

namespace nopCommerceWebApiClient.Objects.Address
{
    /// <summary>
    /// AddressDto details Data Transfer Object
    /// </summary>
    /// <remarks>
    /// This object should be used only for the get method in controller
    /// </remarks>
    public record AddressDetailsDto : AddressDto
    {
        /// <summary>
        /// ## NIP
        /// ### Gets the Nip
        /// </summary>
        public string? NIP { get; init; }
    }
}
