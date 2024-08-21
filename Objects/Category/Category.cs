﻿


namespace nopCommerceWebApiClient.Objects.Category
{
    public record Category
    {
        public virtual int Id { get; init; }

        #region Info

        /// <summary> 
        /// ## Name
        /// ### Gets or sets the name
        /// </summary>
        public required virtual string Name { get; init; }

        /// <summary>
        /// ## Description
        /// ### Gets or sets the description
        /// *Default = null*
        /// </summary>
        public virtual string? Description { get; init; }

        /// <summary>
        /// ## ParentCategoryId
        /// ### Gets or sets the parent category identifier for this category.
        /// #### Set 0 to make this the root level category.
        /// *Default = 0*
        /// </summary>
        public required virtual int ParentCategoryId { get; init; }

        /// <summary>
        /// ## PictureId
        /// ### Gets or sets the picture identifier
        /// #### Set 0 to not use a picture for this category.
        /// *Defalut = 0*
        /// </summary>
        public virtual int PictureId { get; init; }

        #endregion

        #region display
        
        /// <summary>
        /// ## Published
        /// ### Gets or sets a value indicating whether the entity is published
        /// #### Check to publish this category (visible in store). Uncheck to unpublish (category not available in store).
        /// *Default = true*
        /// </summary>
        public virtual bool Published { get; init; }

        /// <summary>
        /// ## ShowOnHomepage
        /// ### Gets or sets a value indicating whether to show the category on home page
        /// *Default = false*
        /// </summary>
        public virtual bool ShowOnHomepage { get; init; }

        /// <summary>
        /// ## IncludeInTopMenu
        /// ### Gets or sets a value indicating whether to include this category in the top menu
        /// #### If this category is a subcategory, then ensure that its parent category also has this property enabled.
        /// *Default = true*
        /// </summary>
        public virtual bool IncludeInTopMenu { get; init; }

        /// <summary>
        /// ## AllowCustomersToSelectPageSize
        /// ### Gets or sets a value indicating whether customers can select the page size
        /// #### Whether customers are allowed to select the page size from a predefined list of options.
        /// *Default = true*
        /// </summary>
        public virtual bool AllowCustomersToSelectPageSize { get; init; }

        /// <summary>
        /// ## PageSize
        /// ### Gets or sets the page size
        /// #### Whether customers are allowed to select the page size from a predefined list of options.        
        /// *Default = 6*
        /// </summary>
        public virtual int PageSize { get; init; }

        /// <summary>
        /// ## PageSizeOptions
        /// ### Gets or sets the available customer selectable page size options
        /// #### Comma separated list of page size options (e.g. 10, 5, 15, 20). 
        /// #### First option is the default page size if none are selected.
        /// #### Note: PageSize should be true if you want to use it.
        /// *Default = "6,3,9"*
        /// </summary>
        public virtual string? PageSizeOptions { get; init; }


        /// <summary>
        /// ## PriceRangeFiltering
        /// ### Gets or sets a value indicating whether the price range filtering is enabled
        /// *Default = true*
        /// </summary>
        public virtual bool PriceRangeFiltering { get; init; }

        /// <summary>
        /// ## ManuallyPriceRange
        /// ### Gets or sets a value indicating whether the price range should be entered manually
        /// #### Check to enter price range manually, otherwise the automatic calculation of price range is 
        /// #### enabled (based on prices of available products). 
        /// #### Set price range manually if you have complex discount rules.
        /// #### Note: PriceRangeFiltering should be true if you want to use it.
        /// *Default = true*
        /// </summary>
        public virtual bool ManuallyPriceRange { get; init; }

        /// <summary>
        /// ## PriceFrom
        /// ### Gets or sets the "from" price
        /// #### Note: ManuallyPriceRange should be true if you want to use it.
        /// *Default = 0m*
        /// </summary>
        public virtual decimal PriceFrom { get; init; }

        /// <summary>
        /// ## PriceTo
        /// ### Gets or sets the "to" price
        /// #### Note: ManuallyPriceRange should be true if you want to use it.
        /// *Default = 20000*
        /// </summary>
        public virtual decimal PriceTo { get; init; }

        /// <summary>
        /// ## DisplayOrder
        /// ### Gets or sets the display order
        /// #### Set the category's display order. 1 represents the top of the list.
        /// *Default = 0*
        /// </summary>
        public virtual int DisplayOrder { get; init; }

        #endregion

        #region Mappings
        
        /// <summary>
        /// ## LimitedToStores
        /// ### Gets or sets a value indicating whether the entity is limited/restricted to certain stores
        /// </summary>
        public virtual bool LimitedToStores { get; init; }

        #endregion

        #region SEO

        /// <summary>
        /// ## Name
        /// ## MetaKeywords
        /// ### Gets or sets the meta keywords
        /// *Default = null*
        /// </summary>
        public virtual string? MetaKeywords { get; init; }

        /// <summary>
        /// ## MetaTitle
        /// ### Gets or sets the meta title
        /// *Default = null*
        /// </summary>
        public virtual string? MetaTitle { get; init; }

        /// <summary>
        /// ## MetaDescription
        /// ### Gets or sets the meta description
        /// *Default = null*
        /// </summary>
        public virtual string? MetaDescription { get; init; }

        #endregion

        /// <summary>
        /// ## CategoryTemplateId
        /// ### Gets or sets a value of used category template identifier
        /// #### Look on System -> Templates -> Category templates
        /// #### Doc: https://docs.nopcommerce.com/en/running-your-store/system-administration/templates.html
        /// *Default = 1*
        /// </summary>
        public virtual int CategoryTemplateId { get; init; }

        /// <summary>
        /// ## SubjectToAcl
        /// ### Gets or sets a value indicating whether the entity is subject to ACL
        /// #### Access control list is a list of permissions attached to customer roles. This list specifies the access rights of users to objects.
        /// #### Look on Configuration -> Access control list
        /// #### Doc: https://docs.nopcommerce.com/en/running-your-store/customer-management/access-control-list.html?utm_source=admin-panel&utm_medium=admin-page&utm_campaign=documentation&utm_content=doc-reference
        /// *Default = false*
        /// </summary>
        public virtual bool SubjectToAcl { get; init; }

        /// <summary>
        /// ## Deleted
        /// ### Gets or sets a value indicating whether the entity has been deleted
        /// *Default = false*
        /// </summary>
        public virtual bool Deleted { get; init; } 

        /// <summary>
        /// ## CreatedOnUtc
        /// ### Gets or sets the date and time of instance creation
        /// *Default = Datetime.Now (when create)*
        /// </summary>
        public virtual DateTime CreatedOnUtc { get; }

        /// <summary>
        /// ## UpdatedOnUtc
        /// ### Gets or sets the date and time of instance update
        /// *Default = Datetime.Now (when update)*
        /// </summary>
        public virtual DateTime UpdatedOnUtc { get; }
    }
}
