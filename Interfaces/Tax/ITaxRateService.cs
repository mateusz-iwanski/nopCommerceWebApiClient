using Microsoft.AspNetCore.Mvc;
using nopCommerceWebApiClient.Objects.Tax;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nopCommerceWebApiClient.Interfaces.Tax
{
    public interface ITaxRateService
    {
        [Get("/api/taxrate")]
        Task<IEnumerable<TaxRateDto>> GetAllAsync();

        [Get("/api/taxrate/{id}")]
        Task<TaxRateDto> GetByIdAsync([AliasAs("id")] int id);

        [Get("/api/taxrate/percentage/{percentage}")]
        Task<IEnumerable<TaxRateDto>> GetByPercentageAsync([AliasAs("percentage")] decimal percentage);

        [Get("/api/taxrate/taxcategory/{taxCategoryId}")]
        Task<ActionResult<IEnumerable<TaxRateDto>>> GetByTaxCategoryId([AliasAs("taxCategoryId")] int taxCategoryId);
    }
}
