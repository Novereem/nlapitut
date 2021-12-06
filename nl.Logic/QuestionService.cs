using System.Collections.Generic;
using nl.Commen.Interfaces;
using nl.Commen.Models;
using nl.Commen.Models.ApiModels;

namespace nl.Logic
{
    public class QuestionService
    {
        private readonly IQuestionData _questionData;

        public QuestionService(IQuestionData questionData)
        {
            _questionData = questionData;
        }

        public ApiQuestion GetFirstQuestion()
        {
            Question question = _questionData.GetQuestion(1);
            List<Answer> answers = GetAnswers(1);
            return new ApiQuestion(question.Id, question.Text, answers);
        }

        public ApiQuestion GetNextQuestion(string answerId)
        {
            Question question = _questionData.GetQuestion(_questionData.GetAnswer(answerId).NextQuestionId);
            List<Answer> answers = GetAnswers(question.Id);
            return new ApiQuestion(question.Id, question.Text, answers);
        }

        public List<Answer> GetAnswers(int questionId)
        {
            return _questionData.GetAnswers(questionId);
        }
    }
}