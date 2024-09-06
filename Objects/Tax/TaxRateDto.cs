using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nopCommerceWebApiClient.Objects.Tax
{
    /// <summary>
    /// Tax rate DTO
    /// </summary>
    /// <remarks>
    /// This object should be used only for the get method in controller
    /// </remarks>

    public record TaxRateDto
    {
        public int Id { get; set; }

        /// <summary>
        /// Gets the store identifier
        /// </summary>
        public int StoreId { get; set; }

        /// <summary>
        /// Gets the tax category identifier
        /// </summary>
        public int TaxCategoryId { get; set; }

        /// <summary>
        /// Gets the country identifier
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Gets the state/province identifier
        /// </summary>
        public int StateProvinceId { get; set; }

        /// <summary>
        /// Gets the zip
        /// </summary>
        public string? Zip { get; set; }

        /// <summary>
        /// Gets the percentage
        /// </summary>
        public decimal Percentage { get; set; }
    }
}
