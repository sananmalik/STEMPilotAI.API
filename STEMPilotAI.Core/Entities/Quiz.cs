namespace STEMPilotAI.Core.Entities;

public class Quiz
{
    public int QuizId { get; set; }

    public int SubjectId { get; set; }

    public DateTime CreatedDate { get; set; }

    public Subject? Subject { get; set; }
}