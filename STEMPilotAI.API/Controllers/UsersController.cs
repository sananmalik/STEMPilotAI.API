using Microsoft.AspNetCore.Mvc;
using STEMPilotAI.Core.DTOs;
using STEMPilotAI.Core.Responses;
using STEMPilotAI.Infrastructure.Data;
using System.Linq;

namespace STEMPilotAI.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly AppDbContext _context;

    public UsersController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterUserDto dto)
    {
        var user = new Core.Entities.User
        {
            Name = dto.Name,
            Email = dto.Email,
            PasswordHash = dto.Password
        };

        _context.Users.Add(user);

        _context.SaveChanges();

        return Ok(new ApiResponse
        {
            Success = true,
            Message = "User registered successfully"
        });
    }

    [HttpPost("login")]
    public IActionResult Login(LoginUserDto dto)
    {
        var user = _context.Users.FirstOrDefault(x =>
            x.Email == dto.Email &&
            x.PasswordHash == dto.Password);

        if (user == null)
        {
            return BadRequest(new ApiResponse
            {
                Success = false,
                Message = "Invalid email or password"
            });
        }

        return Ok(new ApiResponse
        {
            Success = true,
            Message = "Login successful"
        });
    }
}