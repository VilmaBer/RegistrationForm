using System.Collections.Generic;

namespace RegistrationApp.Models
{
    public class Form : Entity
    {
        public string Title { get; set; }

        public List<FormQuestion> FormQuestions { get; set; }

        public List<FormQuestionAnswer> FormQuestionAnswers { get; set; }
    }
}
