using Osiris;
using Osiris.Data;
using Osiris.Airline.DTOs.Chat;

namespace Osiris.Airline.Services.ChatService
{
    public interface IChatService
    {
        Task<List<ChatMessageDto>> GetChatHistoryAsync(long bookingId, long userId, string role);
        Task<ChatMessageDto> SendMessageAsync(long userId, string role, SendMessageDto dto);
    }
}




