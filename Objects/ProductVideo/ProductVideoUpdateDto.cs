namespace nopCommerceWebApiClient.Objects.ProductVideo
{
    public record ProductVideoUpdateDto : ProductVideoDto
    {
        public required override int Id { get; init; }  
    }
}   
