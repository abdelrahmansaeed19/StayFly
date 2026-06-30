using Osiris.DTOs.Common;
using Osiris.DTOs.Auth;

namespace Osiris.Services.Auth
{
    public interface IAuthService
    {
        Task<AuthResponse> RegisterAsync(RegisterRequest request);
        Task<AuthResponse> LoginAsync(LoginRequest request);
        Task<AuthResponse> RefreshTokenAsync(string token, string refreshToken);
        Task<bool> RevokeTokenAsync(string refreshToken);
        Task<UserDto> GetProfileAsync(long userId);
        Task UpdateProfileAsync(long userId, UpdateProfileDto dto);
        Task ChangePasswordAsync(long userId, ChangePasswordDto dto);
    }
}

