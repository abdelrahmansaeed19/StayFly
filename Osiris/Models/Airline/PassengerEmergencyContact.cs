using Osiris.Models.Enums;
using Osiris.Models;
using Osiris.Models.Auth;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Osiris.Airline.Models
{
    public class PassengerEmergencyContact
    {
        [Key]
        public long Id { get; set; }

        public long PassengerId { get; set; }
        [ForeignKey("PassengerId")]
        public Passenger Passenger { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string EmergencyName { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; } = null!;
    }
}



