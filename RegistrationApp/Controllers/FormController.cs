using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistrationApp.Data;
using RegistrationApp.Models;
using RegistrationApp.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace RegistrationApp.Controllers
{
    public class FormController : Controller
    {
        private DataContext _context;

        public FormController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var forms = _context.Forms.ToList();
            return View(forms);
        }
        public IActionResult Details(int id, bool disableEdit = true)
        {
            var form = GetForm(id);

            if (form == null)
                return NotFound();

            var formViewModel = CreateFormViewModel(form, disableEdit);

            return View(formViewModel);
        }

        [HttpPost]
        public IActionResult Details(List<FormQuestionAnswer> fqas)
        {
            var formId = fqas.FirstOrDefault().FormId;
            foreach (var fqa in fqas)
            {
                if (fqa.Id == 0 && fqa.AnswerId > 0)
                {
                    _context.FormsQuestionsAnswers.Add(fqa);
                    continue;
                }

                if (fqa.Id > 0)
                {
                    if (fqa.AnswerId > 0)
                    {
                        _context.FormsQuestionsAnswers.Update(fqa);
                        continue;
                    }

                    if (fqa.AnswerId == -1)
                    {
                        _context.FormsQuestionsAnswers.Remove(fqa);
                    }
                }
            }

            _context.SaveChanges();

            return RedirectToAction("Details", new { id = formId, disableEdit = false });
        }
        private static FormViewModel CreateFormViewModel(Form form, bool disableEdit)
        {
            var formViewModel = new FormViewModel();
            formViewModel.DisableEdit = disableEdit;
            formViewModel.Form = form;
            
            var questions = form.FormQuestions.Select(c => c.Question).ToList();
            formViewModel.Questions = questions;

            formViewModel.FormQuestionAnswers = form.FormQuestionAnswers.ToList();
            return formViewModel;
        }

        private Form GetForm(int id)
        {
            var form = _context.Forms
                            .Include(f => f.FormQuestions)
                            .ThenInclude(fq => fq.Question)
                            .ThenInclude(q => q.QuestionAnswers)
                            .ThenInclude(qa => qa.Answer)
                            .Include(f => f.FormQuestionAnswers)
                            .ThenInclude(fqa => fqa.Answer)
                               .SingleOrDefault(f => f.Id == id);
            return form;
        }
    }
}
