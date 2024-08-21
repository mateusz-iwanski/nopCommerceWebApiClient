﻿
using nopCommerceWebApiClient.Objects.Currency;
using Refit;

namespace nopCommerceWebApiClient.Interfaces.Currency
{
    public interface ICurrencyService
    {
        [Get("/api/currency")]
        Task<IEnumerable<CurrencyDto>> GetAllAsync();
    }
}