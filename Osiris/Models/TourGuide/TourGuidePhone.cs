using Osiris.TourGuide.Models.Enums;
using Osiris.Models;
using Osiris.Models.Auth;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Osiris.TourGuide.Models
{
    public class TourGuidePhone
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("TourGuide")]
        public long TourGuideId { get; set; }
        public TourGuide TourGuide { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        public bool PhoneVerified { get; set; } = false;
    }
}




