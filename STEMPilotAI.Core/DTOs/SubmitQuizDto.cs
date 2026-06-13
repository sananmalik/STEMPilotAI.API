namespace STEMPilotAI.Core.DTOs;

public class SubmitQuizDto
{
    public int UserId { get; set; }

    public int SubjectId { get; set; }

    public List<SubmitAnswerDto> Answers { get; set; } = new();
}