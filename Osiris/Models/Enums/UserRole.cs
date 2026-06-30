using System.Text.Json.Serialization;

namespace Osiris.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UserRole
    {
        User,
        Admin,
        Tourguide,
        Hotel,
        Airline
    }
}

