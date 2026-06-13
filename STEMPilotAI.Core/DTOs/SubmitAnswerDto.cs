namespace STEMPilotAI.Core.DTOs;

public class SubmitAnswerDto
{
    public int QuestionId { get; set; }

    public string SelectedAnswer { get; set; } = string.Empty;
}