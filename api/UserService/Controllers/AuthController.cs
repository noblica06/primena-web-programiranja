using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using UserService.DTOs.Auth;
using UserService.Enums;
using UserService.Interfaces;
using UserService.Mappers;
using UserService.Models;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly ITokenService _tokenService;
        private readonly SignInManager<User> _signinManager;

        public AuthController(UserManager<User> userManager, ITokenService tokenService, SignInManager<User> signinManager)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _signinManager = signinManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDTO userRequestDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                var userExists = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == userRequestDTO.Username);
                if (userExists != null)
                    return BadRequest("User already exists.");

                VerificationStatus userStatus = userRequestDTO.Role == "Driver" ? VerificationStatus.Pending : VerificationStatus.None;

                var user = new User
                {
                    UserName = userRequestDTO.Username,
                    Email = userRequestDTO.Email,
                    FirstName = userRequestDTO.FirstName,
                    LastName = userRequestDTO.LastName,
                    DateOfBirth = userRequestDTO.DateOfBirth,
                    Address = userRequestDTO.Address,
                    Status = userStatus,
                };

                //if (!string.IsNullOrEmpty(userRequestDTO.Photo))
                //{
                //    user.Photo = userRequestDTO.Photo;
                //}
                //else
                //{
                //    user.Photo = ImageHelper.GetDefaultImage();
                //}
                user.Photo = "";

                var createdUser = await _userManager.CreateAsync(user, userRequestDTO.Password);
                if (createdUser.Succeeded)
                {
                    var roleResult = await _userManager.AddToRoleAsync(user, userRequestDTO.Role);
                    if (roleResult.Succeeded)
                    {
                        return Ok(user.ToAuthResponseDTO(userRequestDTO.Role, _tokenService.CreateToken(user)));
                    }
                    else
                    {
                        return StatusCode(500, roleResult.Errors);
                    }
                }
                else
                {
                    return StatusCode(500, createdUser.Errors);
                }
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.ToString());
            }
        }
    }
}
