using System.Text.Json.Serialization;

namespace nopCommerceWebApiClient.Interfaces
{
    /// <summary>
    /// This interface is used to implement DTOs that will use DtoMapper.
    /// </summary>
    /// <remarks>
    /// If you want to use DtoMapper on a DTO, the DTO must implement this interface.
    /// The property Type must be marked as [JsonIgnore] in the inherited DTO object.
    /// The inherited IDto object must have properties accessor {get; set;} not {get; init;}
    /// </remarks>
    public interface IDto
    {
        Type Type { get; }
    }
}
