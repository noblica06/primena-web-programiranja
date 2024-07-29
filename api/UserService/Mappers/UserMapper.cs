using UserService.DTOs.Auth;
using UserService.Models;

namespace UserService.Mappers
{
    public static class UserMapper
    {
        public static AuthResponseDTO ToAuthResponseDTO(this User user, string role, string token)
        {
            return new AuthResponseDTO
            {
                Username = user.UserName,
                Email = user.Email,
                Role = role,
                Token = token
            };
        }
    }
}
