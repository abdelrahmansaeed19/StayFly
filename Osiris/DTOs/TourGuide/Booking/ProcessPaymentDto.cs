using Osiris.TourGuide.Models;
using System.ComponentModel.DataAnnotations;

namespace Osiris.TourGuide.DTOs.Booking
{
    public class ProcessPaymentDto
    {
        [Required]
        public long BookingId { get; set; }
        
        public string? StripePaymentIntentId { get; set; }
        public long? UserSavedCardId { get; set; }
        
        [Required]
        public decimal PlatformCommissionPercentage { get; set; } = 10; // 10% default
    }
}




