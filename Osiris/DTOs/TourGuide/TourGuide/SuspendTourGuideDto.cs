using Osiris.TourGuide.Models;
using System.ComponentModel.DataAnnotations;
using Osiris.Models.Enums;
using Osiris.TourGuide.Models.Enums;

namespace Osiris.TourGuide.DTOs.TourGuide
{
    public class SuspendTourGuideDto
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Duration { get; set; }

        [Required]
        public SuspensionUnit Unit { get; set; }
    }
}




