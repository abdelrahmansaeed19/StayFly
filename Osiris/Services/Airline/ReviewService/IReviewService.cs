using Osiris;
using Osiris.Data;
using Osiris.Airline.DTOs.Review;

namespace Osiris.Airline.Services.ReviewService
{
    public interface IReviewService
    {
        Task<ReviewResponseDto> AddReviewAsync(long userId, ReviewRequestDto dto);
        Task<List<ReviewResponseDto>> GetFlightReviewsAsync(long flightId);
    }
}




