using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class QuizController : Controller
    {
        public async Task<IActionResult> Start()
        {
            return await Task.FromResult(this.View());
        }

        public async Task<IActionResult> Question(string urlId, int? questionNumber)
        {
            const int actualQuestionNumber = 2;
            
            if (questionNumber != null && questionNumber.Value != actualQuestionNumber)
            {
                // Redirect to question 2
                return await Task.FromResult(this.RedirectToRoute("Quiz", new { urlId = urlId, questionNumber = actualQuestionNumber }));
            }

            return await Task.FromResult(this.View());
        }
    }
}