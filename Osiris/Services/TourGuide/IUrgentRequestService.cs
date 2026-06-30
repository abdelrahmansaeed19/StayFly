using Osiris.TourGuide.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Osiris.TourGuide.DTOs.UrgentRequest;

namespace Osiris.TourGuide.Services
{
    public interface IUrgentRequestService
    {
        Task<UrgentRequestResponseDto> CreateUrgentRequestAsync(long tourGuideId, CreateUrgentRequestDto model);
        Task<List<UrgentRequestResponseDto>> GetAllPendingRequestsAsync();
        Task<List<UrgentRequestResponseDto>> GetMyRequestsAsync(long tourGuideId);
        Task<UrgentRequestResponseDto> ProcessRequestAsync(long requestId, AdminProcessUrgentRequestDto model);
    }
}



