using System.Collections.Generic;
using nl.Commen.Models;

namespace nl.Commen.Interfaces
{
    public interface IQuestionData
    {
        Question GetQuestion(int id);
        Answer GetAnswer(string id);
        List<Answer> GetAnswers(int id);
    }
}