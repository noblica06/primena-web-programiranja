using Microsoft.AspNetCore.Identity;
using UserService.Enums;

namespace UserService.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public VerificationStatus Status { get; set; }
        public string? Photo { get; set; }
    }
}
