using Osiris.TourGuide.Models.Enums;
using Osiris.Models;
using Osiris.Models.Auth;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Osiris.Models.Enums;

namespace Osiris.TourGuide.Models
{
    public class TourGuideLanguage
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("TourGuide")]
        public long TourGuideId { get; set; }
        public TourGuide TourGuide { get; set; }

        [Required]
        public Language Language { get; set; }
    }
}




