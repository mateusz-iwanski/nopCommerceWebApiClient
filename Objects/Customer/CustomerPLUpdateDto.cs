using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace nopCommerceWebApiClient.Objects.Customer
{
    public record CustomerPLUpdateDto : CustomerCreatePLDto
    {
        public required int Id { get; init; }
    }
}
