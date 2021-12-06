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

        public QuestionsController(INlTutContext context)
        {
            _questionService = new QuestionService(new QuestionData(context));
        }
        [HttpGet("/tutorial/start")]
        public ApiQuestion GetQuestion()
        {
            return _questionService.GetFirstQuestion();
        }
        //wanneer je dit callt op je front end moet je tegelijkertijd een api call maken naar je andere server
        // die andere server slaat per account alle antwoorden op
        // Account heeft 1 tutorial
        // tutorial heeft List<Answer> en guid ofc
        //
        [HttpGet("/tutorial/next/{id}")]
        public ApiQuestion AnswerQuestion(string id)
        {
            return _questionService.GetNextQuestion(id);
        }
    }
}