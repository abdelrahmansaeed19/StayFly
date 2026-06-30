using Osiris.TourGuide.Models;
using System.ComponentModel.DataAnnotations;

namespace Osiris.TourGuide.DTOs.TourGuide
{
    public class RejectApplicationDto
    {
        [Required]
        public string Reason { get; set; }
    }
}




