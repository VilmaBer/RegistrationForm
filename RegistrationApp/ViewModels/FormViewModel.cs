using RegistrationApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace RegistrationApp.ViewModels
{
    public class FormViewModel
    {
        public bool DisableEdit;

        public Form Form { get; set; }

        public List<Question> Questions { get; set; }

        public List<FormQuestionAnswer> FormQuestionAnswers { get; set; }

        public FormQuestionAnswer GetFormQuestionAnswer(int questionId)
        {
            return FormQuestionAnswers.FirstOrDefault(x => x.QuestionId == questionId);
        }

        public List<Answer> GetAnswers(int questionId)
        {
            var answers = Questions.FirstOrDefault(x => x.Id == questionId)?.Answers;
            answers.Insert(0, new Answer { Id = -1, Title = "Pasirinkti..." });
            return answers;
        }
    }
}
