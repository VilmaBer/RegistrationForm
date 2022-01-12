
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace RegistrationApp.Models
{
    public class Question : Entity
    {
        public string Title { get; set; }

        public List<QuestionAnswer> QuestionAnswers { get; set; }

        public List<FormQuestion> FormQuestions { get; set; }

        public List<FormQuestionAnswer> FormQuestionAnswers { get; set; }

        [NotMapped]
        public List<Answer> Answers => QuestionAnswers?.Select(c => c?.Answer).ToList();
    }
}