using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using nl.Commen.Interfaces;
using nl.Commen.Models;

namespace nl.Data
{
    public class QuestionData : IQuestionData
    {
        private readonly INlTutContext _context;

        public QuestionData(INlTutContext context)
        {
            _context = context;
        }
        
        public void SaveSingleAnswer(string token, string answerId)
        {
            SingleAnswerTemp singleAnswer = new SingleAnswerTemp(answerId, token);
            _context.SingleAnswerTemp.Add(singleAnswer);
            _context.SaveChanges();
        }
        
        public List<SingleAnswerTemp> GetUserAnswersTemps(string token)
        {
            List<SingleAnswerTemp> singleAnswerTemps = _context.SingleAnswerTemp.Where(a => a.Token == token).ToList();
            return singleAnswerTemps;
        }

        public void SaveUserAnswers(UserAnswer userAnswer)
        {
            _context.Add(userAnswer);
            RemovePreExistingUserAnswers(userAnswer.Token);
            _context.SaveChanges();
        }

        
        public List<Answer> GetAnswers(int id)
        {
            return _context.Answer.Where(x => x.QuestionId == id).ToList();

        }
        public Answer GetAnswer(string id)
        {
            return _context.Answer.FirstOrDefault(x => x.Id.ToString() == id);
        }
        
        public Question GetQuestion(int id)
        {
            return _context.Question.FirstOrDefault(x => x.Id == id);
        }

        public void RemovePreExistingUserAnswers(string token)
        {
            _context.SingleAnswerTemp.RemoveRange(_context.SingleAnswerTemp.Where(a => a.Token == token));
            _context.UserAnswers.RemoveRange(_context.UserAnswers.Where(u => u.Token == token));
            _context.SingeAnswers.RemoveRange(_context.SingeAnswers.Where(u => u.Token == token));
        }
        /*public void SaveAnswer(string token, string answerId)
        {
            Results results = GetResults(token);
            results.Answers.Add(new UserAnswer(answerId));
            
            _context.SaveChanges();
        }*/
    }
}