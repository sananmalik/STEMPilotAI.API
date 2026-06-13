using Microsoft.AspNetCore.Mvc;
using STEMPilotAI.Infrastructure.Data;

namespace STEMPilotAI.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DashboardController : ControllerBase
{
    private readonly AppDbContext _context;

    public DashboardController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("user/{userId}")]
    public IActionResult GetDashboard(int userId)
    {
        var results = _context.QuizResults
            .Where(r => r.UserId == userId)
            .ToList();

        if (!results.Any())
        {
            return Ok(new
            {
                TotalAttempts = 0,
                AverageScore = 0,
                BestScore = 0
            });
        }

        return Ok(new
        {
            TotalAttempts = results.Count,
            AverageScore = results.Average(r => r.Score),
            BestScore = results.Max(r => r.Score),
            WorstScore = results.Min(r => r.Score)
        });
    }
}