using Osiris;
using Osiris.Data;
using Osiris.Airline.DTOs.Companion;

namespace Osiris.Airline.Services.CompanionService
{
    public interface ICompanionService
    {
        Task<List<UserCompanionDto>> GetMyCompanionsAsync(long userId);
        Task<UserCompanionDto> AddCompanionAsync(long userId, CreateCompanionDto dto);
        Task DeleteCompanionAsync(long userId, long companionId);
    }
}




