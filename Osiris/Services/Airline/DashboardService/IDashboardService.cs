using Osiris;
using Osiris.Data;
using Osiris.Airline.DTOs.Dashboard;

namespace Osiris.Airline.Services.DashboardService
{
    public interface IDashboardService
    {
        Task<DashboardStatsDto> GetStatsAsync();
    }
}




