using System.Collections.Generic;

namespace RegistrationApp.Models
{
    public class Answer : Entity
     {
        public string Title { get; set; }

        public List<QuestionAnswer> QuestionAnswers { get; set; }

        public List<FormQuestionAnswer> FormQuestionAnswers { get; set; }

    }
}
