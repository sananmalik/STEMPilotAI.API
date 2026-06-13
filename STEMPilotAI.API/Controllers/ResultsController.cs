using Microsoft.AspNetCore.Mvc;
using STEMPilotAI.Infrastructure.Data;

namespace STEMPilotAI.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ResultsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ResultsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("user/{userId}")]
    public IActionResult GetUserResults(int userId)
    {
        var results = _context.QuizResults
            .Where(r => r.UserId == userId)
            .OrderByDescending(r => r.AttemptDate)
            .ToList();

        return Ok(results);
    }
}