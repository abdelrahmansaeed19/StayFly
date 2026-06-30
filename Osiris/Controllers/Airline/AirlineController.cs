using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Osiris.Data;

using Osiris.DTOs.Common;
using Osiris.DTOs.Auth;
using Osiris.Airline.Models.Airlines;
using Osiris.Airline.DTOs.Airline;
using Osiris.Models.Enums;

namespace Osiris.Airline.Controllers
{
    [ApiController]
    [Route("api/airline/airlines")]
    [ApiExplorerSettings(GroupName = "Airline")]
    public class AirlineController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AirlineController(ApplicationDbContext context)
        {
            _context = context;
        }

        // =============================
        // Create Airline (Admin)
        // =============================
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateAirlineDto dto)
        {
            if (await _context.Airlines.AnyAsync(a => a.Name == dto.Name))
                return BadRequest(new ApiResponse<string>(false, "Airline already exists"));

            var airline = new Osiris.Airline.Models.Airlines.Airline
            {
                Name = dto.Name,
                UserId = dto.UserId, // Admin assigns the user owner
                Country = dto.Country,
                LogoUrl = dto.LogoUrl,
                Verified = true,
                Status = "Approved",
                IsApproved = true
            };

            _context.Airlines.Add(airline);
            await _context.SaveChangesAsync();

            return Ok(new ApiResponse<object>(
                new { airline.Id, airline.Name },
                "Airline created successfully"
            ));
        }

        // =============================
        // Get All Airlines
        // =============================
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var airlines = await _context.Airlines
                .Select(a => new { id = a.Id, name = a.Name, country = a.Country, logoUrl = a.LogoUrl })
                .ToListAsync();

            return Ok(new ApiResponse<object>(airlines));
        }
    }
}

