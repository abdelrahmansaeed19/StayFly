using System.Text.Json.Serialization;

namespace Osiris.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UserStatus
    {
        Pending,
        Active,
        Inactive,
        Suspended,
        Banned
    }
}

