using System.Text.Json.Serialization;

namespace Osiris.TourGuide.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WithdrawRequestStatus
    {
        Pending,
        Approved,
        Rejected
    }
}



