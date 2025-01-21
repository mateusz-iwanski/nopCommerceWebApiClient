// See https://aka.ms/new-console-template for more information
using NLog;
using nopCommerceWebApiClient.Helpers;
using nopCommerceWebApiClient.Interfaces.Address;
using nopCommerceWebApiClient.Interfaces.Category;
using nopCommerceWebApiClient.Objects.Address;
using nopCommerceWebApiClient.Objects.Category;
using Refit;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

using NLog;
using NLog.Web;
using Microsoft.Extensions.Logging;
using nopCommerceWebApiClient.Interfaces.Country;
using nopCommerceWebApiClient.Objects.Country;
using nopCommerceWebApiClient.Interfaces.Currency;
using nopCommerceWebApiClient.Interfaces.Customer;
using nopCommerceWebApiClient.Objects.Customer;
using nopCommerceWebApiClient.Interfaces.Language;
using nopCommerceWebApiClient.Interfaces.Manufacturer;
using nopCommerceWebApiClient.Objects.Manufacturer;
using nopCommerceWebApiClient.Interfaces.Picture;
using nopCommerceWebApiClient.Objects.Picture;
using nopCommerceWebApiClient.Interfaces.Product;
using Microsoft.AspNetCore.WebUtilities;
using nopCommerceWebApiClient.Objects.ProductAttribute;
using nopCommerceWebApiClient.Objects.ProductAttributeValue;
using nopCommerceWebApiClient.Objects.ProductAvailabilityRange;
using nopCommerceWebApiClient.Objects.ProductCategory;
using nopCommerceWebApiClient.Objects.ProductManufacturer;
using nopCommerceWebApiClient.Objects.ProductPicture;
using nopCommerceWebApiClient.Objects.ProductSpecificationAttributeMapping;
using nopCommerceWebApiClient.Objects.ProductTag;
using nopCommerceWebApiClient.Objects.ProductVideo;
using nopCommerceWebApiClient.Interfaces.SpecificationAttribute;
using nopCommerceWebApiClient.Objects.SpecyficationAttributeGroup;
using nopCommerceWebApiClient.Objects.SpecificationAttribute;
using nopCommerceWebApiClient.Objects.SpecificationAttributeOption;
using nopCommerceWebApiClient.Objects.SpecyficationAttribute;
using nopCommerceWebApiClient.Interfaces.StateProvince;
using nopCommerceWebApiClient.Interfaces;
using nopCommerceWebApiClient.Interfaces.TierPrice;
using nopCommerceWebApiClient.Objects.TierPrice;
using nopCommerceWebApiClient.Interfaces.UrlRecord;
using nopCommerceWebApiClient.Objects.UrlRecord;
using nopCommerceWebApiClient.Interfaces.Video;
using nopCommerceWebApiClient.Objects.Video;


namespace nopCommerceWebApiClient
{


    public class Program
    {
        public static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");            
            var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

            var httpClientHandler = new HttpClientHandler();
            var customHandler = new CustomHttpClientHandler(httpClientHandler, logger);
            var httpClient = new HttpClient(customHandler)
            {
                BaseAddress = new Uri("https://localhost:44326/")
            };

            var addressAttributeApi = RestService.For<IAddressAttributeService>(httpClient);

            var categoryApi = RestService.For<ICategoryService>(httpClient);

            //var categoryCreate = new CategoryCreateDto
            //{                 
            //    Name = "Category1",
            //    Description = "Description1",
            //    ParentCategoryId = 0,
            //    CategoryTemplateId = 1,
            //    PictureId = 0,
            //    Published = false,
            //    PageSize = 0,
            //    AllowCustomersToSelectPageSize = false,
            //    PageSizeOptions = "10,20,30",
            //    ShowOnHomepage = false,
            //    IncludeInTopMenu = false,
            //    SubjectToAcl = false, 
            //    LimitedToStores = false,
            //    DisplayOrder = 0
            //};

            ////var categoryC = await categoryApi.CreateAsync(categoryCreate);

            //var categoryUpdate = new CategoryUpdateDto
            //{
            //    Id = 5,
            //    Name = "Category2",
            //    Description = "Description1",
            //    ParentCategoryId = 0,
            //    CategoryTemplateId = 1,
            //    PictureId = 0,
            //    Published = false,
            //    PageSize = 0,
            //    AllowCustomersToSelectPageSize = false,
            //    PageSizeOptions = "10,20,30",
            //    ShowOnHomepage = false,
            //    IncludeInTopMenu = false,
            //    SubjectToAcl = false,
            //    LimitedToStores = false,
            //    DisplayOrder = 0
            //};

            //var categoryU = await categoryApi.UpdateAsync(categoryUpdate);

            var countryApi = RestService.For<ICountryService>(httpClient);            

            //foreach (var countr in await countryApi.GetAllAsync())
            //{
            //    Console.WriteLine(countr);
            //}

            var currencyApi = RestService.For<ICurrencyService>(httpClient);

            //foreach (var curr in await currencyApi.GetAllAsync())
            //{
            //    Console.WriteLine(curr);
            //}

            var customerApi = RestService.For<ICustomerService>(httpClient);

            //var customerCreate = new CustomerPLUpdateDto
            //{
            //    Id = 89,
            //    Username = "Customer4",
            //    Email = "2cust@cust.com"
            //};

            //var customerAdd = new CustomerCreatePLDto
            //{
            //    Username = "Customerd",
            //    Email = "5cust@sscust.com",
            //    Password = "opse123"
            //};

            // var customerC = await customerApi.CreatePLAsync(customerAdd);

            //var customerCd = await customerApi.UpdatePLAsync(customerCreate);

            //var customerAll = await customerApi.GetAllAsync();

            //foreach (var cust in customerAll)
            //{
            //    Console.WriteLine(cust);
            //}

            // Ensure the Content-Type header is set correctly

            //await customerApi.UpdatePasswordAsync(Guid.Parse("552168C0-76D7-44EB-AABF-D0A6B9054ABF"), new nopCommerceWebApiClient.Interfaces.Customer.Password("oepn555"));


            var customerRole = RestService.For<ICustomerRoleService>(httpClient);

            //var cutomerrole = await customerRole.GetAllAsync();

            //foreach (var role in cutomerrole)
            //{
            //    Console.WriteLine(role);
            //}

            var language = RestService.For<ILanguageService>(httpClient);

            //foreach (var lang in await language.GetAllAsync())
            //{
            //    Console.WriteLine(lang);
            //}

            var manufacturer = RestService.For<IManufacturerService>(httpClient);

            //foreach (var manuf in await manufacturer.GetAllAsync())
            //{
            //    Console.WriteLine(manuf);
            //}

            //var manufacturerCreate = new ManufacturerCreateDto
            //{
            //    Name = "Manufacturer1",
            //    Description = "Description1",
            //    PictureId = 0,
            //    Published = false,
            //    AllowCustomersToSelectPageSize = false,
            //    PageSize = 0,
            //    ManufacturerTemplateId = 1,                
            //};

            //await manufacturer.CreateAsync(manufacturerCreate);

            //var manufacturerUpdate = new ManufacturerUpdateDto
            //{
            //    Id = 4,
            //    Name = "Manufacturer2",
            //    Description = "Description1",
            //    PictureId = 0,
            //    Published = false,
            //    AllowCustomersToSelectPageSize = false,
            //    PageSize = 0,
            //    ManufacturerTemplateId = 1,
            //};

            //await manufacturer.UpdateAsync(manufacturerUpdate);

            //await manufacturer.DeleteAsync(2);

            //var a = await manufacturer.GetByIdAsync(1);
            //Console.WriteLine(a);   

            var picture = RestService.For<IPictureService>(httpClient);

            //var pictureCreate = new PictureCreateDto 
            //{ 
            //    AltAttribute = "Alt1", TitleAttribute = "Title1", SeoFilename = "Seo1", MimeType = "image/jpeg", IsNew = true, VirtualPath = "Path1" 
            //};

            //await picture.CreateAsync(pictureCreate);

            //await picture.DeleteAsync(8);

            //var pictureAll = await picture.GetAllAsync();

            //foreach(var pic in pictureAll)
            //{
            //    Console.WriteLine(pic);
            //}

            //var pictureById = await picture.GetByIdAsync(1);
            //Console.WriteLine(pictureById);

            //var pictureUpdae = new PictureUpdateDto
            //{
            //    Id = 1,
            //    AltAttribute = "Alt2",
            //    TitleAttribute = "Title2",
            //    SeoFilename = "Seo2",
            //    MimeType = "image/jpeg",
            //    IsNew = true,
            //    VirtualPath = "Path2"
            //};

            //await picture.UpdateAsync(pictureUpdae);

            //Console.WriteLine(await picture.ProperNameForPictureFileAsync(11111));

            var product = RestService.For<IProductService>(httpClient);
            
            //var productAll = product.GetAllAsync();

            //foreach (var prod in await productAll)
            //{
            //    Console.WriteLine(prod);
            //}

            var productAttribute = RestService.For<IProductAttributeService>(httpClient);   

            //var productAttrAll = await productAttribute.GetAllAsync();

            //foreach(var prodAttr in productAttrAll)
            //{
            //    Console.WriteLine(prodAttr);
            //}

            //var productAttrCreate = new Objects.ProductAttributeMapping.ProductAttributeWithMappingCreateDto
            //{
            //    Name = "ProductAttribute1",
            //    Description = "Description1",
            //    ProductAttributeId = 1,
            //    ProductId = 1,
            //    TextPrompt = "TextPrompt1",
            //    IsRequired = false,
            //    AttributeControlTypeId = 1
            //};

            //await productAttribute.CreateAsync(productAttrCreate);

            //var productAttrUpdate = new ProductAttributeUpdateDto
            //{
            //    Id = 1,
            //    Name = "ProductAttribute2",
            //    Description = "Description1"
            //};

            //await productAttribute.UpdateAsync(productAttrUpdate);

            //var l = await productAttribute.GetByIdAsync(1);
            //Console.WriteLine(l);

            var productAttributeValue = RestService.For<IProductAttributeValueService>(httpClient);

            //var productAttrValueAll = await productAttributeValue.GetAllAsync();

            //foreach (var prodAttrVal in productAttrValueAll)
            //{
            //    Console.WriteLine(prodAttrVal);
            //}

            //var productAttrValueCreate = new ProductAttributeValueCreateDto 
            //{ 
            //    AssociatedProductId = 1, AttributeValueTypeId = 0, Name = "ProductAttributeValue1", 
            //    ColorSquaresRgb = "ColorSquaresRgb1", ImageSquaresPictureId = 1, PriceAdjustment = 1, WeightAdjustment = 1, 
            //    Cost = 1, Quantity = 1, IsPreSelected = false, DisplayOrder = 1 
            //};

            //var a = await productAttributeValue.CreateAsync(1, productAttrValueCreate);

            //Console.WriteLine(a);

            //var productAttributeValueUpdate = new ProductAttributeValueUpdateDto
            //{
            //    Id = 1,
            //    Name = "ProductAttributeValue2",
            //    ColorSquaresRgb = "ColorSquaresRgb2",
            //    AttributeValueTypeId = 0,
            //    AssociatedProductId = 1,
            //    ImageSquaresPictureId = 1,
            //    PriceAdjustment = 1,
            //    PriceAdjustmentUsePercentage = false,
            //    WeightAdjustment = 1,
            //    Cost = 1,
            //    Quantity = 1,
            //    IsPreSelected = false,
            //    DisplayOrder = 1
            //};

            //await productAttributeValue.UpdateAsync(productAttributeValueUpdate);

            //await productAttributeValue.DeleteAsync(6);

            //var productAttributeValueById = await productAttributeValue.GetByIdAsync(1);

            //Console.WriteLine(productAttributeValueById);

            var productAvailRange = RestService.For<IProductAvailabilityRangeService>(httpClient);

            //var prodAvailRangeCrea = new ProductAvailabilityRangeCreateDto
            //{ 
            //    Name = "ProductAvailabilityRange1"
            //};

            //await productAvailRange.CreateAsync(prodAvailRangeCrea);
            
            //Console.WriteLine(await productAvailRange.GetByIdAsync(6));

            //await productAvailRange.DeleteAsync(6);

            //var productAvailRangeAll = await productAvailRange.GetAllAsync();

            //foreach (var prodAvailRange in productAvailRangeAll)
            //{
            //    Console.WriteLine(prodAvailRange);
            //}

            var productCategory = RestService.For<IProductCategoryMappingService>(httpClient);

            //var productCategoryAll = await productCategory.GetAllAsync();

            //foreach (var prodCat in productCategoryAll)
            //{
            //    Console.WriteLine(prodCat);
            //}

            //var productCategoryCreate = new ProductCategoryMappingCreateDto { ProductId = 1, CategoryId = 3, DisplayOrder = 1 };

            //await productCategory.CreateAsync(productCategoryCreate);

            //var productCategories = await productCategory.GetAllAssociateWithProductAsync(1);

            //foreach (var prodCat in productCategories)
            //{
            //    Console.WriteLine(prodCat);
            //}

            //await productCategory.DeleteAsync(3, 1);

            //var productProduct = await productCategory.GetAllAssociateWithCategoryAsync(1);

            //foreach (var prodCat in productProduct)
            //{
            //    Console.WriteLine(prodCat);
            //}

            var productManufacturer = RestService.For<IProductManufaturerMappingService>(httpClient);

            //var productManufacturerCreate = new ProductManufacturerMappingCreateDto { ManufacturerId = 1, ProductId = 2, DisplayOrder = 1 };
            //await productManufacturer.CreateAsync(productManufacturerCreate);

            //var productManufacturerAll = await productManufacturer.GetAllAsync();

            //foreach (var prodMan in productManufacturerAll)
            //{
            //    Console.WriteLine(prodMan);
            //}

            //Console.WriteLine(await productManufacturer.GetByIdAsync(3));

            //var productManufacturerGetByIdMan = await productManufacturer.GetByManufacturerId(1);

            //foreach (var prodMan in productManufacturerGetByIdMan)
            //{
            //    Console.WriteLine(prodMan);
            //}

            //var productManufacturerGetByIdprod = await productManufacturer.GetByProductId(1);

            //foreach (var prodMan in productManufacturerGetByIdprod)
            //{
            //    Console.WriteLine(prodMan);
            //}

            //await productManufacturer.DeleteAsync(3);

            var productPictureMapping = RestService.For<IProductPictureMappingService>(httpClient);

            //var productPictureMappingCreate = new ProductPictureMappingCreateDto { PictureId = 1, ProductId = 1, DisplayOrder = 1 };

            //await productPictureMapping.Create(productPictureMappingCreate);            

            //await productPictureMapping.GetById(12);

            //await productPictureMapping.Update(new ProductPictureMappingUpdateDto { Id = 12, PictureId = 1, ProductId = 1, DisplayOrder = 2 });

            //await productPictureMapping.GetByProductId(12);

            //var productPictureMappingAll = await productPictureMapping.GetAll();

            //foreach (var prodPic in productPictureMappingAll)
            //{
            //    Console.WriteLine(prodPic);
            //}

            //await productPictureMapping.Delete(12);

            var productSpecificAttributeMapping = RestService.For<IProductSpecificationAttributeMappingService>(httpClient);    
            
            //var productSpecificAttributeMappingCreate = new ProductSpecificationAttributeMappingCreateDto { ProductId =2, SpecificationAttributeOptionId = 1, AllowFiltering = false, ShowOnProductPage = false, DisplayOrder = 1 };

            //await productSpecificAttributeMapping.CreateAsync(productSpecificAttributeMappingCreate);


            //var productSpecificAttributeMappingAll = await productSpecificAttributeMapping.GetAllAsync();

            //foreach (var prodSpecAttr in productSpecificAttributeMappingAll)
            //{
            //    Console.WriteLine(prodSpecAttr);
            //}

            //var productSpecificAttributeMappingUpdate = new ProductSpecificationAttributeMappingUpdateDto { Id = 1, ProductId = 1, SpecificationAttributeOptionId = 1, AllowFiltering = false, ShowOnProductPage = false, DisplayOrder = 1 };

            //await productSpecificAttributeMapping.UpdateAsync(productSpecificAttributeMappingUpdate);

            //Console.WriteLine(await productSpecificAttributeMapping.GetByIdAsync(1));   

            //Console.WriteLine(await productSpecificAttributeMapping.GetByProductIdAsync(1));


            //await productSpecificAttributeMapping.DeleteAsync(6);

            var productTag = RestService.For<IProductTagService>(httpClient);

            //var productTagAll = await productTag.GetAllAsync();

            //foreach (var prodTag in productTagAll)
            //{
            //    Console.WriteLine(prodTag);
            //}

            //var productTagGetAllDetailsAsync = await productTag.GetAllDetailsAsync();

            //foreach (var prodTag in productTagGetAllDetailsAsync)
            //{
            //    Console.WriteLine(prodTag);
            //}

            //var productTagGetByIdAsync = await productTag.GetByIdAsync(2);  

            //Console.WriteLine(productTagGetByIdAsync);

            //var productTagGetByTagAsync = await productTag.GetByTagAsync("string");

            //foreach (var prodTag in productTagGetByTagAsync)
            //{
            //    Console.WriteLine(prodTag);
            //}

            //var productTagUpdate = new ProductTagUpdateDto { Id = 2, Name = "ProductTag2" };

            //await productTag.UpdateAsync(productTagUpdate);

            
            //var productTagCreate = new ProductTagCreateDto { Name = "ProductTag1" };

            //await productTag.CreateAsync(productTagCreate);

            var productTemplate = RestService.For<IProductTemplateService>(httpClient);

            //var productTemplateAll = await productTemplate.GetAllAsync();

            //foreach (var prodTemp in productTemplateAll)
            //{
            //    Console.WriteLine(prodTemp);
            //}

            var productVideo = RestService.For<IProductVideoService>(httpClient);

            //var productVideoAll = await productVideo.GetAllAsync();

            //foreach (var prodVid in productVideoAll)
            //{
            //    Console.WriteLine(prodVid);
            //}

            //var productVideoCreate = new ProductVideoCreateDto { ProductId = 1, VideoId = 2, DisplayOrder = 1 };

            //await productVideo.CreateAsync(productVideoCreate);

            //var productVideoGetById = await productVideo.GetByIdAsync(3);

            //Console.WriteLine(productVideoGetById);

            //var productVideoGetByProductId = await productVideo.GetByProductIdAsync(2);

            //Console.WriteLine(productVideoGetByProductId);

            //var productVideoGetByVideoId = await productVideo.GetByVideoIdAsync(2);

            //Console.WriteLine(productVideoGetByVideoId);

            //var productVideoUpdate = new ProductVideoUpdateDto { Id = 4, ProductId = 1, VideoId = 2, DisplayOrder = 3 };

            //await productVideo.UpdateAsync(productVideoUpdate);

            //await productVideo.DeleteAsync(4);

            //await productVideo.GetByIdAsync(4);

            var specificationAttributeGroupService = RestService.For<ISpecificationAttributeGroupService>(httpClient);

            //var specificationAttributeGroupAll = await specificationAttributeGroupService.GetAllAsync();

            //foreach (var specAttrGroup in specificationAttributeGroupAll)
            //{
            //    Console.WriteLine(specAttrGroup);
            //}

            //var specificationAttributeGroupAllCreate = new SpecificationAttributeGroupCreateDto { Name = "SpecificationAttributeGroup1", DisplayOrder = 1 };

            //await specificationAttributeGroupService.CreateAsync(specificationAttributeGroupAllCreate);

            //var specificationAttributeGroupAllUpdate = new SpecificationAttributeGroupUpdateDto { Id = 5, Name = "SpecificationAttributeGroup2", DisplayOrder = 2 };

            //await specificationAttributeGroupService.UpdateAsync(specificationAttributeGroupAllUpdate);            

            //Console.WriteLine(await specificationAttributeGroupService.GetByIdAsync(5));

            //Console.WriteLine(await specificationAttributeGroupService.GetByNameAsync("SpecificationAttributeGroup2"));

            //await specificationAttributeGroupService.DeleteAsync(5);

            //Console.WriteLine(await specificationAttributeGroupService.GetByIdAsync(5));

            var specificationAttributeOptionService = RestService.For<ISpecificationAttributeOptionService>(httpClient);

            //var specificationAttributeOptionServiceGetAll = await specificationAttributeOptionService.GetAllAsync();

            //foreach (var specAttrOpt in specificationAttributeOptionServiceGetAll)
            //{
            //    Console.WriteLine(specAttrOpt);
            //}

            //var specificationAttributeOptionServiceCreate = new SpecificationAttributeOptionCreateDto { SpecificationAttributeId = 1, Name = "SpecificationAttributeOption1", DisplayOrder = 1 };

            //await specificationAttributeOptionService.CreateAsync(specificationAttributeOptionServiceCreate);

            //var specificationAttributeOptionServiceUpdate = new SpecificationAttributeOptionUpdateDto { Id = 5, SpecificationAttributeId = 1, Name = "SpecificationAttributeOption2", DisplayOrder = 2 };

            //await specificationAttributeOptionService.UpdateAsync(specificationAttributeOptionServiceUpdate);

            //Console.WriteLine(await specificationAttributeOptionService.GetByIdAsync(5));

            //Console.WriteLine(await specificationAttributeOptionService.GetAllBySpecificationAttributeIdAsync(5));

            //await specificationAttributeOptionService.DeleteAsync(5);

            var sSpecificationAttributeService = RestService.For<ISpecificationAttributeService>(httpClient);

            //var specificationAttributeServiceGetAll = await sSpecificationAttributeService.GetAllAsync();

            //foreach (var specAttr in specificationAttributeServiceGetAll)
            //{
            //    Console.WriteLine(specAttr);
            //}

            //var specificationAttributeServiceCreate = new SpecificationAttributeCreateDto { Name = "SpecificationAttribute1", DisplayOrder = 1, SpecificationAttributeGroupId = 3 };

            //await sSpecificationAttributeService.CreateAsync(specificationAttributeServiceCreate);
            

            //Console.WriteLine(await sSpecificationAttributeService.GetByIdAsync(12));

            //Console.WriteLine(await sSpecificationAttributeService.GetByNameAsync("SpecificationAttribute1"));

            //var specificationAttributeServiceUpdate = new SpecificationAttributeUpdateDto { Id = 12, Name = "SpecificationAttribute2", DisplayOrder = 2, SpecificationAttributeGroupId = 4 };

            //Console.WriteLine(await sSpecificationAttributeService.GetByIdAsync(12));

            //await sSpecificationAttributeService.UpdateAsync(specificationAttributeServiceUpdate);

            //await sSpecificationAttributeService.DeleteAsync(12);

            //var specificationAttributeServiceGetAllDetails =  await sSpecificationAttributeService.GetAllDetailAsync();

            //foreach (var specAttr in specificationAttributeServiceGetAllDetails)
            //{
            //    Console.WriteLine(specAttr);
            //}

            var stateProvinceService = RestService.For<IStateProvinceService>(httpClient);

            //var stateProvinceServiceGetAll = await stateProvinceService.GetAllAsync();

            //foreach (var stateProv in stateProvinceServiceGetAll)
            //{
            //    Console.WriteLine(stateProv);
            //}

            //var taxCategoryService = RestService.For<ITaxCategoryService>(httpClient);

            //var taxCategoryServiceGetAll = await taxCategoryService.GetAllAsync();

            //foreach (var taxCat in taxCategoryServiceGetAll)
            //{
            //    Console.WriteLine(taxCat);
            //}

            var tierPriceService = RestService.For<ITierPriceService>(httpClient);

            //var tierPriceServiceGetAll = await tierPriceService.GetAllAsync();

            //foreach (var tierPrice in tierPriceServiceGetAll)
            //{
            //    Console.WriteLine(tierPrice);
            //}

            //var tierPriceServiceCreate = new TierPriceCreateDto { StoreId=0, ProductId = 1, CustomerRoleId = 1, Quantity = 1, Price = 1 };

            //await tierPriceService.CreateAsync(tierPriceServiceCreate);

            //var tierPriceServiceGetById = await tierPriceService.GetByIdAsync(1);

            //Console.WriteLine(tierPriceServiceGetById);

            //var tierPriceServiceUpdate = new TierPriceUpdateDto { StoreId = 0, Id = 1, ProductId = 1, CustomerRoleId = 1, Quantity = 2, Price = 2 };

            //await tierPriceService.UpdateAsync(tierPriceServiceUpdate);

            //var tierPriceServiceGetAllDetails = await tierPriceService.GetAllDetailsAsync();

            var iUrlRecordService = RestService.For<IUrlRecordService>(httpClient);

            //var iUrlRecordServiceGetAll = await iUrlRecordService.GetAllAsync();

            //foreach (var urlRec in iUrlRecordServiceGetAll)
            //{
            //    Console.WriteLine(urlRec);
            //}

            //var iUrlRecordServiceCreate = new UrlRecordCreateDto { EntityId = 5, EntityName = "Product", Slug = "Slug1", IsActive = true };

            //await iUrlRecordService.CreateAsync(iUrlRecordServiceCreate);

            //var iUrlRecordServiceGetById = await iUrlRecordService.GetByIdAsync(1);

            //Console.WriteLine(iUrlRecordServiceGetById);

            //var iUrlRecordServiceUpdate = new UrlRecordUpdateDto { Id = 14, EntityId = 6, EntityName = "Product", Slug = "Slug2", IsActive = true };

            //await iUrlRecordService.UpdateAsync(iUrlRecordServiceUpdate);

            //Console.WriteLine(await iUrlRecordService.GetByIdAsync(14)); 
            

            //await iUrlRecordService.DeleteAsync(1);

            var ivideoService = RestService.For<IVideoService>(httpClient);

            //var ivideoServiceGetAll = await ivideoService.GetAllAsync();

            //foreach (var vid in ivideoServiceGetAll)
            //{
            //    Console.WriteLine(vid);
            //}

            //var ivideoServiceCreate = new VideoCreateDto { VideoUrl = "VideoUrl1.com"};

            //await ivideoService.CreateAsync(ivideoServiceCreate);

            //var ivideoServiceGetById = await ivideoService.GetByIdAsync(4);

            //Console.WriteLine(ivideoServiceGetById);

            //var ivideoServiceUpdate = new VideoUpdateDto { Id = 4, VideoUrl = "VideoUrl2.com" };

            //await ivideoService.UpdateAsync(ivideoServiceUpdate);

            //Console.WriteLine(await ivideoService.GetByIdAsync(4));

            //await ivideoService.DeleteAsync(4);

            //Console.WriteLine(await ivideoService.GetByIdAsync(4));


            //Console.WriteLine(await ivideoService.GetByUrlAsync("string2.com"));

            Console.WriteLine("Start");
            var taxApi = RestService.For<ITaxCategoryService>(httpClient);
            //var a = await taxApi.GetByName("PL_8_procent_podstawowa");
            //Console.WriteLine(a.Id);

            var a = await taxApi.GetAllAsync();
            foreach (var b in a)
            {
                Console.WriteLine(b);
            }
            
        }
    }
}