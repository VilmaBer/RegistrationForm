namespace RegistrationApp.Models
{
    public class QuestionAnswer : Entity
    {
        public int QuestionId { get; set; }

        public Question Question { get; set; }

        public int AnswerId { get; set; }

        public Answer Answer { get; set; }

    }
}