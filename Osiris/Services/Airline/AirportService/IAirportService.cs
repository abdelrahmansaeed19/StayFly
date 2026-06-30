using Osiris;
using Osiris.Data;
using Osiris.Airline.DTOs.Airport;

namespace Osiris.Airline.Services.AirportService
{
    public interface IAirportService
    {
        Task<List<AirportDto>> GetAllAsync();
        Task<List<AirportDto>> SearchAsync(string query);
        Task<AirportDto?> GetByCodeAsync(string code);
        Task CreateAsync(CreateAirportDto dto);
        Task DeleteAsync(string code);
    }
}




