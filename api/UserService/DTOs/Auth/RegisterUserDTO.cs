using System.ComponentModel.DataAnnotations;

namespace UserService.DTOs.Auth
{
    public class RegisterUserDTO
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string DateOfBirth { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
        [Required]
        public string Role { get; set; } = string.Empty;
        public string? Photo { get; set; }
    }
}
