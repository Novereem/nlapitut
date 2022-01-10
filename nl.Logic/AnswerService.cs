using System.Collections.Generic;
using System.Linq;
using nl.Commen.Interfaces;
using nl.Commen.Models;

namespace nl.Logic
{
    public class AnswerService
    {
        private readonly IAnswerData _answerData;
        private readonly IQuestionData _questionData;

        public AnswerService(IAnswerData answerData, IQuestionData questionData)
        {
            _answerData = answerData;
            _questionData = questionData;
        }

        /*public Laptop GetLaptop()
        {
            
        }*/
    }
}