using Microsoft.AspNetCore.Mvc;
using STEMPilotAI.Core.DTOs;
using STEMPilotAI.Core.Entities;
using STEMPilotAI.Infrastructure.Data;

namespace STEMPilotAI.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuestionsController : ControllerBase
{
    private readonly AppDbContext _context;

    public QuestionsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Create(CreateQuestionDto dto)
    {
        var question = new Question
        {
            SubjectId = dto.SubjectId,
            QuestionText = dto.QuestionText,
            OptionA = dto.OptionA,
            OptionB = dto.OptionB,
            OptionC = dto.OptionC,
            OptionD = dto.OptionD,
            CorrectAnswer = dto.CorrectAnswer
        };

        _context.Questions.Add(question);
        _context.SaveChanges();

        return Ok(question);
    }

    [HttpGet("subject/{subjectId}")]
    public IActionResult GetBySubject(int subjectId)
    {
        var questions = _context.Questions
            .Where(q => q.SubjectId == subjectId)
            .ToList();

        return Ok(questions);
    }
}