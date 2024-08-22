namespace nopCommerceWebApiClient.Objects.Product
{
    public record ProductUpdateBlockAttributeDto
    {
        /// <summary>
        /// ## AllowAddingOnlyExistingAttributeCombinations
        /// ### Set a value indicating whether we allow adding to the cart/wishlist only attribute combinations that exist and have stock greater than zero.
        /// #### This option is used only when we have "manage inventory" set to "track inventory by product attributes"
        /// *Default = false*
        /// </summary>
        public virtual bool AllowAddingOnlyExistingAttributeCombinations { get; init; }

        /// <summary>
        /// ## DisplayAttributeCombinationImagesOnly
        /// ### Set a value indicating whether to display attribute combination images only
        /// *Default = false*
        /// </summary>
        public virtual bool DisplayAttributeCombinationImagesOnly { get; init; }
    }
}
