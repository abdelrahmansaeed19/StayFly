using Osiris.TourGuide.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Osiris.TourGuide.DTOs.WithdrawRequest
{
    public class ProcessWithdrawRequestDto
    {
        [Required]
        public string Status { get; set; } // Approved or Rejected
        
        public string? AdminNotes { get; set; }
    }
}




