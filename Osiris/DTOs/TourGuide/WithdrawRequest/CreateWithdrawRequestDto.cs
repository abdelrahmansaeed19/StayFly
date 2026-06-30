using Osiris.TourGuide.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Osiris.TourGuide.DTOs.WithdrawRequest
{
    public class CreateWithdrawRequestDto
    {
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }
    }
}




