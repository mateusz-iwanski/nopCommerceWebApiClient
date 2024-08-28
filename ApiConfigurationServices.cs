using NLog;
using NLog.Web;
using nopCommerceWebApiClient.Helpers;
using nopCommerceWebApiClient.Interfaces.Address;
using nopCommerceWebApiClient.Interfaces.Category;
using nopCommerceWebApiClient.Interfaces.Country;
using nopCommerceWebApiClient.Interfaces.Currency;
using nopCommerceWebApiClient.Interfaces.Customer;
using nopCommerceWebApiClient.Interfaces.Language;
using nopCommerceWebApiClient.Interfaces.Manufacturer;
using nopCommerceWebApiClient.Interfaces.Picture;
using nopCommerceWebApiClient.Interfaces.Product;
using nopCommerceWebApiClient.Interfaces.SpecificationAttribute;
using nopCommerceWebApiClient.Interfaces.StateProvince;
using nopCommerceWebApiClient.Interfaces.TierPrice;
using nopCommerceWebApiClient.Interfaces.UrlRecord;
using nopCommerceWebApiClient.Interfaces.Video;
using nopCommerceWebApiClient.Objects.Customer;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nopCommerceWebApiClient
{
    public interface IApiConfigurationServices
    {
        IAddressAttributeService AddressAttributeService { get; }
        ICategoryService CategoryService { get; }
        ICountryService CountryService { get; }
        ICurrencyService CurrencyService { get; }
        ICustomerService CustomerService { get; }
        ICustomerRoleService CustomerRoleService { get; }
        ILanguageService LanguageService { get; }
        IManufacturerService ManufacturerService { get; }
        IPictureService PictureService { get; }
        IProductService ProductService { get; }
        IProductAttributeService ProductAttributeService { get; }
        IProductAttributeValueService ProductAttributeValueService { get; }
        IProductAvailabilityRangeService ProductAvailabilityRangeService { get; }
        IProductCategoryMappingService ProductCategoryMappingService { get; }
        IProductManufaturerMappingService ProductManufaturerMappingService { get; }
        IProductPictureMappingService ProductPictureMappingService { get; }
        IProductSpecificationAttributeMappingService ProductSpecificationAttributeMappingService { get; }
        IProductTagService ProductTagService { get; }
        IProductTemplateService ProductTemplateService { get; }
        IProductVideoService ProductVideoService { get; }
        ISpecificationAttributeGroupService SpecificationAttributeGroupService { get; }
        ISpecificationAttributeOptionService SpecificationAttributeOptionService { get; }
        ISpecificationAttributeService SpecificationAttributeService { get; }
        IStateProvinceService StateProvinceService { get; }
        ITierPriceService TierPriceService { get; }
        IUrlRecordService UrlRecordService { get; }
        IVideoService VideoService { get; }
    }

    public class ApiConfigurationServices : ApiConfiguration, IApiConfigurationServices
    {
        public IAddressAttributeService AddressAttributeService { get; private set; }
        public ICategoryService CategoryService { get; private set; }
        public ICountryService CountryService { get; private set; }
        public ICurrencyService CurrencyService { get; private set; }
        public ICustomerService CustomerService { get; private set; }
        public ICustomerRoleService CustomerRoleService { get; private set; }
        public ILanguageService LanguageService { get; private set; }
        public IManufacturerService ManufacturerService { get; private set; }
        public IPictureService PictureService { get; private set; }
        public IProductService ProductService { get; private set; }
        public IProductAttributeService ProductAttributeService { get; private set; }
        public IProductAttributeValueService ProductAttributeValueService { get; private set; }
        public IProductAvailabilityRangeService ProductAvailabilityRangeService { get; private set; }
        public IProductCategoryMappingService ProductCategoryMappingService { get; private set; }
        public IProductManufaturerMappingService ProductManufaturerMappingService { get; private set; }
        public IProductPictureMappingService ProductPictureMappingService { get; private set; }
        public IProductSpecificationAttributeMappingService ProductSpecificationAttributeMappingService { get; private set; }
        public IProductTagService ProductTagService { get; private set; }
        public IProductTemplateService ProductTemplateService { get; private set; }
        public IProductVideoService ProductVideoService { get; private set; }
        public ISpecificationAttributeGroupService SpecificationAttributeGroupService { get; private set; }
        public ISpecificationAttributeOptionService SpecificationAttributeOptionService { get; private set; }
        public ISpecificationAttributeService SpecificationAttributeService { get; private set; }
        public IStateProvinceService StateProvinceService { get; private set; }
        public ITierPriceService TierPriceService { get; private set; }
        public IUrlRecordService UrlRecordService { get; private set; }
        public IVideoService VideoService { get; private set; }

        public ApiConfigurationServices() : base()
        {
            AddressAttributeService = RestService.For<IAddressAttributeService>(httpClient);
            CategoryService = RestService.For<ICategoryService>(httpClient);
            CountryService = RestService.For<ICountryService>(httpClient);
            CurrencyService = RestService.For<ICurrencyService>(httpClient);
            CustomerService = RestService.For<ICustomerService>(httpClient);
            CustomerRoleService = RestService.For<ICustomerRoleService>(httpClient);
            LanguageService = RestService.For<ILanguageService>(httpClient);
            ManufacturerService = RestService.For<IManufacturerService>(httpClient);
            PictureService = RestService.For<IPictureService>(httpClient);
            ProductService = RestService.For<IProductService>(httpClient);
            ProductAttributeService = RestService.For<IProductAttributeService>(httpClient);
            ProductAttributeValueService = RestService.For<IProductAttributeValueService>(httpClient);
            ProductAvailabilityRangeService = RestService.For<IProductAvailabilityRangeService>(httpClient);
            ProductCategoryMappingService = RestService.For<IProductCategoryMappingService>(httpClient);
            ProductManufaturerMappingService = RestService.For<IProductManufaturerMappingService>(httpClient);
            ProductPictureMappingService = RestService.For<IProductPictureMappingService>(httpClient);
            ProductSpecificationAttributeMappingService = RestService.For<IProductSpecificationAttributeMappingService>(httpClient);
            ProductTagService = RestService.For<IProductTagService>(httpClient);
            ProductTemplateService = RestService.For<IProductTemplateService>(httpClient);
            ProductVideoService = RestService.For<IProductVideoService>(httpClient);
            SpecificationAttributeGroupService = RestService.For<ISpecificationAttributeGroupService>(httpClient);
            SpecificationAttributeOptionService = RestService.For<ISpecificationAttributeOptionService>(httpClient);
            SpecificationAttributeService = RestService.For<ISpecificationAttributeService>(httpClient);
            StateProvinceService = RestService.For<IStateProvinceService>(httpClient);
            TierPriceService = RestService.For<ITierPriceService>(httpClient);
            UrlRecordService = RestService.For<IUrlRecordService>(httpClient);
            VideoService = RestService.For<IVideoService>(httpClient);
        }
    }
}
