namespace RegistrationApp.Models
{
    public class FormQuestion : Entity
    {
        public int FormId { get; set; }

        public Form Form { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; }
    }
}
