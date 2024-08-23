

namespace nopCommerceWebApiClient.Objects.ProductAttributeValue
{
    public record ProductAttributeValueCreateDto : ProductAttributeValueDto
    {
        public new int Id { get; }

        /// <summary>
        /// ## ProductAttributeMappingId
        /// ### Gets the product attribute mapping identifier
        /// #### Gets product id which is associate with this attribute value
        /// #### It's id of product
        /// #### It's set by web api service
        /// </summary>
        public new int ProductAttributeMappingId { get; }
    }
}
