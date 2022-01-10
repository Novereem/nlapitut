using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using nl.Commen.Models;

namespace nl.Commen.Interfaces
{
    public interface IQuestionData
    {
        Question GetQuestion(int id);
        Answer GetAnswer(string id);
        void SaveUserAnswers(UserAnswer userAnswer);
        void SaveSingleAnswer(string token, string answerId);
        List<Answer> GetAnswers(int id);
        void RemovePreExistingUserAnswers(string token);
        //void SaveAnswer(string token, string answer);
        List<SingleAnswerTemp> GetUserAnswers(string token);
    }
}