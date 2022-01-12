namespace RegistrationApp.Models
{
    public class FormQuestionAnswer : Entity
    {
        public int FormId { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; }

        public int AnswerId { get; set; }

        public Answer Answer { get; set; }
    }
}
