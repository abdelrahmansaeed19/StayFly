using Osiris.TourGuide.Models.Enums;
using Osiris.Models;
using Osiris.Models.Auth;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Osiris.TourGuide.Models
{
    public class TourParticipantPhone
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("Participant")]
        public long ParticipantId { get; set; }
        public TourBookingParticipant Participant { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}




