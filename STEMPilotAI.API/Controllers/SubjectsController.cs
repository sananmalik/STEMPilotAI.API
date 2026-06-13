using Microsoft.AspNetCore.Mvc;
using STEMPilotAI.Core.DTOs;
using STEMPilotAI.Core.Entities;
using STEMPilotAI.Infrastructure.Data;

namespace STEMPilotAI.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubjectsController : ControllerBase
{
    private readonly AppDbContext _context;

    public SubjectsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Create(CreateSubjectDto dto)
    {
        var subject = new Subject
        {
            SubjectName = dto.SubjectName
        };

        _context.Subjects.Add(subject);

        _context.SaveChanges();

        return Ok(subject);
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.Subjects.ToList());
    }
}