using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using nl.Commen.Interfaces;
using nl.Commen.Models.ApiModels;
using nl.Data;
using nl.Logic;

namespace nltutorialapi.Controllers
{
    [EnableCors("AllowCORS")]
    [ApiController]
    [Route("[controller]")]
    public class QuestionsController : Controller
    {
        private readonly QuestionService _questionService;
        private readonly AnswerService _answerService;

        public QuestionsController(NlTutContext context)
        {
            _answerService = new AnswerService(new AnswerData(context));
            _questionService = new QuestionService(new QuestionData(context));
        }

        [HttpGet("/tutorial/start/{token}")]
        public ApiQuestion FirstQuestion(string token)
        {
            return _questionService.GetFirstQuestion(token);
        }
        [HttpPost("/tutorial/next")]
        public object AnswerQuestion(ApiAnswer apiAnswer)
        {
            return _questionService.GetNextQuestion(apiAnswer.AnswerId, apiAnswer.Token);
        }

        [HttpGet("/tutorial/results/{token}")]
        public object GetResults(string token)
        {
            return _answerService.GetResults(token);
        }
    }
}