using System.Text.Json.Serialization;

namespace nopCommerceWebApiClient.Interfaces
{
    /// <summary>
    /// This interface is used to implement DTOs that will use DtoMapper.
    /// </summary>
    /// <remarks>
    /// If you want to use DtoMapper on a DTO, the DTO must implement this interface.
    /// The type must be marked as [JsonIgnore] in the inherited DTO object
    /// </remarks>
    public interface IDto
    {
        Type Type { get; }
    }
}
