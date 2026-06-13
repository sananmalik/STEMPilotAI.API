using Microsoft.AspNetCore.Mvc;
using STEMPilotAI.Core.DTOs;
using STEMPilotAI.Core.Entities;
using STEMPilotAI.Infrastructure.Data;

namespace STEMPilotAI.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuizController : ControllerBase
{
    private readonly AppDbContext _context;

    public QuizController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("submit")]
    public IActionResult SubmitQuiz(SubmitQuizDto dto)
    {
        int score = 0;

        foreach (var answer in dto.Answers)
        {
            var question = _context.Questions
                .FirstOrDefault(q => q.QuestionId == answer.QuestionId);

            if (question != null &&
                question.CorrectAnswer.Equals(
                    answer.SelectedAnswer,
                    StringComparison.OrdinalIgnoreCase))
            {
                score++;
            }
        }

        var result = new QuizResult
        {
            UserId = dto.UserId,
            SubjectId = dto.SubjectId,
            Score = score,
            AttemptDate = DateTime.Now
        };

        _context.QuizResults.Add(result);
        _context.SaveChanges();

        return Ok(new
        {
            Score = score,
            TotalQuestions = dto.Answers.Count,
            Percentage = (double)score / dto.Answers.Count * 100
        });
    }
}